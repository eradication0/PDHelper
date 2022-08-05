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
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

/* ERROR CODES
 * ERROR01: You didn't select a skill in your Arsenal.
 * ERROR02: You didn't select a skill in the Arsenal Editor.
 * ERROR03: You didn't select a skill in your Arsenal and in the Arsenal Editor.
 * ERROR04: You didn't select an Arsenal in the Arsenal List.
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 */

namespace PD_Helper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Class for PDCard
        // Root myDeserializedClass = JsonConvert.DeserializeObject<List<PDCard>>(myJsonResponse);
        public class PDCard
        {
            [JsonProperty("HEX")]
            public string HEX { get; set; }
            [JsonProperty("NAME")]
            public string NAME { get; set; }
            [JsonProperty("ID")]
            public int? ID { get; set; }
            [JsonProperty("SCHOOL")]
            public string SCHOOL { get; set; }
            [JsonProperty("DAMAGE")]
            public string DAMAGE { get; set; }
            [JsonProperty("COST")]
            public string COST { get; set; }
            [JsonProperty("USAGE")]
            public string USAGE { get; set; }
            [JsonProperty("RANGE")]
            public string RANGE { get; set; }
            [JsonProperty("DESCRIPTION")]
            public string DESCRIPTION { get; set; }
        }

        // Load card definitions
        //PDCard cardDef = JsonConvert.DeserializeObject<PDCard>(File.ReadAllText("SkillDB.json"));
        Dictionary<string, PDCard> cardDef = JsonConvert.DeserializeObject<Dictionary<string, PDCard>>(File.ReadAllText("SkillDB.json"));
        string[] loadedDeck = {"FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF" };
        string loadedDeckName = "";


        bool ProcOpen = false;
        public Mem m = new Mem();
        public ListBox allSkills = new ListBox();


        private void ListProcesses()
        {
            Process[] processCollection = Process.GetProcesses();
            for (int i = 0; i < processCollection.Length; i++)
            {
                if (processCollection[i].ProcessName == "PDUWP")
                {
                    //Get Processes and check for Phantom Dust, attach and enable Arsenal Loading
                    label2.Text = "Found the process! ID: " + processCollection[i].Id.ToString();
                    ProcOpen = m.OpenProcess(processCollection[i].Id, out string error);
                    label2.ForeColor = Color.Green;
                    groupBox1.Enabled = true;
                    infoBox.Enabled = true;
                    loadDeckNameButton.Enabled = true;

                    //Read all names of Arsenals
                    string[] offsets = { "8", "6C", "D0", "134", "198", "1FC", "260", "2C4", "328", "38C", "3F0", "454", "4B8", "51C", "580", "5E4" };


                    for (int o = 0; o < offsets.Length; o++)
                    {
                        string setup = "base+003ED6B8," + offsets[o];
                        arsenalDropdown.Items.Add(m.ReadString(setup, "", 16, true));
                        
                    }
                    arsenalDropdown.SelectedIndex = 0;
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
            // List of offsets for each Card
            string[] offsets = { "644", "645", "646", "647", "648", "649", "64A", "64B", "64C", "64D", "64E", "64F", "650", "651", "652", "653", "654", "655", "656", "657", "658", "659", "65A", "65B", "65C", "65D", "65E", "65F", "660", "661", "662", "663", "664", "665", "666", "667", "668", "669", "66A", "66B", "66C", "66D", "66E", "66F", "670", "671", "672", "673", "674", "675", "676", "677", "678", "679", "67A", "67B", "67C", "67D", "67E", "67F", "680", "681", "682", "683", "684", "685", "686", "687", "688", "689", "68A", "68B", "68C", "68D", "68E", "68F", "690", "691", "692", "693", "694", "695", "696", "697", "698", "699", "69A", "69B", "69C", "69D", "69E", "69F", "6A0", "6A1", "6A2", "6A3", "6A4", "6A5", "6A6", "6A7", "6A8", "6A9", "6AA", "6AB", "6AC", "6AD", "6AE", "6AF", "6B0", "6B1", "6B2", "6B3", "6B4", "6B5", "6B6", "6B7", "6B8", "6B9", "6BA", "6BB", "6BC", "6BD", "6BE", "6BF", "6C0", "6C1", "6C2", "6C3", "6C4", "6C5", "6C6", "6C7", "6C8", "6C9", "6CA", "6CB", "6CC", "6CD", "6CE", "6CF", "6D0", "6D1", "6D2", "6D3", "6D4", "6D5", "6D6", "6D7", "6D8", "6D9", "6DA", "6DB", "6DC", "6DD", "6DE", "6DF", "6E0", "6E1", "6E2", "6E3", "6E4", "6E5", "6E6", "6E7", "6E8", "6E9", "6EA", "6EB", "6EC", "6ED", "6EE", "6EF", "6F0", "6F1", "6F2", "6F3", "6F4", "6F5", "6F6", "6F7", "6F8", "6F9", "6FA", "6FB", "6FC", "6FD", "6FE", "6FF", "700", "701", "702", "703", "704", "705", "706", "707", "708", "709", "70A", "70B", "70C", "70D", "70E", "70F", "710", "711", "712", "713", "714", "715", "716", "717", "718", "719", "71A", "71B", "71C", "71D", "71E", "71F", "720", "721", "722", "723", "724", "725", "726", "727", "728", "729", "72A", "72B", "72C", "72D", "72E", "72F", "730", "731", "732", "733", "734", "735", "736", "737", "738", "739", "73A", "73B", "73C", "73D", "73E", "73F", "740", "741", "742", "743", "744", "745", "746", "747", "748", "749", "74A", "74B", "74C", "74D", "74E", "74F", "750", "751", "752", "753", "754", "755", "756", "757", "758", "759", "75A", "75B", "75C", "75D", "75E", "75F", "760", "761", "762", "763", "764", "765", "766", "767", "768", "769", "76A", "76B", "76C", "76D", "76E", "76F", "770", "771", "772", "773", "774", "775", "776", "777", "778", "779", "77A", "77B", "77C", "77D", "77E", "77F", "780", "781", "782", "783", "784", "785", "786", "787", "788", "789", "78A", "78B", "78C", "78D", "78E", "78F", "790", "791", "792", "793", "794", "795", "796", "797", "798", "799", "79A", "79B", "79C", "79D", "79E", "79F", "7A0", "7A1", "7A2", "7A3", "7A4", "7A5", "7A6", "7A7", "7A8", "7A9", "7AA", "7AB", "7AC", "7AD", "7AE", "7AF", "7A0", "7A1", "7A2", "7A3", "7A4", "7A5", "7A6", "7A7", "7A8", "7A9", "7AA", "7AB", "7AC", "7AD", "7AE", "7AF", "7B0", "7B1", "7B2", "7B3", "7B4", "7B5", "7B6", "7B7", "7B8", "7B9", "7BA"};

            // Set owned amount of card to HEX63 -> 99
            for (int i = 0; i < offsets.Length; i++)
            {
                string setup = "base+003ED6B8," + offsets[i];
                m.WriteMemory(setup, "byte", "63");
            }
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Set 3rd byte of credits to 30 -> around 800 mil
            m.WriteMemory("base+003ED640,13B", "byte", "30");
            button4.Enabled = false;
        }

        private void loadArsenalNameButton_Click(object sender, EventArgs e)
        {
            // Load up Arsenal
            groupBox4.Enabled = true;
            groupBox6.Enabled = true;
            arsenalListBox.Enabled = true;

            // Read amount of school set
            string[] offsetsSchool = { "54", "B8", "11C", "180", "1E4", "248", "2AC", "310", "374", "3D8", "43C", "4A0", "504", "568", "5CC", "630" };
            schoolNumeric.Value = m.ReadByte("base+003ED6B8," + offsetsSchool[arsenalDropdown.SelectedIndex]);
            arsenalNameBox.Text = arsenalDropdown.SelectedItem.ToString();
            loadedDeckName = arsenalDropdown.SelectedItem.ToString();
            //System.Diagnostics.Debug.WriteLine(o1);

            // List of fist cards per deck
            string[] offsetsLoadCards = { "18", "7C", "E0", "144", "1A8", "20C", "270", "2D4", "338", "39C", "400", "464", "4C8", "52C", "590", "5F4" };
            // Load all cards
            Byte[] loadDeck = m.ReadBytes("base+003ED6B8," + offsetsLoadCards[arsenalDropdown.SelectedIndex], 60);
            string loadDeckHex = BitConverter.ToString(loadDeck);
            //add cards to list
            loadedDeck = new string[] { "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF" };
            deckListBox.Items.Clear();
            int o = 0;
            for (int i = 0; i < 30; i++)
            {
                Byte[] currentByte = { loadDeck[o], loadDeck[o + 1] };
                String currentHexString = BitConverter.ToString(currentByte).Replace('-', ' ');
                deckListBox.Items.Add(cardDef[currentHexString].NAME);
                loadedDeck[i] = currentHexString;
                o += 2;
            }
            //System.Diagnostics.Debug.WriteLine(loadedDeck);

            //load arsenal editor
            if (editorList.Items.Count == 0)
            {
                foreach (var item in cardDef)
                {
                    editorList.Items.Add(item.Value.NAME);
                    allSkills.Items.Add(item.Value.NAME);
                }
                
            }

            //add each arsenal file to the list
            savedArsenalListBox.Items.Clear();
            DirectoryInfo directory = new DirectoryInfo(@"Arsenals\"); //Assuming Test is your Folder

            FileInfo[] Files = directory.GetFiles("*.arsenal"); //Getting Text files
            string str = "";
             
            foreach (FileInfo file in Files)
            {
                string currentDeck = file.Name;
                currentDeck = currentDeck.Remove(currentDeck.Length - 8);
                savedArsenalListBox.Items.Add(currentDeck);
            }
        }

        private void btnSaveToPDH_Click(object sender, EventArgs e)
        {
            string path = @"Arsenals\" + loadedDeckName + ".arsenal";
            string str = "";
            for (int i = 0; i < 30; i++)
            {
                str += loadedDeck[i] + ",";
            }
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(str);
                for (int i = 0; i < 30; i++)
                {
                    System.Diagnostics.Debug.WriteLine(loadedDeck[i]);
                }
                
                sw.Close();
            }
            // only add new name to list if its a unique new deck, update the old one otherwise
            if (!savedArsenalListBox.Items.Contains(loadedDeckName) == true) {
                savedArsenalListBox.Items.Add(loadedDeckName);
            }

            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (editorList.SelectedIndex != -1 && deckListBox.SelectedIndex != -1)
            {

                //set loaded deck card change
                string currentHex = cardDef[cardDef.ElementAt(editorList.SelectedIndex).Key].HEX;
                loadedDeck[deckListBox.SelectedIndex] = currentHex;
                //set loaded deck visual
                deckListBox.Items[deckListBox.SelectedIndex] = editorList.SelectedItem.ToString();
            }
            //error handling
            else if (editorList.SelectedIndex != -1){MessageBox.Show("ERROR01: You didn't select a skill in your Arsenal.");}
            else if (deckListBox.SelectedIndex != -1){MessageBox.Show("ERROR02: You didn't select a skill in the Arsenal Editor.");}
            else{MessageBox.Show("ERROR03: You didn't select a skill in your Arsenal and in the Arsenal Editor.");}
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (deckListBox.SelectedIndex != -1)
            {

                //set loaded deck card change
                string currentHex = "FF FF";
                loadedDeck[deckListBox.SelectedIndex] = currentHex;
                //set loaded deck visual
                deckListBox.Items[deckListBox.SelectedIndex] = "Aura Particle";
            }
            //error handling
            else { MessageBox.Show("You didn't select a skill in your Arsenal."); }
        }

        private void arsenalNameBox_TextChanged(object sender, EventArgs e)
        {
            loadedDeckName = arsenalNameBox.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //search for value in editorList
            if (textBox1.Text != "")
            {
                editorList.Items.Clear();
                foreach (var item in allSkills.Items)
                {
                    if (item.ToString().Contains(textBox1.Text,StringComparison.OrdinalIgnoreCase))
                    {
                        editorList.Items.Add(item.ToString());
                    }
                }
            } else
            {
                editorList.Items.Clear();
                foreach (var item in allSkills.Items)
                {
                    editorList.Items.Add(item);
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (savedArsenalListBox.SelectedIndex != -1)
            {
                string path = @"Arsenals\" + savedArsenalListBox.SelectedItem.ToString() + ".arsenal";
                string file = File.ReadAllText(path);
                string[] deckStrings = file.Split(',');
                deckListBox.Items.Clear();
                for (int i = 0; i < 30; i++)
                {
                    loadedDeck[i] = deckStrings[i];
                    deckListBox.Items.Add(cardDef[deckStrings[i]].NAME);
                }
            }
            else { MessageBox.Show("ERROR04: You didn't select an Arsenal in the Arsenal List."); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to delete Arsenal: " + savedArsenalListBox.SelectedItem.ToString() + "?", "Arsenal Deletion Check", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                string path = @"Arsenals\" + savedArsenalListBox.SelectedItem.ToString() + ".arsenal";
                File.Delete(path);
                savedArsenalListBox.Items.Remove(savedArsenalListBox.SelectedItem);
            } 
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void deckListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        
        }



        private void listBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void saveToPDbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}