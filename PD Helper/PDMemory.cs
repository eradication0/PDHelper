using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PD_Helper
{
	public class PDMemory
	{
		// Credit to code: https://stackoverflow.com/questions/4623029/how-can-i-write-on-another-process-memory

		// External memory functions.
		[DllImport("kernel32.dll")]
		static extern IntPtr OpenProcess(ProcessAccessFlags dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, int dwProcessId);

		[DllImport("kernel32.dll")]
		static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [Out] byte[] lpBuffer, uint nSize, out IntPtr lpNumberOfBytesRead);

		[DllImport("kernel32.dll", SetLastError = true)]
		static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out IntPtr lpNumberOfBytesWritten);

		[DllImport("kernel32.dll")]
		static extern Int32 CloseHandle(IntPtr hProcess);

		[DllImport("kernel32")]
		static extern bool IsWow64Process(IntPtr hProcess, out bool lpSystemInfo);

		// Flags
		[Flags]
		public enum ProcessAccessFlags : uint
		{
			All = 0x001F0FFF,
			Terminate = 0x00000001,
			CreateThread = 0x00000002,
			VMOperation = 0x00000008,
			VMRead = 0x00000010,
			VMWrite = 0x00000020,
			DupHandle = 0x00000040,
			SetInformation = 0x00000200,
			QueryInformation = 0x00000400,
			Synchronize = 0x00100000
		}

		// Phantom Dust Process
		public Process? pdProcess = null;
		IntPtr handle = IntPtr.Zero;
		//bool is64Bit; // Assuming this is true.
		ProcessModule mainModule;

		// Offsets
		Int64[] cardOffsets = new Int64[375];
		Int64[] arsenalNameOffsets = new Int64[16];
		Int64[] arsenalCardsOffsets = new Int64[16];

		public PDMemory()
		{
			for (int i = 0x644; i <= 0x7BA; i++)
			{
				cardOffsets[i - 0x644] = i;
			}

			int j = 0;
			for (int i = 0x8; i <= 0x5E4; i += 0x64)
			{
				arsenalNameOffsets[j] = i;
				arsenalCardsOffsets[j] = i + 0x10;
				j++;
			}
		}

		public Process? LinkPD()
		{
			if (pdProcess != null) return pdProcess;
			
			pdProcess = Process.GetProcessesByName("PDUWP").FirstOrDefault();
			if (pdProcess == null) return null;

			handle = OpenProcess(ProcessAccessFlags.All, true, pdProcess.Id);
			//is64Bit = Environment.Is64BitOperatingSystem && (IsWow64Process(handle, out bool retVal) && !retVal);
			mainModule = pdProcess.MainModule;
			return pdProcess;
		}

		public IntPtr GetAddress(Int64[] offsets)
		{
			LinkPD();
			if (pdProcess == null) return IntPtr.Zero;

			uint size = 16;
			byte[] memoryAddress = new byte[size];
			IntPtr zero = IntPtr.Zero;
			ReadProcessMemory(handle, new IntPtr((Int64)mainModule.BaseAddress + offsets[0]), memoryAddress, size, out zero);

			Int64 num = BitConverter.ToInt64(memoryAddress, 0);
			IntPtr basePtr = IntPtr.Zero;

			for (int i = 1; i < offsets.Length; i++)
			{
				basePtr = new IntPtr(Convert.ToInt64(num + offsets[i]));
				ReadProcessMemory(handle, basePtr, memoryAddress, size, out zero);
				num = BitConverter.ToInt64(memoryAddress, 0);
			}

			return basePtr;
		}

		public bool GiveMaxSkills()
		{
			LinkPD();
			if (pdProcess == null) return false;

			IntPtr zero = IntPtr.Zero;
			foreach (Int64 cardOffset in cardOffsets)
			{
				// Address
				Int64[] offsets = { 0x3ED6B8, cardOffset };
				IntPtr address = GetAddress(offsets);

				// Memory
				byte[] memory = { 99 };

				// Write
				if (!WriteProcessMemory(handle, address, memory, 1, out zero)) return false;
			}

			return true;
		}

		public bool GiveMaxCredits()
		{
			LinkPD();
			if (pdProcess == null) return false;

			// Address
			Int64[] offsets = { 0x3ED640, 0x13B };
			IntPtr address = GetAddress(offsets);

			// Memory
			byte[] memory = {0x30};

			// Write
			IntPtr zero = IntPtr.Zero;
			return WriteProcessMemory(handle, address, memory, 1, out zero);
		}

		public bool GetPartnerLockOn()
		{
			LinkPD();
			if (pdProcess == null) return false;

			// Address
			Int64[] offsets = { 0x3ED688, 0x9 };
			IntPtr address = GetAddress(offsets);

			// Memory
			byte[] memoryAddress = new byte[1];

			// Read
			IntPtr zero = IntPtr.Zero;
			return ReadProcessMemory(handle, address, memoryAddress, 1, out zero) && memoryAddress[0] == 1;
		}

		public bool SetPartnerLockOn(bool state)
		{
			LinkPD();
			if (pdProcess == null) return false;

			// Address
			Int64[] offsets = { 0x3ED688, 0x9 };
			IntPtr address = GetAddress(offsets);

			// Memory
			byte[] memory = { state ? (byte)0x1 : (byte)0x0 };

			// Write
			IntPtr zero = IntPtr.Zero;
			return WriteProcessMemory(handle, address, memory, 1, out zero);
		}

		public string[] GetArsenalNames()
		{
			LinkPD();
			if (pdProcess == null) return null;

			string[] arsenalNames = new string[16];
			for (int i = 0; i < 16; i++)
			{
				// Address
				Int64[] offsets = { 0x3ED6B8, arsenalNameOffsets[i] };
				IntPtr address = GetAddress(offsets);

				// Memory
				byte[] memoryAddress = new byte[16];

				// Encoding
				Encoding encoding = Encoding.UTF8;

				// Read
				IntPtr zero = IntPtr.Zero;
				if (ReadProcessMemory(handle, address, memoryAddress, 16, out zero))
				{
					arsenalNames[i] = encoding.GetString(memoryAddress).Split('\0')[0];
				}
				else
				{
					return null;
				}
			}

			return arsenalNames;
		}
	}
}
