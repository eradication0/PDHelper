using Memory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PD_Helper
{
    public partial class GiveSkillCredits : Form
    {
        public Mem m = new Mem();
        public GiveSkillCredits()
        {
            InitializeComponent();

            //get process of game
            Process[] processCollection = Process.GetProcesses();
            for (int i = 0; i < processCollection.Length; i++)
            {
                if (processCollection[i].ProcessName == "PDUWP")
                {
                    //Get Processes and check for Phantom Dust, attach and enable Arsenal Loading
                    m.OpenProcess(processCollection[i].Id, out string error);
                }
            }
        }

        private void maxSkillsButton_Click(object sender, EventArgs e)
        {
            // List of offsets for each Card
            int offsetStart = 1604; //offset of the first byte that defines amount owned
            int offsetAmout = 848; //amount of bytes in a row that need to be changed

            for (int o = 0; o < offsetAmout; o++)
            {
                //get current offset by calculating it as decimal, then turning it into a hex string
                string currentOffset = (offsetStart + o).ToString("X");

                string setup = "base+003ED6B8," + currentOffset;
                m.WriteMemory(setup, "byte", "63"); //set to "63" in hex aka 99
                Console.WriteLine(currentOffset);
            }
            maxSkillsButton.Enabled = false;
        }

        private void maxCreditsButton_Click(object sender, EventArgs e)
        {
            //Set 3rd byte of credits to 30 -> around 800 mil
            m.WriteMemory("base+003ED640,13B", "byte", "30");
            maxCreditsButton.Enabled = false;
        }
    }
}
