using System.Drawing;

namespace PD_Helper
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            maxSkillsButton = new Button();
            maxCreditsButton = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label8 = new Label();
            label9 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label12 = new Label();
            arsenalDropdown = new ComboBox();
            loadedArsenalGroupBox = new GroupBox();
            skillCountLabel = new Label();
            label10 = new Label();
            schoolNumeric = new NumericUpDown();
            arsenalNameLabel = new Label();
            arsenalNameBox = new TextBox();
            btnSaveToPDH = new Button();
            saveToPDbtn = new Button();
            deckListBox = new ListBox();
            arsenalListGroupBox = new GroupBox();
            label35 = new Label();
            button3 = new Button();
            label34 = new Label();
            label33 = new Label();
            button2 = new Button();
            newArsenalButton = new Button();
            colorProfileButton = new Button();
            label1 = new Label();
            label6 = new Label();
            refreshArsenalListButton = new Button();
            openArsenalFolderButton = new Button();
            partnerLock = new CheckBox();
            deleteArsenalButton = new Button();
            loadArsenalButton = new Button();
            savedArsenalListBox = new ListBox();
            arsenalEditorGroupBox = new GroupBox();
            labelSkillDescription = new RichTextBox();
            labelSkillUse = new Label();
            labelSkillStrength = new Label();
            labelSkillCost = new Label();
            labelSkilLRange = new Label();
            label24 = new Label();
            label23 = new Label();
            label22 = new Label();
            labelSkillSchool = new Label();
            labelSkillID = new Label();
            labelSkillName = new Label();
            label11 = new Label();
            editorSearchTextBox = new TextBox();
            resetSelectedButton = new Button();
            replaceSkillButton = new Button();
            editorList = new ListBox();
            GamepadWorker = new System.ComponentModel.BackgroundWorker();
            groupBox3 = new GroupBox();
            label32 = new Label();
            label31 = new Label();
            label30 = new Label();
            label29 = new Label();
            label28 = new Label();
            label27 = new Label();
            label26 = new Label();
            label25 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            sortComboBox3 = new ComboBox();
            sortComboBox2 = new ComboBox();
            sortComboBox1 = new ComboBox();
            costMaxNumeric = new NumericUpDown();
            costMinNumeric = new NumericUpDown();
            label15 = new Label();
            miscNumberCheckedListBox = new CheckedListBox();
            useMaxNumeric = new NumericUpDown();
            defMaxNumeric = new NumericUpDown();
            useMinNumeric = new NumericUpDown();
            defMinNumeric = new NumericUpDown();
            strMaxNumeric = new NumericUpDown();
            strMinNumeric = new NumericUpDown();
            label14 = new Label();
            label13 = new Label();
            label7 = new Label();
            rangeFilterCheckedListBox = new CheckedListBox();
            environmentalRadioButton = new RadioButton();
            specialRadioButton = new RadioButton();
            statusRadioButton = new RadioButton();
            eraseRadioButton = new RadioButton();
            defenseRadioButton = new RadioButton();
            attackRadioButton = new RadioButton();
            allSkillsRadioButton = new RadioButton();
            schoolFilterCheckedListBox = new CheckedListBox();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            loadedArsenalGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)schoolNumeric).BeginInit();
            arsenalListGroupBox.SuspendLayout();
            arsenalEditorGroupBox.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)costMaxNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)costMinNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)useMaxNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)defMaxNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)useMinNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)defMinNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)strMaxNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)strMinNumeric).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Orange;
            button1.Location = new Point(10, 22);
            button1.Name = "button1";
            button1.Size = new Size(205, 23);
            button1.TabIndex = 0;
            button1.Text = "Load Profile";
            button1.UseVisualStyleBackColor = true;
            button1.Click += loadGameData;
            // 
            // maxSkillsButton
            // 
            maxSkillsButton.FlatStyle = FlatStyle.Flat;
            maxSkillsButton.ForeColor = SystemColors.ScrollBar;
            maxSkillsButton.Location = new Point(6, 52);
            maxSkillsButton.Name = "maxSkillsButton";
            maxSkillsButton.Size = new Size(97, 23);
            maxSkillsButton.TabIndex = 2;
            maxSkillsButton.Text = "Max Skills";
            maxSkillsButton.UseVisualStyleBackColor = true;
            maxSkillsButton.Click += giveMaxSkills;
            // 
            // maxCreditsButton
            // 
            maxCreditsButton.FlatStyle = FlatStyle.Flat;
            maxCreditsButton.ForeColor = SystemColors.ScrollBar;
            maxCreditsButton.Location = new Point(109, 52);
            maxCreditsButton.Name = "maxCreditsButton";
            maxCreditsButton.Size = new Size(97, 23);
            maxCreditsButton.TabIndex = 3;
            maxCreditsButton.Text = "Max Credits";
            maxCreditsButton.UseVisualStyleBackColor = true;
            maxCreditsButton.Click += giveMaxCredits;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(222, 26);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 5;
            label2.Text = "Not Loaded Yet";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 34);
            label3.Name = "label3";
            label3.Size = new Size(185, 15);
            label3.TabIndex = 6;
            label3.Text = "2. Give Maxed out Skills or Credits";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ScrollBar;
            label4.Location = new Point(6, 19);
            label4.Name = "label4";
            label4.Size = new Size(170, 15);
            label4.TabIndex = 7;
            label4.Text = "1. Go to your online Lab screen";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Aquamarine;
            label5.Location = new Point(206, 19);
            label5.Name = "label5";
            label5.Size = new Size(221, 15);
            label5.TabIndex = 8;
            label5.Text = "3. Go to shop and sell 1 \"Phantom Dust\" ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ScrollBar;
            label8.Location = new Point(221, 34);
            label8.Name = "label8";
            label8.Size = new Size(185, 15);
            label8.TabIndex = 11;
            label8.Text = "(this fixes a potential visual bug)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(33, 33, 33);
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ScrollBar;
            label9.Location = new Point(144, 246);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(33, 33, 33);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(maxSkillsButton);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(maxCreditsButton);
            groupBox1.Enabled = false;
            groupBox1.ForeColor = SystemColors.ScrollBar;
            groupBox1.Location = new Point(458, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(433, 130);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Get Resources";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(33, 33, 33);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(arsenalDropdown);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(button1);
            groupBox2.ForeColor = SystemColors.ScrollBar;
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(447, 97);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Setup";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(222, 56);
            label12.Name = "label12";
            label12.Size = new Size(156, 15);
            label12.TabIndex = 32;
            label12.Text = "Change Arsenal Slot to Edit";
            // 
            // arsenalDropdown
            // 
            arsenalDropdown.BackColor = Color.FromArgb(33, 33, 33);
            arsenalDropdown.FlatStyle = FlatStyle.Flat;
            arsenalDropdown.ForeColor = SystemColors.ScrollBar;
            arsenalDropdown.FormattingEnabled = true;
            arsenalDropdown.Location = new Point(10, 51);
            arsenalDropdown.MaxDropDownItems = 16;
            arsenalDropdown.Name = "arsenalDropdown";
            arsenalDropdown.Size = new Size(205, 23);
            arsenalDropdown.TabIndex = 31;
            arsenalDropdown.SelectedIndexChanged += arsenalDropdown_SelectedIndexChanged;
            // 
            // loadedArsenalGroupBox
            // 
            loadedArsenalGroupBox.BackColor = Color.FromArgb(33, 33, 33);
            loadedArsenalGroupBox.Controls.Add(skillCountLabel);
            loadedArsenalGroupBox.Controls.Add(label10);
            loadedArsenalGroupBox.Controls.Add(schoolNumeric);
            loadedArsenalGroupBox.Controls.Add(arsenalNameLabel);
            loadedArsenalGroupBox.Controls.Add(arsenalNameBox);
            loadedArsenalGroupBox.Controls.Add(btnSaveToPDH);
            loadedArsenalGroupBox.Controls.Add(saveToPDbtn);
            loadedArsenalGroupBox.Controls.Add(deckListBox);
            loadedArsenalGroupBox.ForeColor = SystemColors.ScrollBar;
            loadedArsenalGroupBox.Location = new Point(12, 98);
            loadedArsenalGroupBox.Name = "loadedArsenalGroupBox";
            loadedArsenalGroupBox.Size = new Size(447, 239);
            loadedArsenalGroupBox.TabIndex = 17;
            loadedArsenalGroupBox.TabStop = false;
            loadedArsenalGroupBox.Text = "Loaded Arsenal";
            // 
            // skillCountLabel
            // 
            skillCountLabel.AutoSize = true;
            skillCountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            skillCountLabel.Location = new Point(294, 21);
            skillCountLabel.Name = "skillCountLabel";
            skillCountLabel.Size = new Size(31, 15);
            skillCountLabel.TabIndex = 35;
            skillCountLabel.Text = "-/30";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(352, 21);
            label10.Name = "label10";
            label10.Size = new Size(52, 15);
            label10.TabIndex = 34;
            label10.Text = "Schools:";
            // 
            // schoolNumeric
            // 
            schoolNumeric.BackColor = Color.FromArgb(33, 33, 33);
            schoolNumeric.ForeColor = SystemColors.ScrollBar;
            schoolNumeric.Location = new Point(410, 17);
            schoolNumeric.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            schoolNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            schoolNumeric.Name = "schoolNumeric";
            schoolNumeric.Size = new Size(30, 23);
            schoolNumeric.TabIndex = 33;
            schoolNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            schoolNumeric.ValueChanged += schoolNumeric_ValueChanged;
            // 
            // arsenalNameLabel
            // 
            arsenalNameLabel.AutoSize = true;
            arsenalNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            arsenalNameLabel.Location = new Point(6, 21);
            arsenalNameLabel.Name = "arsenalNameLabel";
            arsenalNameLabel.Size = new Size(87, 15);
            arsenalNameLabel.TabIndex = 6;
            arsenalNameLabel.Text = "Arsenal Name:";
            // 
            // arsenalNameBox
            // 
            arsenalNameBox.BackColor = Color.FromArgb(33, 33, 33);
            arsenalNameBox.ForeColor = SystemColors.ScrollBar;
            arsenalNameBox.Location = new Point(96, 17);
            arsenalNameBox.MaxLength = 16;
            arsenalNameBox.Name = "arsenalNameBox";
            arsenalNameBox.Size = new Size(170, 23);
            arsenalNameBox.TabIndex = 32;
            arsenalNameBox.TextChanged += arsenalNameBox_TextChanged;
            // 
            // btnSaveToPDH
            // 
            btnSaveToPDH.FlatStyle = FlatStyle.Flat;
            btnSaveToPDH.ForeColor = Color.PaleGreen;
            btnSaveToPDH.Location = new Point(246, 206);
            btnSaveToPDH.Name = "btnSaveToPDH";
            btnSaveToPDH.Size = new Size(191, 23);
            btnSaveToPDH.TabIndex = 28;
            btnSaveToPDH.Text = "Save To PDHelper";
            btnSaveToPDH.UseVisualStyleBackColor = true;
            btnSaveToPDH.Click += btnSaveToPDH_Click;
            // 
            // saveToPDbtn
            // 
            saveToPDbtn.FlatStyle = FlatStyle.Flat;
            saveToPDbtn.ForeColor = Color.SkyBlue;
            saveToPDbtn.Location = new Point(7, 206);
            saveToPDbtn.Name = "saveToPDbtn";
            saveToPDbtn.Size = new Size(191, 23);
            saveToPDbtn.TabIndex = 27;
            saveToPDbtn.Text = "Save To Phantom Dust";
            saveToPDbtn.UseVisualStyleBackColor = true;
            saveToPDbtn.Click += saveToPDbtn_Click;
            // 
            // deckListBox
            // 
            deckListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            deckListBox.BackColor = Color.FromArgb(33, 33, 33);
            deckListBox.ColumnWidth = 140;
            deckListBox.DrawMode = DrawMode.OwnerDrawFixed;
            deckListBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            deckListBox.ForeColor = SystemColors.ScrollBar;
            deckListBox.FormattingEnabled = true;
            deckListBox.ImeMode = ImeMode.Off;
            deckListBox.IntegralHeight = false;
            deckListBox.ItemHeight = 15;
            deckListBox.Location = new Point(7, 46);
            deckListBox.MultiColumn = true;
            deckListBox.Name = "deckListBox";
            deckListBox.Size = new Size(431, 154);
            deckListBox.TabIndex = 1;
            deckListBox.DrawItem += skillList_DrawItem;
            deckListBox.SelectedIndexChanged += deckListBox1_SelectedIndexChanged;
            // 
            // arsenalListGroupBox
            // 
            arsenalListGroupBox.BackColor = Color.FromArgb(33, 33, 33);
            arsenalListGroupBox.Controls.Add(label35);
            arsenalListGroupBox.Controls.Add(button3);
            arsenalListGroupBox.Controls.Add(label34);
            arsenalListGroupBox.Controls.Add(label33);
            arsenalListGroupBox.Controls.Add(button2);
            arsenalListGroupBox.Controls.Add(newArsenalButton);
            arsenalListGroupBox.Controls.Add(colorProfileButton);
            arsenalListGroupBox.Controls.Add(label1);
            arsenalListGroupBox.Controls.Add(label6);
            arsenalListGroupBox.Controls.Add(refreshArsenalListButton);
            arsenalListGroupBox.Controls.Add(openArsenalFolderButton);
            arsenalListGroupBox.Controls.Add(partnerLock);
            arsenalListGroupBox.Controls.Add(deleteArsenalButton);
            arsenalListGroupBox.Controls.Add(loadArsenalButton);
            arsenalListGroupBox.Controls.Add(savedArsenalListBox);
            arsenalListGroupBox.ForeColor = SystemColors.ScrollBar;
            arsenalListGroupBox.Location = new Point(458, 98);
            arsenalListGroupBox.Name = "arsenalListGroupBox";
            arsenalListGroupBox.Size = new Size(433, 477);
            arsenalListGroupBox.TabIndex = 1;
            arsenalListGroupBox.TabStop = false;
            arsenalListGroupBox.Text = "Arsenal List";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label35.ForeColor = SystemColors.WindowFrame;
            label35.Location = new Point(412, 289);
            label35.Name = "label35";
            label35.Size = new Size(20, 15);
            label35.TabIndex = 36;
            label35.Text = "(?)";
            toolTip1.SetToolTip(label35, "Loading a modpack only changes the game temporarily. Simply restart the game to unload all modded content.");
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.CornflowerBlue;
            button3.Location = new Point(240, 314);
            button3.Name = "button3";
            button3.Size = new Size(171, 26);
            button3.TabIndex = 35;
            button3.Text = "Load Random Deck";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label34.ForeColor = SystemColors.ControlDarkDark;
            label34.Location = new Point(240, 265);
            label34.Name = "label34";
            label34.Size = new Size(170, 15);
            label34.TabIndex = 34;
            label34.Text = "Currently No Modpack Loaded";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label33.ForeColor = SystemColors.WindowFrame;
            label33.Location = new Point(412, 320);
            label33.Name = "label33";
            label33.Size = new Size(20, 15);
            label33.TabIndex = 33;
            label33.Text = "(?)";
            toolTip2.SetToolTip(label33, resources.GetString("label33.ToolTip"));
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(128, 128, 255);
            button2.Location = new Point(240, 283);
            button2.Name = "button2";
            button2.Size = new Size(170, 26);
            button2.TabIndex = 32;
            button2.Text = "Load Modpack";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // newArsenalButton
            // 
            newArsenalButton.FlatStyle = FlatStyle.Flat;
            newArsenalButton.ForeColor = SystemColors.ScrollBar;
            newArsenalButton.Location = new Point(240, 29);
            newArsenalButton.Name = "newArsenalButton";
            newArsenalButton.Size = new Size(187, 26);
            newArsenalButton.TabIndex = 31;
            newArsenalButton.Text = "New Arsenal";
            newArsenalButton.UseVisualStyleBackColor = true;
            newArsenalButton.Click += newArsenalButton_Click;
            // 
            // colorProfileButton
            // 
            colorProfileButton.FlatStyle = FlatStyle.Flat;
            colorProfileButton.ForeColor = SystemColors.ScrollBar;
            colorProfileButton.Location = new Point(240, 346);
            colorProfileButton.Name = "colorProfileButton";
            colorProfileButton.Size = new Size(187, 26);
            colorProfileButton.TabIndex = 30;
            colorProfileButton.Text = "Color Profile Settings";
            colorProfileButton.UseVisualStyleBackColor = true;
            colorProfileButton.Click += colorProfileButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.WindowFrame;
            label1.Location = new Point(240, 127);
            label1.Name = "label1";
            label1.Size = new Size(140, 15);
            label1.TabIndex = 29;
            label1.Text = "to toggle Partner LockOn";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.WindowFrame;
            label6.Location = new Point(240, 112);
            label6.Name = "label6";
            label6.Size = new Size(163, 15);
            label6.TabIndex = 28;
            label6.Text = "Click Right Stick on Gamepad";
            // 
            // refreshArsenalListButton
            // 
            refreshArsenalListButton.FlatStyle = FlatStyle.Flat;
            refreshArsenalListButton.ForeColor = SystemColors.ScrollBar;
            refreshArsenalListButton.Location = new Point(240, 378);
            refreshArsenalListButton.Name = "refreshArsenalListButton";
            refreshArsenalListButton.Size = new Size(187, 26);
            refreshArsenalListButton.TabIndex = 27;
            refreshArsenalListButton.Text = "Refresh Arsenal List";
            refreshArsenalListButton.UseVisualStyleBackColor = true;
            refreshArsenalListButton.Click += refreshArsenalList;
            // 
            // openArsenalFolderButton
            // 
            openArsenalFolderButton.FlatStyle = FlatStyle.Flat;
            openArsenalFolderButton.ForeColor = SystemColors.ScrollBar;
            openArsenalFolderButton.Location = new Point(240, 410);
            openArsenalFolderButton.Name = "openArsenalFolderButton";
            openArsenalFolderButton.Size = new Size(187, 26);
            openArsenalFolderButton.TabIndex = 26;
            openArsenalFolderButton.Text = "Open Arsenal Folder";
            openArsenalFolderButton.UseVisualStyleBackColor = true;
            openArsenalFolderButton.Click += openArsenalFolder;
            // 
            // partnerLock
            // 
            partnerLock.AutoSize = true;
            partnerLock.Location = new Point(240, 90);
            partnerLock.Name = "partnerLock";
            partnerLock.Size = new Size(146, 19);
            partnerLock.TabIndex = 25;
            partnerLock.Text = "Enable Partner LockOn";
            partnerLock.UseVisualStyleBackColor = true;
            partnerLock.CheckedChanged += partnerLock_CheckedChanged;
            // 
            // deleteArsenalButton
            // 
            deleteArsenalButton.FlatStyle = FlatStyle.Flat;
            deleteArsenalButton.ForeColor = Color.FromArgb(212, 116, 116);
            deleteArsenalButton.Location = new Point(240, 442);
            deleteArsenalButton.Name = "deleteArsenalButton";
            deleteArsenalButton.Size = new Size(187, 26);
            deleteArsenalButton.TabIndex = 24;
            deleteArsenalButton.Text = "Delete Arsenal";
            deleteArsenalButton.UseVisualStyleBackColor = true;
            deleteArsenalButton.Click += deleteArsenal;
            // 
            // loadArsenalButton
            // 
            loadArsenalButton.FlatStyle = FlatStyle.Flat;
            loadArsenalButton.ForeColor = SystemColors.ScrollBar;
            loadArsenalButton.Location = new Point(240, 61);
            loadArsenalButton.Name = "loadArsenalButton";
            loadArsenalButton.Size = new Size(187, 23);
            loadArsenalButton.TabIndex = 23;
            loadArsenalButton.Text = "Load Arsenal";
            loadArsenalButton.UseVisualStyleBackColor = true;
            loadArsenalButton.Click += loadArsenal;
            // 
            // savedArsenalListBox
            // 
            savedArsenalListBox.BackColor = Color.FromArgb(33, 33, 33);
            savedArsenalListBox.ForeColor = SystemColors.ScrollBar;
            savedArsenalListBox.FormattingEnabled = true;
            savedArsenalListBox.ItemHeight = 15;
            savedArsenalListBox.Location = new Point(6, 29);
            savedArsenalListBox.Name = "savedArsenalListBox";
            savedArsenalListBox.Size = new Size(228, 439);
            savedArsenalListBox.TabIndex = 0;
            // 
            // arsenalEditorGroupBox
            // 
            arsenalEditorGroupBox.BackColor = Color.FromArgb(33, 33, 33);
            arsenalEditorGroupBox.Controls.Add(labelSkillDescription);
            arsenalEditorGroupBox.Controls.Add(labelSkillUse);
            arsenalEditorGroupBox.Controls.Add(labelSkillStrength);
            arsenalEditorGroupBox.Controls.Add(labelSkillCost);
            arsenalEditorGroupBox.Controls.Add(labelSkilLRange);
            arsenalEditorGroupBox.Controls.Add(label24);
            arsenalEditorGroupBox.Controls.Add(label23);
            arsenalEditorGroupBox.Controls.Add(label22);
            arsenalEditorGroupBox.Controls.Add(labelSkillSchool);
            arsenalEditorGroupBox.Controls.Add(labelSkillID);
            arsenalEditorGroupBox.Controls.Add(labelSkillName);
            arsenalEditorGroupBox.Controls.Add(label11);
            arsenalEditorGroupBox.Controls.Add(editorSearchTextBox);
            arsenalEditorGroupBox.Controls.Add(resetSelectedButton);
            arsenalEditorGroupBox.Controls.Add(replaceSkillButton);
            arsenalEditorGroupBox.Controls.Add(editorList);
            arsenalEditorGroupBox.FlatStyle = FlatStyle.Flat;
            arsenalEditorGroupBox.ForeColor = SystemColors.ScrollBar;
            arsenalEditorGroupBox.Location = new Point(12, 330);
            arsenalEditorGroupBox.Name = "arsenalEditorGroupBox";
            arsenalEditorGroupBox.Size = new Size(447, 245);
            arsenalEditorGroupBox.TabIndex = 27;
            arsenalEditorGroupBox.TabStop = false;
            arsenalEditorGroupBox.Text = "Quick Arsenal Editor";
            // 
            // labelSkillDescription
            // 
            labelSkillDescription.BackColor = Color.FromArgb(33, 33, 33);
            labelSkillDescription.BorderStyle = BorderStyle.None;
            labelSkillDescription.ForeColor = SystemColors.ScrollBar;
            labelSkillDescription.Location = new Point(222, 166);
            labelSkillDescription.Name = "labelSkillDescription";
            labelSkillDescription.ReadOnly = true;
            labelSkillDescription.Size = new Size(219, 73);
            labelSkillDescription.TabIndex = 42;
            labelSkillDescription.Text = "Press once to set. Detonates when anyone enters blast area. Freezes target's skill buttons for 3 sec.";
            // 
            // labelSkillUse
            // 
            labelSkillUse.AutoSize = true;
            labelSkillUse.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelSkillUse.Location = new Point(343, 144);
            labelSkillUse.Name = "labelSkillUse";
            labelSkillUse.Size = new Size(19, 15);
            labelSkillUse.TabIndex = 41;
            labelSkillUse.Text = "00";
            labelSkillUse.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSkillStrength
            // 
            labelSkillStrength.AutoSize = true;
            labelSkillStrength.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelSkillStrength.Location = new Point(294, 144);
            labelSkillStrength.Name = "labelSkillStrength";
            labelSkillStrength.Size = new Size(19, 15);
            labelSkillStrength.TabIndex = 40;
            labelSkillStrength.Text = "00";
            labelSkillStrength.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSkillCost
            // 
            labelSkillCost.AutoSize = true;
            labelSkillCost.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelSkillCost.Location = new Point(250, 144);
            labelSkillCost.Name = "labelSkillCost";
            labelSkillCost.Size = new Size(19, 15);
            labelSkillCost.TabIndex = 39;
            labelSkillCost.Text = "00";
            labelSkillCost.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSkilLRange
            // 
            labelSkilLRange.AutoSize = true;
            labelSkilLRange.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelSkilLRange.Location = new Point(389, 144);
            labelSkilLRange.Name = "labelSkilLRange";
            labelSkilLRange.Size = new Size(52, 15);
            labelSkilLRange.TabIndex = 38;
            labelSkilLRange.Text = "Medium";
            labelSkilLRange.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label24.Location = new Point(315, 144);
            label24.Name = "label24";
            label24.Size = new Size(31, 15);
            label24.TabIndex = 37;
            label24.Text = "Use:";
            label24.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label23.Location = new Point(219, 144);
            label23.Name = "label23";
            label23.Size = new Size(34, 15);
            label23.TabIndex = 36;
            label23.Text = "Cost:";
            label23.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label22.Location = new Point(270, 144);
            label22.Name = "label22";
            label22.Size = new Size(27, 15);
            label22.TabIndex = 35;
            label22.Text = "Str:";
            label22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSkillSchool
            // 
            labelSkillSchool.AutoSize = true;
            labelSkillSchool.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelSkillSchool.ImageAlign = ContentAlignment.MiddleRight;
            labelSkillSchool.Location = new Point(395, 119);
            labelSkillSchool.Name = "labelSkillSchool";
            labelSkillSchool.Size = new Size(46, 15);
            labelSkillSchool.TabIndex = 34;
            labelSkillSchool.Text = "Nature";
            labelSkillSchool.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSkillID
            // 
            labelSkillID.AutoSize = true;
            labelSkillID.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelSkillID.Location = new Point(219, 119);
            labelSkillID.Name = "labelSkillID";
            labelSkillID.Size = new Size(28, 15);
            labelSkillID.TabIndex = 33;
            labelSkillID.Text = "000";
            labelSkillID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSkillName
            // 
            labelSkillName.AutoSize = true;
            labelSkillName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelSkillName.Location = new Point(246, 119);
            labelSkillName.Name = "labelSkillName";
            labelSkillName.Size = new Size(78, 15);
            labelSkillName.TabIndex = 32;
            labelSkillName.Text = "Aura Particle";
            labelSkillName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(218, 84);
            label11.Name = "label11";
            label11.Size = new Size(48, 15);
            label11.TabIndex = 6;
            label11.Text = "Search:";
            // 
            // editorSearchTextBox
            // 
            editorSearchTextBox.BackColor = Color.FromArgb(33, 33, 33);
            editorSearchTextBox.ForeColor = SystemColors.ScrollBar;
            editorSearchTextBox.Location = new Point(268, 81);
            editorSearchTextBox.Name = "editorSearchTextBox";
            editorSearchTextBox.Size = new Size(173, 23);
            editorSearchTextBox.TabIndex = 31;
            editorSearchTextBox.TextChanged += updateEditorList;
            // 
            // resetSelectedButton
            // 
            resetSelectedButton.FlatStyle = FlatStyle.Flat;
            resetSelectedButton.ForeColor = SystemColors.ScrollBar;
            resetSelectedButton.Location = new Point(218, 51);
            resetSelectedButton.Name = "resetSelectedButton";
            resetSelectedButton.Size = new Size(223, 23);
            resetSelectedButton.TabIndex = 28;
            resetSelectedButton.Text = "Reset Selected";
            resetSelectedButton.UseVisualStyleBackColor = true;
            resetSelectedButton.Click += resetSkill;
            // 
            // replaceSkillButton
            // 
            replaceSkillButton.FlatStyle = FlatStyle.Flat;
            replaceSkillButton.ForeColor = SystemColors.ScrollBar;
            replaceSkillButton.Location = new Point(218, 22);
            replaceSkillButton.Name = "replaceSkillButton";
            replaceSkillButton.Size = new Size(223, 23);
            replaceSkillButton.TabIndex = 27;
            replaceSkillButton.Text = "Replace Skill";
            replaceSkillButton.UseVisualStyleBackColor = true;
            replaceSkillButton.Click += replaceSkill;
            // 
            // editorList
            // 
            editorList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            editorList.BackColor = Color.FromArgb(33, 33, 33);
            editorList.ColumnWidth = 140;
            editorList.DrawMode = DrawMode.OwnerDrawFixed;
            editorList.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            editorList.ForeColor = SystemColors.ScrollBar;
            editorList.FormattingEnabled = true;
            editorList.ImeMode = ImeMode.Off;
            editorList.IntegralHeight = false;
            editorList.ItemHeight = 15;
            editorList.Location = new Point(8, 22);
            editorList.Name = "editorList";
            editorList.Size = new Size(205, 214);
            editorList.TabIndex = 27;
            editorList.DrawItem += skillList_DrawItem;
            editorList.SelectedIndexChanged += editorList_SelectedIndexChanged;
            // 
            // GamepadWorker
            // 
            GamepadWorker.DoWork += GamepadWorker_DoWork_1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label32);
            groupBox3.Controls.Add(label31);
            groupBox3.Controls.Add(label30);
            groupBox3.Controls.Add(label29);
            groupBox3.Controls.Add(label28);
            groupBox3.Controls.Add(label27);
            groupBox3.Controls.Add(label26);
            groupBox3.Controls.Add(label25);
            groupBox3.Controls.Add(label21);
            groupBox3.Controls.Add(label20);
            groupBox3.Controls.Add(label19);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(sortComboBox3);
            groupBox3.Controls.Add(sortComboBox2);
            groupBox3.Controls.Add(sortComboBox1);
            groupBox3.Controls.Add(costMaxNumeric);
            groupBox3.Controls.Add(costMinNumeric);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(miscNumberCheckedListBox);
            groupBox3.Controls.Add(useMaxNumeric);
            groupBox3.Controls.Add(defMaxNumeric);
            groupBox3.Controls.Add(useMinNumeric);
            groupBox3.Controls.Add(defMinNumeric);
            groupBox3.Controls.Add(strMaxNumeric);
            groupBox3.Controls.Add(strMinNumeric);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(rangeFilterCheckedListBox);
            groupBox3.Controls.Add(environmentalRadioButton);
            groupBox3.Controls.Add(specialRadioButton);
            groupBox3.Controls.Add(statusRadioButton);
            groupBox3.Controls.Add(eraseRadioButton);
            groupBox3.Controls.Add(defenseRadioButton);
            groupBox3.Controls.Add(attackRadioButton);
            groupBox3.Controls.Add(allSkillsRadioButton);
            groupBox3.Controls.Add(schoolFilterCheckedListBox);
            groupBox3.ForeColor = SystemColors.ScrollBar;
            groupBox3.Location = new Point(12, 572);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(879, 177);
            groupBox3.TabIndex = 28;
            groupBox3.TabStop = false;
            groupBox3.Text = "Filter Settings";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label32.Location = new Point(634, 107);
            label32.Name = "label32";
            label32.Size = new Size(34, 15);
            label32.TabIndex = 61;
            label32.Text = "Third";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label31.Location = new Point(624, 78);
            label31.Name = "label31";
            label31.Size = new Size(46, 15);
            label31.TabIndex = 60;
            label31.Text = "Second";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label30.Location = new Point(639, 48);
            label30.Name = "label30";
            label30.Size = new Size(29, 15);
            label30.TabIndex = 59;
            label30.Text = "First";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label29.Location = new Point(672, 22);
            label29.Name = "label29";
            label29.Size = new Size(48, 15);
            label29.TabIndex = 58;
            label29.Text = "Sort By";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label28.Location = new Point(475, 134);
            label28.Name = "label28";
            label28.Size = new Size(12, 15);
            label28.TabIndex = 57;
            label28.Text = "-";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label27.Location = new Point(475, 106);
            label27.Name = "label27";
            label27.Size = new Size(12, 15);
            label27.TabIndex = 56;
            label27.Text = "-";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label26.Location = new Point(475, 77);
            label26.Name = "label26";
            label26.Size = new Size(12, 15);
            label26.TabIndex = 55;
            label26.Text = "-";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label25.Location = new Point(475, 48);
            label25.Name = "label25";
            label25.Size = new Size(12, 15);
            label25.TabIndex = 54;
            label25.Text = "-";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label21.Location = new Point(531, 62);
            label21.Name = "label21";
            label21.Size = new Size(48, 15);
            label21.TabIndex = 53;
            label21.Text = "Include";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(491, 22);
            label20.Name = "label20";
            label20.Size = new Size(31, 15);
            label20.TabIndex = 52;
            label20.Text = "Max";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(441, 22);
            label19.Name = "label19";
            label19.Size = new Size(28, 15);
            label19.TabIndex = 51;
            label19.Text = "Min";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(224, 22);
            label18.Name = "label18";
            label18.Size = new Size(42, 15);
            label18.TabIndex = 50;
            label18.Text = "Range";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(106, 22);
            label17.Name = "label17";
            label17.Size = new Size(33, 15);
            label17.TabIndex = 49;
            label17.Text = "Type";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(7, 22);
            label16.Name = "label16";
            label16.Size = new Size(44, 15);
            label16.TabIndex = 48;
            label16.Text = "School";
            label16.Click += label16_Click;
            // 
            // sortComboBox3
            // 
            sortComboBox3.BackColor = Color.FromArgb(33, 33, 33);
            sortComboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            sortComboBox3.FlatStyle = FlatStyle.Flat;
            sortComboBox3.ForeColor = SystemColors.ScrollBar;
            sortComboBox3.FormattingEnabled = true;
            sortComboBox3.Items.AddRange(new object[] { "School", "Cost", "Strength", "Number of Uses", "Range", "ID", "None" });
            sortComboBox3.Location = new Point(672, 104);
            sortComboBox3.MaxDropDownItems = 16;
            sortComboBox3.Name = "sortComboBox3";
            sortComboBox3.Size = new Size(185, 23);
            sortComboBox3.TabIndex = 47;
            sortComboBox3.SelectedIndexChanged += updateEditorList;
            // 
            // sortComboBox2
            // 
            sortComboBox2.BackColor = Color.FromArgb(33, 33, 33);
            sortComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            sortComboBox2.FlatStyle = FlatStyle.Flat;
            sortComboBox2.ForeColor = SystemColors.ScrollBar;
            sortComboBox2.FormattingEnabled = true;
            sortComboBox2.Items.AddRange(new object[] { "School", "Cost", "Strength", "Number of Uses", "Range", "ID", "None" });
            sortComboBox2.Location = new Point(672, 75);
            sortComboBox2.MaxDropDownItems = 16;
            sortComboBox2.Name = "sortComboBox2";
            sortComboBox2.Size = new Size(185, 23);
            sortComboBox2.TabIndex = 46;
            sortComboBox2.SelectedIndexChanged += updateEditorList;
            // 
            // sortComboBox1
            // 
            sortComboBox1.BackColor = Color.FromArgb(33, 33, 33);
            sortComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            sortComboBox1.FlatStyle = FlatStyle.Flat;
            sortComboBox1.ForeColor = SystemColors.ScrollBar;
            sortComboBox1.FormattingEnabled = true;
            sortComboBox1.Items.AddRange(new object[] { "School", "Cost", "Strength", "Number of Uses", "Range", "ID" });
            sortComboBox1.Location = new Point(672, 46);
            sortComboBox1.MaxDropDownItems = 16;
            sortComboBox1.Name = "sortComboBox1";
            sortComboBox1.Size = new Size(185, 23);
            sortComboBox1.TabIndex = 33;
            sortComboBox1.SelectedIndexChanged += updateEditorList;
            // 
            // costMaxNumeric
            // 
            costMaxNumeric.BackColor = Color.FromArgb(33, 33, 33);
            costMaxNumeric.ForeColor = SystemColors.ScrollBar;
            costMaxNumeric.Location = new Point(489, 130);
            costMaxNumeric.Maximum = new decimal(new int[] { 8, 0, 0, 0 });
            costMaxNumeric.Name = "costMaxNumeric";
            costMaxNumeric.Size = new Size(36, 23);
            costMaxNumeric.TabIndex = 45;
            costMaxNumeric.Value = new decimal(new int[] { 8, 0, 0, 0 });
            costMaxNumeric.ValueChanged += updateEditorList;
            // 
            // costMinNumeric
            // 
            costMinNumeric.BackColor = Color.FromArgb(33, 33, 33);
            costMinNumeric.ForeColor = SystemColors.ScrollBar;
            costMinNumeric.Location = new Point(438, 131);
            costMinNumeric.Maximum = new decimal(new int[] { 8, 0, 0, 0 });
            costMinNumeric.Name = "costMinNumeric";
            costMinNumeric.Size = new Size(36, 23);
            costMinNumeric.TabIndex = 44;
            costMinNumeric.ValueChanged += updateEditorList;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(398, 133);
            label15.Name = "label15";
            label15.Size = new Size(37, 15);
            label15.TabIndex = 43;
            label15.Text = "COST";
            // 
            // miscNumberCheckedListBox
            // 
            miscNumberCheckedListBox.BackColor = Color.FromArgb(33, 33, 33);
            miscNumberCheckedListBox.BorderStyle = BorderStyle.None;
            miscNumberCheckedListBox.CheckOnClick = true;
            miscNumberCheckedListBox.ForeColor = SystemColors.ScrollBar;
            miscNumberCheckedListBox.FormattingEnabled = true;
            miscNumberCheckedListBox.Items.AddRange(new object[] { "X STR", "- DEF", "∞ USE", "X COST" });
            miscNumberCheckedListBox.Location = new Point(531, 84);
            miscNumberCheckedListBox.Name = "miscNumberCheckedListBox";
            miscNumberCheckedListBox.Size = new Size(63, 72);
            miscNumberCheckedListBox.TabIndex = 42;
            miscNumberCheckedListBox.ItemCheck += miscNumberCheckedListBox_ItemCheck;
            miscNumberCheckedListBox.SelectedIndexChanged += checkedListBox_SelectedIndexChanged;
            // 
            // useMaxNumeric
            // 
            useMaxNumeric.BackColor = Color.FromArgb(33, 33, 33);
            useMaxNumeric.ForeColor = SystemColors.ScrollBar;
            useMaxNumeric.Location = new Point(489, 102);
            useMaxNumeric.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            useMaxNumeric.Name = "useMaxNumeric";
            useMaxNumeric.Size = new Size(36, 23);
            useMaxNumeric.TabIndex = 41;
            useMaxNumeric.Value = new decimal(new int[] { 5, 0, 0, 0 });
            useMaxNumeric.ValueChanged += updateEditorList;
            // 
            // defMaxNumeric
            // 
            defMaxNumeric.BackColor = Color.FromArgb(33, 33, 33);
            defMaxNumeric.ForeColor = SystemColors.ScrollBar;
            defMaxNumeric.Location = new Point(489, 73);
            defMaxNumeric.Maximum = new decimal(new int[] { 8, 0, 0, 0 });
            defMaxNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            defMaxNumeric.Name = "defMaxNumeric";
            defMaxNumeric.Size = new Size(36, 23);
            defMaxNumeric.TabIndex = 40;
            defMaxNumeric.Value = new decimal(new int[] { 8, 0, 0, 0 });
            defMaxNumeric.ValueChanged += updateEditorList;
            // 
            // useMinNumeric
            // 
            useMinNumeric.BackColor = Color.FromArgb(33, 33, 33);
            useMinNumeric.ForeColor = SystemColors.ScrollBar;
            useMinNumeric.Location = new Point(438, 102);
            useMinNumeric.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            useMinNumeric.Name = "useMinNumeric";
            useMinNumeric.Size = new Size(36, 23);
            useMinNumeric.TabIndex = 39;
            useMinNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            useMinNumeric.ValueChanged += updateEditorList;
            // 
            // defMinNumeric
            // 
            defMinNumeric.BackColor = Color.FromArgb(33, 33, 33);
            defMinNumeric.ForeColor = SystemColors.ScrollBar;
            defMinNumeric.Location = new Point(438, 73);
            defMinNumeric.Maximum = new decimal(new int[] { 8, 0, 0, 0 });
            defMinNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            defMinNumeric.Name = "defMinNumeric";
            defMinNumeric.Size = new Size(36, 23);
            defMinNumeric.TabIndex = 38;
            defMinNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            defMinNumeric.ValueChanged += updateEditorList;
            // 
            // strMaxNumeric
            // 
            strMaxNumeric.BackColor = Color.FromArgb(33, 33, 33);
            strMaxNumeric.ForeColor = SystemColors.ScrollBar;
            strMaxNumeric.Location = new Point(489, 44);
            strMaxNumeric.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            strMaxNumeric.Name = "strMaxNumeric";
            strMaxNumeric.Size = new Size(36, 23);
            strMaxNumeric.TabIndex = 37;
            strMaxNumeric.Value = new decimal(new int[] { 10, 0, 0, 0 });
            strMaxNumeric.ValueChanged += updateEditorList;
            // 
            // strMinNumeric
            // 
            strMinNumeric.BackColor = Color.FromArgb(33, 33, 33);
            strMinNumeric.ForeColor = SystemColors.ScrollBar;
            strMinNumeric.Location = new Point(438, 45);
            strMinNumeric.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            strMinNumeric.Name = "strMinNumeric";
            strMinNumeric.Size = new Size(36, 23);
            strMinNumeric.TabIndex = 36;
            strMinNumeric.ValueChanged += updateEditorList;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(405, 104);
            label14.Name = "label14";
            label14.Size = new Size(29, 15);
            label14.TabIndex = 16;
            label14.Text = "USE";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(405, 75);
            label13.Name = "label13";
            label13.Size = new Size(28, 15);
            label13.TabIndex = 15;
            label13.Text = "DEF";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(406, 46);
            label7.Name = "label7";
            label7.Size = new Size(29, 15);
            label7.TabIndex = 14;
            label7.Text = "STR";
            // 
            // rangeFilterCheckedListBox
            // 
            rangeFilterCheckedListBox.BackColor = Color.FromArgb(33, 33, 33);
            rangeFilterCheckedListBox.BorderStyle = BorderStyle.None;
            rangeFilterCheckedListBox.CheckOnClick = true;
            rangeFilterCheckedListBox.ColumnWidth = 75;
            rangeFilterCheckedListBox.ForeColor = SystemColors.ScrollBar;
            rangeFilterCheckedListBox.FormattingEnabled = true;
            rangeFilterCheckedListBox.Items.AddRange(new object[] { "Short", "Medium", "Long", "Mine", "Capsule", "[N/A]", "Self", "All", "Auto", "Env" });
            rangeFilterCheckedListBox.Location = new Point(226, 44);
            rangeFilterCheckedListBox.MultiColumn = true;
            rangeFilterCheckedListBox.Name = "rangeFilterCheckedListBox";
            rangeFilterCheckedListBox.Size = new Size(154, 90);
            rangeFilterCheckedListBox.TabIndex = 13;
            rangeFilterCheckedListBox.ItemCheck += rangeFilterCheckedListBox_ItemCheck;
            rangeFilterCheckedListBox.SelectedIndexChanged += checkedListBox_SelectedIndexChanged;
            // 
            // environmentalRadioButton
            // 
            environmentalRadioButton.AutoSize = true;
            environmentalRadioButton.ForeColor = Color.FromArgb(112, 239, 239);
            environmentalRadioButton.Location = new Point(108, 149);
            environmentalRadioButton.Name = "environmentalRadioButton";
            environmentalRadioButton.Size = new Size(102, 19);
            environmentalRadioButton.TabIndex = 12;
            environmentalRadioButton.Text = "Environmental";
            environmentalRadioButton.UseVisualStyleBackColor = true;
            environmentalRadioButton.CheckedChanged += updateEditorList;
            // 
            // specialRadioButton
            // 
            specialRadioButton.AutoSize = true;
            specialRadioButton.ForeColor = Color.FromArgb(239, 239, 112);
            specialRadioButton.Location = new Point(108, 132);
            specialRadioButton.Name = "specialRadioButton";
            specialRadioButton.Size = new Size(62, 19);
            specialRadioButton.TabIndex = 11;
            specialRadioButton.Text = "Special";
            specialRadioButton.UseVisualStyleBackColor = true;
            specialRadioButton.CheckedChanged += updateEditorList;
            // 
            // statusRadioButton
            // 
            statusRadioButton.AutoSize = true;
            statusRadioButton.ForeColor = Color.FromArgb(152, 239, 118);
            statusRadioButton.Location = new Point(108, 114);
            statusRadioButton.Name = "statusRadioButton";
            statusRadioButton.Size = new Size(57, 19);
            statusRadioButton.TabIndex = 10;
            statusRadioButton.Text = "Status";
            statusRadioButton.UseVisualStyleBackColor = true;
            statusRadioButton.CheckedChanged += updateEditorList;
            // 
            // eraseRadioButton
            // 
            eraseRadioButton.AutoSize = true;
            eraseRadioButton.ForeColor = Color.FromArgb(208, 112, 239);
            eraseRadioButton.Location = new Point(108, 97);
            eraseRadioButton.Name = "eraseRadioButton";
            eraseRadioButton.Size = new Size(52, 19);
            eraseRadioButton.TabIndex = 9;
            eraseRadioButton.Text = "Erase";
            eraseRadioButton.UseVisualStyleBackColor = true;
            eraseRadioButton.CheckedChanged += updateEditorList;
            // 
            // defenseRadioButton
            // 
            defenseRadioButton.AutoSize = true;
            defenseRadioButton.ForeColor = Color.FromArgb(112, 135, 239);
            defenseRadioButton.Location = new Point(108, 79);
            defenseRadioButton.Name = "defenseRadioButton";
            defenseRadioButton.Size = new Size(67, 19);
            defenseRadioButton.TabIndex = 8;
            defenseRadioButton.Text = "Defense";
            defenseRadioButton.UseVisualStyleBackColor = true;
            defenseRadioButton.CheckedChanged += updateEditorList;
            // 
            // attackRadioButton
            // 
            attackRadioButton.AutoSize = true;
            attackRadioButton.ForeColor = Color.FromArgb(239, 144, 107);
            attackRadioButton.Location = new Point(108, 61);
            attackRadioButton.Name = "attackRadioButton";
            attackRadioButton.Size = new Size(59, 19);
            attackRadioButton.TabIndex = 7;
            attackRadioButton.Text = "Attack";
            attackRadioButton.UseVisualStyleBackColor = true;
            attackRadioButton.CheckedChanged += updateEditorList;
            // 
            // allSkillsRadioButton
            // 
            allSkillsRadioButton.AutoSize = true;
            allSkillsRadioButton.Checked = true;
            allSkillsRadioButton.Location = new Point(108, 44);
            allSkillsRadioButton.Name = "allSkillsRadioButton";
            allSkillsRadioButton.Size = new Size(68, 19);
            allSkillsRadioButton.TabIndex = 6;
            allSkillsRadioButton.TabStop = true;
            allSkillsRadioButton.Text = "All Skills";
            allSkillsRadioButton.UseVisualStyleBackColor = true;
            // 
            // schoolFilterCheckedListBox
            // 
            schoolFilterCheckedListBox.BackColor = Color.FromArgb(33, 33, 33);
            schoolFilterCheckedListBox.BorderStyle = BorderStyle.None;
            schoolFilterCheckedListBox.CheckOnClick = true;
            schoolFilterCheckedListBox.ForeColor = SystemColors.ScrollBar;
            schoolFilterCheckedListBox.FormattingEnabled = true;
            schoolFilterCheckedListBox.Items.AddRange(new object[] { "Psycho", "Optical", "Nature", "Ki", "Faith" });
            schoolFilterCheckedListBox.Location = new Point(7, 43);
            schoolFilterCheckedListBox.Name = "schoolFilterCheckedListBox";
            schoolFilterCheckedListBox.Size = new Size(64, 90);
            schoolFilterCheckedListBox.TabIndex = 0;
            schoolFilterCheckedListBox.ItemCheck += schoolFilterCheckedListBox_ItemCheck;
            schoolFilterCheckedListBox.SelectedIndexChanged += checkedListBox_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            ClientSize = new Size(899, 757);
            Controls.Add(groupBox3);
            Controls.Add(arsenalEditorGroupBox);
            Controls.Add(arsenalListGroupBox);
            Controls.Add(loadedArsenalGroupBox);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label9);
            ForeColor = SystemColors.ScrollBar;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "Form1";
            RightToLeftLayout = true;
            Text = "Nuion's PD Helper V4.0 (Mod Support Update)";
            KeyDown += Form1_KeyDown;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            loadedArsenalGroupBox.ResumeLayout(false);
            loadedArsenalGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)schoolNumeric).EndInit();
            arsenalListGroupBox.ResumeLayout(false);
            arsenalListGroupBox.PerformLayout();
            arsenalEditorGroupBox.ResumeLayout(false);
            arsenalEditorGroupBox.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)costMaxNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)costMinNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)useMaxNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)defMaxNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)useMinNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)defMinNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)strMaxNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)strMinNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Button button1;
        private Button maxSkillsButton;
        private Button maxCreditsButton;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label8;
        private Label label9;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox loadedArsenalGroupBox;
        private GroupBox arsenalListGroupBox;
        private ListBox deckListBox;
        private Button deleteArsenalButton;
        private Button loadArsenalButton;
        private ListBox savedArsenalListBox;
        private GroupBox arsenalEditorGroupBox;
        private Button resetSelectedButton;
        private ListBox editorList;
        private Button replaceSkillButton;
        private ComboBox arsenalDropdown;
        private TextBox editorSearchTextBox;
        private Button btnSaveToPDH;
        private Button saveToPDbtn;
        private Label label10;
        private NumericUpDown schoolNumeric;
        private Label arsenalNameLabel;
        private TextBox arsenalNameBox;
        private Label label11;
        private CheckBox partnerLock;
        private Label labelSkillName;
        private Label labelSkillUse;
        private Label labelSkillStrength;
        private Label labelSkillCost;
        private Label labelSkilLRange;
        private Label label24;
        private Label label23;
        private Label label22;
        private Label labelSkillSchool;
        private Label labelSkillID;
        private RichTextBox labelSkillDescription;
        private Button openArsenalFolderButton;
        private Label label12;
        private Button refreshArsenalListButton;
        private System.ComponentModel.BackgroundWorker GamepadWorker;
        private Label label6;
		private GroupBox groupBox3;
		private CheckedListBox schoolFilterCheckedListBox;
		private RadioButton attackRadioButton;
		private RadioButton allSkillsRadioButton;
		private RadioButton specialRadioButton;
		private RadioButton statusRadioButton;
		private RadioButton eraseRadioButton;
		private RadioButton defenseRadioButton;
		private RadioButton environmentalRadioButton;
		private Label skillCountLabel;
        private Label label1;
		private Button colorProfileButton;
		private CheckedListBox rangeFilterCheckedListBox;
		private NumericUpDown strMinNumeric;
		private Label label14;
		private Label label13;
		private Label label7;
		private CheckedListBox miscNumberCheckedListBox;
		private NumericUpDown useMaxNumeric;
		private NumericUpDown defMaxNumeric;
		private NumericUpDown useMinNumeric;
		private NumericUpDown defMinNumeric;
		private NumericUpDown strMaxNumeric;
		private NumericUpDown costMaxNumeric;
		private NumericUpDown costMinNumeric;
		private Label label15;
		private Button newArsenalButton;
		private ComboBox sortComboBox3;
		private ComboBox sortComboBox2;
		private ComboBox sortComboBox1;
        private Label label16;
        private Label label18;
        private Label label17;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label29;
        private Label label28;
        private Label label27;
        private Label label26;
        private Label label25;
        private Label label32;
        private Label label31;
        private Label label30;
        private Button button2;
        private Label label33;
        private ToolTip toolTip1;
        private Label label34;
        private Label label35;
        private Button button3;
        private ToolTip toolTip2;
    }
}