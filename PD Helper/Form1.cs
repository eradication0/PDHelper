using System;
using System.Collections;
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
//using Memory;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
//xbox input
using SharpDX.XInput;
/* ERROR CODES
* ERROR01: You didn't select a skill in your Arsenal.
* ERROR02: You didn't select a skill in the Arsenal Editor.
* ERROR03: You didn't select a skill in your Arsenal and in the Arsenal Editor.
* ERROR04: You didn't select an Arsenal in the Arsenal List.
* ERROR05: This Arsenal has skills from too many schools. You are limited to: X schools
* ERROR06: The loaded Arsenal loaded is not set to 1,2 or 3 Schools.
* ERROR07: The Profile has no Arsenals, please create at least one in-game Arsenal to be able to load/write/edit them.
* ERROR08: The arsenal name contains banned characters (\ / : * ? "" < > |)
* ERROR09: A Skill from your loaded arsenal does not exist in the game and could not be loaded. The arsenal has been tampered with or was corrupted. Please try loading another arsenal.
* ERROR10: The arsenal does not contain a valid amount of cards. The arsenal has been tampered with or is corrupted. Please try loading another arsenal.
* 
* 
* 
*/

namespace PD_Helper
{
    //timer value 7FF7D096C8C0
    public partial class Form1 : Form
    {
        private Controller _controller;

        // Load card definitions
        //Dictionary<string, PDCard> cardDef = JsonConvert.DeserializeObject<Dictionary<string, PDCard>>(File.ReadAllText("SkillDB.json"));
        Dictionary<string, PDCard> cardDef = JsonConvert.DeserializeObject<Dictionary<string, PDCard>>(File.ReadAllText("SkillDB.json"));
        string[] loadedDeck = { "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "00 00" };
        string loadedDeckName = "";

        bool ProcOpen = false;
        bool gamepadOn = false;
        public PDMemory memory = new PDMemory();
        public ListBox allSkills = new ListBox();

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;

            // Set default checkmarks
            for (int i = 0; i < 5; i++)
            {
                schoolFilterCheckedListBox.SetItemChecked(i, true);
            }
            for (int i = 0; i < rangeFilterCheckedListBox.Items.Count; i++)
            {
                rangeFilterCheckedListBox.SetItemChecked(i, true);
            }
            for (int i = 0; i < 4; i++)
            {
                miscNumberCheckedListBox.SetItemChecked(i, true);
            }

            // Set default sort
            sortComboBox1.Text = "ID";
            sortComboBox2.Text = "None";
            sortComboBox3.Text = "None";

            // Load a blank 30 aura arsenal
            List<PDCard> emptyArsenal = new List<PDCard>();
			for (int i = 0; i < 30; i++)
			{
                emptyArsenal.Add(getCard("Aura Particle"));
			}
            openArsenalToList(emptyArsenal);
            refreshView();
        }

        private void loadArsenalList()
        {
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
            arsenalListGroupBox.Text = "Arsenal List (" + savedArsenalListBox.Items.Count + ")";
        }

        private void loadGameData(object sender, EventArgs e)
        {
            Process[] processCollection = Process.GetProcesses();
            arsenalDropdown.Items.Clear();

            //start input worker (if it hasn't yet)
            if (!gamepadOn)
            {
                _controller = new Controller(UserIndex.One);
                GamepadWorker.RunWorkerAsync();
                gamepadOn = true;
            }

            // Link to Phantom Dust
            if (memory.LinkPD() != null)
            {
                //Get Processes and check for Phantom Dust, attach and enable Arsenal Loading
                label2.Text = "Found the process! ID: " + memory.pdProcess.Id.ToString();
                label2.ForeColor = Color.Green;
                groupBox1.Enabled = true;

                //Read all names of Arsenals
                string[] arsenalNames = memory.GetArsenalNames();
				if (arsenalNames != null)
				{
					foreach (string arsenalName in arsenalNames)
					{
						if (arsenalName.Length > 0)
						{
                            arsenalDropdown.Items.Add(arsenalName);
						}
					}
				}

                if (arsenalDropdown.Items.Count > 0)
                {
                    arsenalDropdown.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("ERROR07: The Profile has no Arsenals, please create at least one in-game Arsenal to be able to load/write/edit them.");
                }

                
            }
            else
            {
                label2.ForeColor = Color.Red;
                label2.Text = "No Game Found. Start Phantom Dust First!";
            }
        }

