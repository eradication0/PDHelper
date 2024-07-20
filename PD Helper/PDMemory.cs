using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PD_Helper
{
	internal class PDMemory
	{
		// Credit to code: https://stackoverflow.com/questions/4623029/how-can-i-write-on-another-process-memory

		// External memory functions.
		[DllImport("kernel32.dll")]
		static extern IntPtr OpenProcess(ProcessAccessFlags dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, int dwProcessId);

		[DllImport("kernel32.dll", SetLastError = true)]
		static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out int lpNumberOfBytesWritten);

		[DllImport("kernel32.dll")]
		public static extern Int32 CloseHandle(IntPtr hProcess);

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
		Process? pdProcess = null;

		// Important pointers
		IntPtr creditsPtr = new IntPtr(0x3ED640);
		IntPtr partnerLockPtr = new IntPtr(0x3ED688);
		IntPtr arsenalPtr = new IntPtr(0x3ED6B8);

		public Process? LinkPD()
		{
			pdProcess = Process.GetProcessesByName("PDUWP").FirstOrDefault();
			return pdProcess;
		}

		public bool GiveMaxSkills()
		{
			if (LinkPD() == null) return false;

			// TODO: IMPLEMENT
			return true;
		}

		public bool GiveMaxCredits()
		{
			if (LinkPD() == null) return false;

			// TODO: IMPLEMENT
			return true;
		}
	}
}
