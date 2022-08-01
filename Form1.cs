using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Memory;

namespace PD_Helper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool ProcOpen = false;
        public Mem m = new Mem();

        private void ListProcesses()
        {
            Process[] processCollection = Process.GetProcesses();
            for (int i = 0; i < processCollection.Length; i++)
            {
                if (processCollection[i].ProcessName == "PDUWP")
                {
                    label2.Text = "Found the process! ID: " + processCollection[i].Id.ToString();
                    ProcOpen = m.OpenProcess(processCollection[i].Id, out string error);
                    label2.ForeColor = Color.Green;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    break;
                } else if (i == processCollection.Length - 1)
                {
                    label2.ForeColor = Color.Red;
                    label2.Text = "Could not find process. Try again and make sure the game is started.";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListProcesses();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] offsets = { "644", "645", "646", "647", "648", "649", "64A", "64B", "64C", "64D", "64E", "64F", "650", "651", "652", "653", "654", "655", "656", "657", "658", "659", "65A", "65B", "65C", "65D", "65E", "65F", "660", "661", "662", "663", "664", "665", "666", "667", "668", "669", "66A", "66B", "66C", "66D", "66E", "66F", "670", "671", "672", "673", "674", "675", "676", "677", "678", "679", "67A", "67B", "67C", "67D", "67E", "67F", "680", "681", "682", "683", "684", "685", "686", "687", "688", "689", "68A", "68B", "68C", "68D", "68E", "68F", "690", "691", "692", "693", "694", "695", "696", "697", "698", "699", "69A", "69B", "69C", "69D", "69E", "69F", "6A0", "6A1", "6A2", "6A3", "6A4", "6A5", "6A6", "6A7", "6A8", "6A9", "6AA", "6AB", "6AC", "6AD", "6AE", "6AF", "6B0", "6B1", "6B2", "6B3", "6B4", "6B5", "6B6", "6B7", "6B8", "6B9", "6BA", "6BB", "6BC", "6BD", "6BE", "6BF", "6C0", "6C1", "6C2", "6C3", "6C4", "6C5", "6C6", "6C7", "6C8", "6C9", "6CA", "6CB", "6CC", "6CD", "6CE", "6CF", "6D0", "6D1", "6D2", "6D3", "6D4", "6D5", "6D6", "6D7", "6D8", "6D9", "6DA", "6DB", "6DC", "6DD", "6DE", "6DF", "6E0", "6E1", "6E2", "6E3", "6E4", "6E5", "6E6", "6E7", "6E8", "6E9", "6EA", "6EB", "6EC", "6ED", "6EE", "6EF", "6F0", "6F1", "6F2", "6F3", "6F4", "6F5", "6F6", "6F7", "6F8", "6F9", "6FA", "6FB", "6FC", "6FD", "6FE", "6FF", "700", "701", "702", "703", "704", "705", "706", "707", "708", "709", "70A", "70B", "70C", "70D", "70E", "70F", "710", "711", "712", "713", "714", "715", "716", "717", "718", "719", "71A", "71B", "71C", "71D", "71E", "71F", "720", "721", "722", "723", "724", "725", "726", "727", "728", "729", "72A", "72B", "72C", "72D", "72E", "72F", "730", "731", "732", "733", "734", "735", "736", "737", "738", "739", "73A", "73B", "73C", "73D", "73E", "73F", "740", "741", "742", "743", "744", "745", "746", "747", "748", "749", "74A", "74B", "74C", "74D", "74E", "74F", "750", "751", "752", "753", "754", "755", "756", "757", "758", "759", "75A", "75B", "75C", "75D", "75E", "75F", "760", "761", "762", "763", "764", "765", "766", "767", "768", "769", "76A", "76B", "76C", "76D", "76E", "76F", "770", "771", "772", "773", "774", "775", "776", "777", "778", "779", "77A", "77B", "77C", "77D", "77E", "77F", "780", "781", "782", "783", "784", "785", "786", "787", "788", "789", "78A", "78B", "78C", "78D", "78E", "78F", "790", "791", "792", "793", "794", "795", "796", "797", "798", "799", "79A", "79B", "79C", "79D", "79E", "79F", "7A0", "7A1", "7A2", "7A3", "7A4", "7A5", "7A6", "7A7", "7A8", "7A9", "7AA", "7AB", "7AC", "7AD", "7AE", "7AF", "7A0", "7A1", "7A2", "7A3", "7A4", "7A5", "7A6", "7A7", "7A8", "7A9", "7AA", "7AB", "7AC", "7AD", "7AE", "7AF", "7B0", "7B1", "7B2", "7B3", "7B4", "7B5", "7B6", "7B7", "7B8", "7B9", "7BA"};

            for (int i = 0; i < offsets.Length; i++)
            {
                string setup = "base+003ED6B8," + offsets[i];
                m.WriteMemory(setup, "byte", "63");
            }
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            m.WriteMemory("base+003ED640,13B", "byte", "30");
            button4.Enabled = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