        private void giveMaxSkills(object sender, EventArgs e)
        {
            maxSkillsButton.Enabled = memory.GiveMaxSkills(); ;
        }

        private void giveMaxCredits(object sender, EventArgs e)
        {
			maxCreditsButton.Enabled = !memory.GiveMaxCredits();
        }

        private void btnSaveToPDH_Click(object sender, EventArgs e)
        {
			// Only save if the name is given
			if (loadedDeckName == "")
			{
                MessageBox.Show("Please enter a name for the arsenal to save.");
                return;
			}
            
            string path = @"Arsenals\" + loadedDeckName + ".arsenal";
            string str = "";
            for (int i = 0; i < 31; i++)
            {
                str += loadedDeck[i] + ",";
            }
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(str);
                sw.Close();
            }
            // only add new name to list if its a unique new deck, update the old one otherwise
            if (!savedArsenalListBox.Items.Contains(loadedDeckName) == true) {
                savedArsenalListBox.Items.Add(loadedDeckName);
            }

            // Re-sort the arsenal
            List<PDCard> cardList = new List<PDCard>();
            for (int i = 0; i < 30; i++)
            {
                cardList.Add(cardDef[loadedDeck[i]]);
            }
            openArsenalToList(cardList, arsenalNameBox.Text, (int)schoolNumeric.Value);
        }

        public PDCard getCard(string name)
        {
            foreach (PDCard pair in cardDef.Values)
            {
                if (pair.NAME == name)
                {
                    return pair;
                }
            }

            return null;
        }

        private void replaceSkill(object sender, EventArgs e)
        {
            if (editorList.SelectedIndex != -1 && deckListBox.SelectedIndex != -1)
            {
                //set loaded deck card change
                PDCard card = getCard(editorList.SelectedItem.ToString());

                string currentHex = card.HEX;
                loadedDeck[deckListBox.SelectedIndex] = currentHex;
                Debug.WriteLine(card.HEX);

                //set loaded deck visual
                deckListBox.Items[deckListBox.SelectedIndex] = editorList.SelectedItem.ToString();

                // Recount skills
                int auraCount = 0;
                foreach (var item in deckListBox.Items)
                {
                    if (item.ToString() == "Aura Particle") auraCount++;
                }
                skillCountLabel.Text = Convert.ToString(30 - auraCount) + "/30";
            }
            //error handling
            else if (editorList.SelectedIndex != -1) { MessageBox.Show("ERROR01: You didn't select a skill in your Arsenal."); }
            else if (deckListBox.SelectedIndex != -1) { MessageBox.Show("ERROR02: You didn't select a skill in the Arsenal Editor."); }
            else { MessageBox.Show("ERROR03: You didn't select a skill in your Arsenal and in the Arsenal Editor."); }
        }

        private void resetSkill(object sender, EventArgs e)
        {
            if (deckListBox.SelectedIndex != -1)
            {
                //set loaded deck card change
                string currentHex = "FF FF";
                loadedDeck[deckListBox.SelectedIndex] = currentHex;
                //set loaded deck visual
                deckListBox.Items[deckListBox.SelectedIndex] = "Aura Particle";

                // Recount skills
                int auraCount = 0;
                foreach (var item in deckListBox.Items)
                {
                    if (item.ToString() == "Aura Particle") auraCount++;
                }
                skillCountLabel.Text = Convert.ToString(30 - auraCount) + "/30";
            }
            //error handling
            else { MessageBox.Show("You didn't select a skill in your Arsenal."); }
        }

        private void arsenalNameBox_TextChanged(object sender, EventArgs e)
        {
            var textToWrite = arsenalNameBox.Text;
            var regex = new Regex(@"[\\\/\:\*\?\""\<\>\|]");
            if (!regex.IsMatch(textToWrite))
            {
                loadedDeckName = arsenalNameBox.Text;
            } else
            {
                arsenalNameBox.Text = arsenalNameBox.Text.Remove(arsenalNameBox.Text.Length - 1, 1);
                arsenalNameBox.SelectionStart = arsenalNameBox.TextLength;
            }
        }

        private void updateEditorList(object sender, EventArgs e)
        {
            // Use the current array of checkmarks
            bool[] schoolFilter = new bool[5];
            for (int i = 0; i < 5; i++)
            {
                schoolFilter[i] = schoolFilterCheckedListBox.GetItemChecked(i);
            }
            bool[] rangeFilter = new bool[rangeFilterCheckedListBox.Items.Count];
            for (int i = 0; i < rangeFilterCheckedListBox.Items.Count; i++)
            {
                rangeFilter[i] = rangeFilterCheckedListBox.GetItemChecked(i);
            }
            bool[] miscNumberFilter = new bool[4];
            for (int i = 0; i < 4; i++)
            {
                miscNumberFilter[i] = miscNumberCheckedListBox.GetItemChecked(i);
            }

            updateEditorList(schoolFilter, rangeFilter, miscNumberFilter);
        }

        private IComparer<PDCard>? determineSort(string sort)
        {
            /*
             * School
             * Cost
             * Strength
             * Number of Uses
             * Range
             * ID
             * None
			 */

            switch (sort)
			{
                case "School":
                    return PDCard.SortSchool();
                case "Cost":
                    return PDCard.SortCost();
                case "Strength":
                    return PDCard.SortStr();
                case "Number of Uses":
                    return PDCard.SortUses();
                case "Range":
                    return PDCard.SortRange();
                case "ID":
                    return PDCard.SortID();
                default:
					return null;
			}
		}

        private void updateEditorList(bool[] schoolFilter, bool[] rangeFilter, bool[] miscNumberFilter)
        {
            // Step 0: Make a list of skills that contain all the ones to display
            List<PDCard> displayCards = new List<PDCard>();
            string infty = getCard("Bomb").USAGE;
            foreach (var item in allSkills.Items)
            {
                // Step 1: Only consider the skills matching the school filter
                string school = schoolFromName(item.ToString());
                bool toKeep = true;
                switch (school)
                {
                    case "Psycho":
                        toKeep = schoolFilter[0];
                        break;
                    case "Optical":
                        toKeep = schoolFilter[1];
                        break;
                    case "Nature":
                        toKeep = schoolFilter[2];
                        break;
                    case "Ki":
                        toKeep = schoolFilter[3];
                        break;
                    case "Faith":
                        toKeep = schoolFilter[4];
                        break;
                    default:
                        break;
                }
                if (!toKeep) continue;

                // Step 2: Only consider the skills matching the range filter
                string range = getCard(item.ToString()).RANGE;
                toKeep = true;
                switch (range)
                {
                    case "short":
                        toKeep = rangeFilter[0];
                        break;
                    case "medium":
                        toKeep = rangeFilter[1];
                        break;
                    case "long":
                        toKeep = rangeFilter[2];
                        break;
                    case "mine":
                        toKeep = rangeFilter[3];
                        break;
                    case "capsule":
                        toKeep = rangeFilter[4];
                        break;
                    case "-":
                        toKeep = rangeFilter[5];
                        break;
                    case "self":
                        toKeep = rangeFilter[6];
                        break;
                    case "all":
                        toKeep = rangeFilter[7];
                        break;
                    case "auto":
                        toKeep = rangeFilter[8];
                        break;
                    case "env":
                        toKeep = rangeFilter[9];
                        break;
                    default:
                        break;
                }
                if (!toKeep) continue;

                // Step 3: Now filter by type if necessary
                PDCard card = getCard(item.ToString());
                if (!allSkillsRadioButton.Checked)
                {
                    // Get type
                    if (card == null)
                    {
                        throw new FormatException("Skill not found");
                    }
                    string type = card.TYPE;

                    // Match with the type marked
                    toKeep = false;
                    switch (type)
                    {
                        case "Attack":
                            toKeep = attackRadioButton.Checked;
                            break;
                        case "Defense":
                            toKeep = defenseRadioButton.Checked;
                            break;
                        case "Erase":
                            toKeep = eraseRadioButton.Checked;
                            break;
                        case "Status":
                            toKeep = statusRadioButton.Checked;
                            break;
                        case "Special":
                            toKeep = specialRadioButton.Checked;
                            break;
                        case "Environment":
                            toKeep = environmentalRadioButton.Checked;
                            break;
                    }
                    if (!toKeep) continue;
                }

                // Step 4: Filter by the STR/DEF/USE/COST given
                bool validSTR = (int.TryParse(card.DAMAGE, out int damage)
                        && damage >= (int)strMinNumeric.Value
                        && damage <= (int)strMaxNumeric.Value)
                    || card.TYPE != "Attack" || (miscNumberFilter[0] && card.DAMAGE == "X");
                bool validDEF = (int.TryParse(card.DAMAGE, out int defense)
                        && defense >= (int)defMinNumeric.Value
                        && defense <= (int)defMaxNumeric.Value)
                    || card.TYPE != "Defense" || (miscNumberFilter[1] && card.DAMAGE == "-");
                bool validUSE = (int.TryParse(card.USAGE, out int usage)
                        && usage >= (int)useMinNumeric.Value
                        && usage <= (int)useMaxNumeric.Value)
                    || (miscNumberFilter[2] && card.USAGE == infty);
                bool validCOST = (int.TryParse(card.COST, out int cost)
                        && cost >= (int)costMinNumeric.Value
                        && (cost <= (int)costMaxNumeric.Value
                            || costMaxNumeric.Value == costMaxNumeric.Maximum)) // Handle Phantom Dust Skill
                    || (miscNumberFilter[3] && card.COST == "X");
                toKeep = validSTR && validDEF && validUSE && validCOST;

                if (!toKeep) continue;

                // Step 5: search for value in editorList
                if (editorSearchTextBox.Text == "" || item.ToString().Contains(editorSearchTextBox.Text, StringComparison.OrdinalIgnoreCase))
                {
                    displayCards.Add(getCard(item.ToString()));
                    //editorList.Items.Add(item.ToString());
                }
            }

            // Step 6: Determine the sorting method
            List<IComparer<PDCard>> comparers = new List<IComparer<PDCard>>();
            IComparer<PDCard> comparer1 = determineSort(sortComboBox1.Text);
            if (comparer1 != null) comparers.Add(comparer1);
            else comparers.Add(PDCard.SortID()); // Default sort
            IComparer<PDCard> comparer2 = determineSort(sortComboBox2.Text);
            if (comparer2 != null) comparers.Add(comparer2);
            IComparer<PDCard> comparer3 = determineSort(sortComboBox3.Text);
            if (comparer3 != null) comparers.Add(comparer3);

            // Step 7: Sort the list and display it
            displayCards.Sort(PDCard.SortMulti(comparers.ToArray()));
            editorList.Items.Clear();
            foreach (var item in displayCards)
			{
                editorList.Items.Add(item.NAME);
            }
        }

        private void loadArsenal(object sender, EventArgs e)
        {
            if (savedArsenalListBox.SelectedIndex != -1)
            {
                var regex = new Regex(@"[\\\/\:\*\?\""\<\>\|]");
                if (regex.IsMatch(savedArsenalListBox.SelectedItem.ToString()))
                {
                    MessageBox.Show(@"ERROR08: The arsenal name contains banned characters (\ / : * ? \ < > |)");
                }
                else
                {
                    string path = @"Arsenals\" + savedArsenalListBox.SelectedItem.ToString() + ".arsenal";
                    string file = File.ReadAllText(path);
                    string[] deckStrings = file.Split(',');
                    if (deckStrings.Length < 30)
                    {
                        MessageBox.Show(@"ERROR10: The arsenal does not contain a valid amount of cards. The arsenal has been tampered with or is corrupted. Please try loading another arsenal.");
                    } else
                    {
                        //manual write schools

                        string loadSchoolAmount = deckStrings[30].Remove(deckStrings[30].Length - 3);
                        if (loadSchoolAmount == "01" || loadSchoolAmount == "02" || loadSchoolAmount == "03")
                        {
                            schoolNumeric.Value = Int32.Parse(loadSchoolAmount);
                            loadedDeck[30] = deckStrings[30];
                            deckListBox.Items.Clear();
                            for (int i = 0; i < 30; i++)
                            {
                                if (!cardDef.ContainsKey(deckStrings[i]))
                                {
                                    MessageBox.Show("ERROR09: A Skill from your loaded arsenal does not exist in the game and could not be loaded. The arsenal has been tampered with or was corrupted. Please try loading another arsenal.");
                                    break;
                                }
                                else
                                {
                                    loadedDeck[i] = deckStrings[i];
                                    deckListBox.Items.Add(cardDef[deckStrings[i]].NAME);
                                }

                            }


                            //write name
                            arsenalNameBox.Text = savedArsenalListBox.SelectedItem.ToString();
                        }
                        else
                        {
                            MessageBox.Show("ERROR06: The loaded Arsenal loaded is not set to 1,2 or 3 Schools.");
                        }
                    }

                }


            }
            else { MessageBox.Show("ERROR04: You didn't select an Arsenal in the Arsenal List."); }
        }

        private void deleteArsenal(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to delete Arsenal: " + savedArsenalListBox.SelectedItem.ToString() + "?", "Arsenal Deletion Check", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                string path = @"Arsenals\" + savedArsenalListBox.SelectedItem.ToString() + ".arsenal";
                File.Delete(path);
                savedArsenalListBox.Items.Remove(savedArsenalListBox.SelectedItem);
            }
        }

        private void partnerLock_CheckedChanged(object sender, EventArgs e)
        {
            memory.SetPartnerLockOn(partnerLock.Checked);
        }

        private Color lightColorFromType(string type) => ColorProfileForm.getColor(type, true);

        private Color lightColorFromName(string name) => lightColorFromType(getCard(name).TYPE);

        private Color darkColorFromType(string type) => ColorProfileForm.getColor(type, false);

        private Color darkColorFromName(string name) => darkColorFromType(getCard(name).TYPE);

        private void displayEditorSkill(string name)
        {
            PDCard card = getCard(name);

            labelSkillCost.Text = card.COST;
            labelSkillDescription.Text = card.DESCRIPTION;
            labelSkillID.Text = card.ID.ToString();
            labelSkillName.Text = card.NAME;
            labelSkilLRange.Text = card.RANGE;
            labelSkillSchool.Text = card.SCHOOL;
            labelSkillStrength.Text = card.DAMAGE;
            labelSkillUse.Text = card.USAGE;

            Color textColor = lightColorFromType(card.TYPE);
            labelSkillID.ForeColor = textColor;
            labelSkillName.ForeColor = textColor;
            labelSkillSchool.ForeColor = textColor;
        }

        private void editorList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (editorList.SelectedIndex != -1)
            {
                displayEditorSkill(editorList.SelectedItem.ToString());
            }
        }

        private bool validateArsenal()
        {
            //school limit checking
            int psy = 0;
            int opt = 0;
            int nat = 0;
            int ki = 0;
            int fai = 0;
            int schoolAmount = 0;
            PDCard currentCard = new PDCard();
            foreach (var cardName in deckListBox.Items)
            {
                currentCard = getCard(cardName.ToString());
                switch (currentCard.SCHOOL)
                {
                    case "Psycho":
                        psy++;
                        break;
                    case "Optical":
                        opt++;
                        break;
                    case "Nature":
                        nat++;
                        break;
                    case "Ki":
                        ki++;
                        break;
                    case "Faith":
                        fai++;
                        break;
                    case "Aura":
                        break;

                }
            }
            int maxAllowedSchools = Convert.ToInt32(loadedDeck[30].Remove(2));
            if (psy > 0) { schoolAmount++; }
            if (opt > 0) { schoolAmount++; }
            if (nat > 0) { schoolAmount++; }
            if (ki > 0) { schoolAmount++; }
            if (fai > 0) { schoolAmount++; }

            //dupe limit checking
            bool isOverDupeLimit = false;
            Dictionary<string, int> skillDupes = new Dictionary<string, int>();
            for (int i = 0; i < 30; i++)
            {
                if (skillDupes.ContainsKey(deckListBox.Items[i].ToString()))
                {
                    skillDupes[deckListBox.Items[i].ToString()]++;
                }
                else
                {
                    skillDupes.Add(deckListBox.Items[i].ToString(), 1);
                }
            }
            foreach (var item in skillDupes)
            {
                if (item.Value > 3 && item.Key != "Aura Particle")
                {
                    isOverDupeLimit = true;
                }
            }


            if (schoolAmount > maxAllowedSchools)
            {
                MessageBox.Show("ERROR05: This Arsenal has skills from too many schools. You are limited to: " + maxAllowedSchools.ToString() + " School(s)");
                return false;
            }
            else if (isOverDupeLimit)
            {
                MessageBox.Show("ERROR06: You cannot have more than 3 of the same skill in an Arsenal");
                return false;
            }
            else return true;
        }

        private void saveToPDbtn_Click(object sender, EventArgs e)
        {
			try
			{
                if (validateArsenal())
                {
                    //writing the name
                    byte[] deckNameToWrite = Encoding.ASCII.GetBytes(arsenalNameBox.Text);
                    Array.Resize(ref deckNameToWrite, 15);
                    memory.SetArsenalName(arsenalDropdown.SelectedIndex, deckNameToWrite);

                    // writing the cards + school
                    string[] offsetsLoadCards = { "18", "7C", "E0", "144", "1A8", "20C", "270", "2D4", "338", "39C", "400", "464", "4C8", "52C", "590", "5F4" };
                    byte[] dataToWrite = { };
                    Array.Resize(ref dataToWrite, 62);
                    int o = 0;
                    for (int i = 0; i < loadedDeck.Length; i++)
                    {
                        dataToWrite[o] = Convert.ToByte(loadedDeck[i].Remove(2), 16);
                        dataToWrite[o + 1] = Convert.ToByte(loadedDeck[i].Remove(0, 3), 16);
                        System.Diagnostics.Debug.WriteLine(loadedDeck[i].Remove(2), 16);
                        System.Diagnostics.Debug.WriteLine(loadedDeck[i].Remove(0, 3), 16);
                        o += 2;
                    }

                    memory.SetArsenalCardsBytes(arsenalDropdown.SelectedIndex, dataToWrite);
                    arsenalDropdown.Items[arsenalDropdown.SelectedIndex] = arsenalNameBox.Text.ToString();
                }
            }
			catch (Exception)
			{
                MessageBox.Show("Unable to save to Phantom Dust. Make sure the game is open and the app is connected by pressing 'Load Profile'.");
			}
        }

        private void schoolNumeric_ValueChanged(object sender, EventArgs e)
        {
            loadedDeck[30] = "0" + schoolNumeric.Value.ToString() + " 00";
        }
        private void openArsenalFolder(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", @"Arsenals\");
        }

        private void openArsenalToList(List<PDCard> cardList, string arsenalName = "", int schoolAmount = 2)
        {
            // Sort the list
            cardList.Sort(PDCard.SortType());

            // Enter card to the list box. Also count aura
            int auraCount = 0;
            deckListBox.Items.Clear();
            for (int i = 0; i < 30; i++)
            {
                loadedDeck[i] = cardList[i].HEX;
                deckListBox.Items.Add(cardList[i].NAME);
                if (cardList[i].TYPE == "Aura") auraCount++;
            }

            // Set the skill count, school amount, and arsenal name
            skillCountLabel.Text = Convert.ToString(30 - auraCount) + "/30";
            schoolNumeric.Value = schoolAmount;
            arsenalNameBox.Text = arsenalName;
            loadedDeckName = arsenalName;

            loadArsenalList();
        }

        private void arsenalDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (memory.GetPartnerLockOn())
            {
                partnerLock.Checked = true;
            }

            //System.Diagnostics.Debug.WriteLine(o1);
            
            // Load all cards
            Byte[] loadDeck = memory.GetArsenalCardsBytes(arsenalDropdown.SelectedIndex);
            
            //add cards to list
            loadedDeck = new string[] { "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "FF FF", "00 00" };
            List<PDCard> cardList = new List<PDCard>();
            int o = 0;
            for (int i = 0; i < 30; i++)
            {
                Byte[] currentByte = { loadDeck[o], loadDeck[o + 1] };
                String currentHexString = BitConverter.ToString(currentByte).Replace('-', ' ');
                cardList.Add(cardDef[currentHexString]);
                o += 2;
            }

            //manual write school amount
            Byte[] currentByteFix = { loadDeck[60], loadDeck[61] };
            String currentHexStringFix = BitConverter.ToString(currentByteFix).Replace('-', ' ');
            loadedDeck[30] = currentHexStringFix;
            string loadSchoolAmount = currentHexStringFix.Remove(currentHexStringFix.Length - 3);
            openArsenalToList(cardList, arsenalDropdown.SelectedItem.ToString(), Int32.Parse(loadSchoolAmount)); 
        }

        private void deckListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Make the editor select the new skill
            if (deckListBox.SelectedIndex != -1)
            {
                displayEditorSkill(deckListBox.SelectedItem.ToString());
            }
        }

        private string schoolFromName(string name) => getCard(name).SCHOOL;

        private void skillList_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            // Get the list box
            ListBox listBox = (ListBox)sender;

            // Draw the background of the ListBox control for each item.
            e.DrawBackground();

            // Set back color
            string skillName = listBox.Items[e.Index].ToString();
            Color backColor;

            bool selected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
            if (selected)
			{
                backColor = lightColorFromName(skillName);
            }
			else
			{
                backColor = darkColorFromName(skillName);
            }

            e.Graphics.FillRectangle(new SolidBrush(backColor), e.Bounds);

            // Draw the current item text
            e.Graphics.DrawString(skillName, e.Font, new SolidBrush(Color.Black), e.Bounds, StringFormat.GenericDefault);

            // Get the school of the skill and its associate image path
            string school = schoolFromName(skillName);
            string path = @"School_Icons\" + school + ".png";
            Image schoolIcon = Image.FromFile(path);

            // Draw the school icon [HEIGHT IS 15]
            e.Graphics.DrawImageUnscaled(schoolIcon, 
                x: e.Bounds.Right - 28,
                y: e.Bounds.Top);

            // If the ListBox has focus, draw a focus rectangle around the selected item.
            e.DrawFocusRectangle();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        { 
            // this should be the keypress T to toggle partner lock but its not working while not focused
            //if (e.KeyData == Keys.T) { partnerLock.Invoke((MethodInvoker)(() => partnerLock.Checked = !partnerLock.Checked)); }
        }

        private void refreshArsenalList(object sender, EventArgs e)
        {
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
            arsenalListGroupBox.Text = "Arsenal List (" + savedArsenalListBox.Items.Count + ")";
        }

        private void GamepadWorker_DoWork_1(object sender, DoWorkEventArgs e)
        {
            // previous state tracking
            string previousState = "null";
            while (_controller.IsConnected)
            {
                //making sure previous state is not same to prevent flicker
                if (_controller.GetState().Gamepad.Buttons.ToString() == "RightThumb" & previousState != "RightThumb")
                {
                    partnerLock.Invoke((MethodInvoker)(() => partnerLock.Checked = !partnerLock.Checked));
                }
                previousState = _controller.GetState().Gamepad.Buttons.ToString();
                //System.Diagnostics.Debug.WriteLine(_controller.GetState().Gamepad);
            }
        }

		private void schoolFilterCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
		{
            // Use the current array of checkmarks but with the updated checkmark value instead
            bool[] schoolFilter = new bool[5];
            for (int i = 0; i < 5; i++)
            {
                if (i != e.Index) schoolFilter[i] = schoolFilterCheckedListBox.GetItemChecked(i);
                else schoolFilter[e.Index] = e.NewValue == CheckState.Checked;
            }
            bool[] rangeFilter = new bool[rangeFilterCheckedListBox.Items.Count];
            for (int i = 0; i < rangeFilterCheckedListBox.Items.Count; i++)
            {
                rangeFilter[i] = rangeFilterCheckedListBox.GetItemChecked(i);
            }
            bool[] miscNumberFilter = new bool[4];
            for (int i = 0; i < 4; i++)
            {
                miscNumberFilter[i] = miscNumberCheckedListBox.GetItemChecked(i);
            }

            updateEditorList(schoolFilter, rangeFilter, miscNumberFilter);
        }

        private void rangeFilterCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Use the current array of checkmarks but with the updated checkmark value instead
            bool[] schoolFilter = new bool[5];
            for (int i = 0; i < 5; i++)
            {
                schoolFilter[i] = schoolFilterCheckedListBox.GetItemChecked(i);
            }
            bool[] rangeFilter = new bool[rangeFilterCheckedListBox.Items.Count];
            for (int i = 0; i < rangeFilterCheckedListBox.Items.Count; i++)
            {
                if (i != e.Index) rangeFilter[i] = rangeFilterCheckedListBox.GetItemChecked(i);
                else rangeFilter[e.Index] = e.NewValue == CheckState.Checked;
            }
            bool[] miscNumberFilter = new bool[4];
            for (int i = 0; i < 4; i++)
            {
                miscNumberFilter[i] = miscNumberCheckedListBox.GetItemChecked(i);
            }

            updateEditorList(schoolFilter, rangeFilter, miscNumberFilter);
        }

        private void miscNumberCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Use the current array of checkmarks but with the updated checkmark value instead
            bool[] schoolFilter = new bool[5];
            for (int i = 0; i < 5; i++)
            {
                schoolFilter[i] = schoolFilterCheckedListBox.GetItemChecked(i);
            }
            bool[] rangeFilter = new bool[rangeFilterCheckedListBox.Items.Count];
            for (int i = 0; i < rangeFilterCheckedListBox.Items.Count; i++)
            {
                rangeFilter[i] = rangeFilterCheckedListBox.GetItemChecked(i);
            }
            bool[] miscNumberFilter = new bool[4];
			for (int i = 0; i < 4; i++)
			{
                if (i != e.Index) miscNumberFilter[i] = rangeFilterCheckedListBox.GetItemChecked(i);
                else miscNumberFilter[e.Index] = e.NewValue == CheckState.Checked;
            }

            updateEditorList(schoolFilter, rangeFilter, miscNumberFilter);
        }

		private void colorProfileButton_Click(object sender, EventArgs e)
		{
            // Open new form for setting colors
            var colorForm = new ColorProfileForm();
            colorForm.Owner = this;
            colorForm.ShowDialog();
            refreshView();
		}

        public void refreshView()
        {
            // Refresh the two editor views
            deckListBox.Refresh();
            editorList.Refresh();

            // Set the color on the radio button text
            attackRadioButton.ForeColor = lightColorFromType("Attack");
            attackRadioButton.Refresh();
            defenseRadioButton.ForeColor = lightColorFromType("Defense");
            defenseRadioButton.Refresh();
            eraseRadioButton.ForeColor = lightColorFromType("Erase");
            eraseRadioButton.Refresh();
            environmentalRadioButton.ForeColor = lightColorFromType("Environment");
            environmentalRadioButton.Refresh();
            statusRadioButton.ForeColor = lightColorFromType("Status");
            statusRadioButton.Refresh();
            specialRadioButton.ForeColor = lightColorFromType("Special");
        }

		private void checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
            ((CheckedListBox)sender).ClearSelected();
		}

		private void newArsenalButton_Click(object sender, EventArgs e)
		{
            // Load a blank 30 aura arsenal
            List<PDCard> emptyArsenal = new List<PDCard>();
            for (int i = 0; i < 30; i++)
            {
                emptyArsenal.Add(getCard("Aura Particle"));
            }
            openArsenalToList(emptyArsenal);
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }
    }
}