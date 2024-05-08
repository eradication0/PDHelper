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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.button1 = new System.Windows.Forms.Button();
			this.maxSkillsButton = new System.Windows.Forms.Button();
			this.maxCreditsButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label12 = new System.Windows.Forms.Label();
			this.arsenalDropdown = new System.Windows.Forms.ComboBox();
			this.loadedArsenalGroupBox = new System.Windows.Forms.GroupBox();
			this.skillCountLabel = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.schoolNumeric = new System.Windows.Forms.NumericUpDown();
			this.arsenalNameLabel = new System.Windows.Forms.Label();
			this.arsenalNameBox = new System.Windows.Forms.TextBox();
			this.btnSaveToPDH = new System.Windows.Forms.Button();
			this.saveToPDbtn = new System.Windows.Forms.Button();
			this.deckListBox = new System.Windows.Forms.ListBox();
			this.arsenalListGroupBox = new System.Windows.Forms.GroupBox();
			this.colorProfileButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.refreshArsenalListButton = new System.Windows.Forms.Button();
			this.openArsenalFolderButton = new System.Windows.Forms.Button();
			this.partnerLock = new System.Windows.Forms.CheckBox();
			this.deleteArsenalButton = new System.Windows.Forms.Button();
			this.loadArsenalButton = new System.Windows.Forms.Button();
			this.savedArsenalListBox = new System.Windows.Forms.ListBox();
			this.arsenalEditorGroupBox = new System.Windows.Forms.GroupBox();
			this.labelSkillDescription = new System.Windows.Forms.RichTextBox();
			this.labelSkillUse = new System.Windows.Forms.Label();
			this.labelSkillStrength = new System.Windows.Forms.Label();
			this.labelSkillCost = new System.Windows.Forms.Label();
			this.labelSkilLRange = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.labelSkillSchool = new System.Windows.Forms.Label();
			this.labelSkillID = new System.Windows.Forms.Label();
			this.labelSkillName = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.editorSearchTextBox = new System.Windows.Forms.TextBox();
			this.resetSelectedButton = new System.Windows.Forms.Button();
			this.replaceSkillButton = new System.Windows.Forms.Button();
			this.editorList = new System.Windows.Forms.ListBox();
			this.GamepadWorker = new System.ComponentModel.BackgroundWorker();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.costMaxNumeric = new System.Windows.Forms.NumericUpDown();
			this.costMinNumeric = new System.Windows.Forms.NumericUpDown();
			this.label15 = new System.Windows.Forms.Label();
			this.miscNumberCheckedListBox = new System.Windows.Forms.CheckedListBox();
			this.useMaxNumeric = new System.Windows.Forms.NumericUpDown();
			this.defMaxNumeric = new System.Windows.Forms.NumericUpDown();
			this.useMinNumeric = new System.Windows.Forms.NumericUpDown();
			this.defMinNumeric = new System.Windows.Forms.NumericUpDown();
			this.strMaxNumeric = new System.Windows.Forms.NumericUpDown();
			this.strMinNumeric = new System.Windows.Forms.NumericUpDown();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.rangeFilterCheckedListBox = new System.Windows.Forms.CheckedListBox();
			this.environmentalRadioButton = new System.Windows.Forms.RadioButton();
			this.specialRadioButton = new System.Windows.Forms.RadioButton();
			this.statusRadioButton = new System.Windows.Forms.RadioButton();
			this.eraseRadioButton = new System.Windows.Forms.RadioButton();
			this.defenseRadioButton = new System.Windows.Forms.RadioButton();
			this.attackRadioButton = new System.Windows.Forms.RadioButton();
			this.allSkillsRadioButton = new System.Windows.Forms.RadioButton();
			this.schoolFilterCheckedListBox = new System.Windows.Forms.CheckedListBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.loadedArsenalGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.schoolNumeric)).BeginInit();
			this.arsenalListGroupBox.SuspendLayout();
			this.arsenalEditorGroupBox.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.costMaxNumeric)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.costMinNumeric)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.useMaxNumeric)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.defMaxNumeric)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.useMinNumeric)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.defMinNumeric)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.strMaxNumeric)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.strMinNumeric)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.Color.Orange;
			this.button1.Location = new System.Drawing.Point(10, 22);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(205, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Load Profile";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.loadGameData);
			// 
			// maxSkillsButton
			// 
			this.maxSkillsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.maxSkillsButton.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.maxSkillsButton.Location = new System.Drawing.Point(6, 52);
			this.maxSkillsButton.Name = "maxSkillsButton";
			this.maxSkillsButton.Size = new System.Drawing.Size(97, 23);
			this.maxSkillsButton.TabIndex = 2;
			this.maxSkillsButton.Text = "Max Skills";
			this.maxSkillsButton.UseVisualStyleBackColor = true;
			this.maxSkillsButton.Click += new System.EventHandler(this.giveMaxSkills);
			// 
			// maxCreditsButton
			// 
			this.maxCreditsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.maxCreditsButton.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.maxCreditsButton.Location = new System.Drawing.Point(109, 52);
			this.maxCreditsButton.Name = "maxCreditsButton";
			this.maxCreditsButton.Size = new System.Drawing.Size(97, 23);
			this.maxCreditsButton.TabIndex = 3;
			this.maxCreditsButton.Text = "Max Credits";
			this.maxCreditsButton.UseVisualStyleBackColor = true;
			this.maxCreditsButton.Click += new System.EventHandler(this.giveMaxCredits);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(222, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 15);
			this.label2.TabIndex = 5;
			this.label2.Text = "Not Loaded Yet";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(6, 34);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(185, 15);
			this.label3.TabIndex = 6;
			this.label3.Text = "2. Give Maxed out Skills or Credits";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label4.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.label4.Location = new System.Drawing.Point(6, 19);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(170, 15);
			this.label4.TabIndex = 7;
			this.label4.Text = "1. Go to your online Lab screen";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label5.ForeColor = System.Drawing.Color.Aquamarine;
			this.label5.Location = new System.Drawing.Point(206, 19);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(221, 15);
			this.label5.TabIndex = 8;
			this.label5.Text = "3. Go to shop and sell 1 \"Phantom Dust\" ";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label8.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.label8.Location = new System.Drawing.Point(221, 34);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(185, 15);
			this.label8.TabIndex = 11;
			this.label8.Text = "(this fixes a potential visual bug)";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label9.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.label9.Location = new System.Drawing.Point(144, 246);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(0, 15);
			this.label9.TabIndex = 12;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.maxSkillsButton);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.maxCreditsButton);
			this.groupBox1.Enabled = false;
			this.groupBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.groupBox1.Location = new System.Drawing.Point(458, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(433, 130);
			this.groupBox1.TabIndex = 14;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Get Resources";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.arsenalDropdown);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.button1);
			this.groupBox2.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.groupBox2.Location = new System.Drawing.Point(12, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(447, 97);
			this.groupBox2.TabIndex = 15;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Setup";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label12.Location = new System.Drawing.Point(222, 56);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(156, 15);
			this.label12.TabIndex = 32;
			this.label12.Text = "Change Arsenal Slot to Edit";
			// 
			// arsenalDropdown
			// 
			this.arsenalDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.arsenalDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.arsenalDropdown.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.arsenalDropdown.FormattingEnabled = true;
			this.arsenalDropdown.Location = new System.Drawing.Point(10, 51);
			this.arsenalDropdown.MaxDropDownItems = 16;
			this.arsenalDropdown.Name = "arsenalDropdown";
			this.arsenalDropdown.Size = new System.Drawing.Size(205, 23);
			this.arsenalDropdown.TabIndex = 31;
			this.arsenalDropdown.SelectedIndexChanged += new System.EventHandler(this.arsenalDropdown_SelectedIndexChanged);
			// 
			// loadedArsenalGroupBox
			// 
			this.loadedArsenalGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.loadedArsenalGroupBox.Controls.Add(this.skillCountLabel);
			this.loadedArsenalGroupBox.Controls.Add(this.label10);
			this.loadedArsenalGroupBox.Controls.Add(this.schoolNumeric);
			this.loadedArsenalGroupBox.Controls.Add(this.arsenalNameLabel);
			this.loadedArsenalGroupBox.Controls.Add(this.arsenalNameBox);
			this.loadedArsenalGroupBox.Controls.Add(this.btnSaveToPDH);
			this.loadedArsenalGroupBox.Controls.Add(this.saveToPDbtn);
			this.loadedArsenalGroupBox.Controls.Add(this.deckListBox);
			this.loadedArsenalGroupBox.Enabled = false;
			this.loadedArsenalGroupBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.loadedArsenalGroupBox.Location = new System.Drawing.Point(12, 98);
			this.loadedArsenalGroupBox.Name = "loadedArsenalGroupBox";
			this.loadedArsenalGroupBox.Size = new System.Drawing.Size(447, 239);
			this.loadedArsenalGroupBox.TabIndex = 17;
			this.loadedArsenalGroupBox.TabStop = false;
			this.loadedArsenalGroupBox.Text = "Loaded Arsenal";
			// 
			// skillCountLabel
			// 
			this.skillCountLabel.AutoSize = true;
			this.skillCountLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.skillCountLabel.Location = new System.Drawing.Point(294, 21);
			this.skillCountLabel.Name = "skillCountLabel";
			this.skillCountLabel.Size = new System.Drawing.Size(31, 15);
			this.skillCountLabel.TabIndex = 35;
			this.skillCountLabel.Text = "-/30";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label10.Location = new System.Drawing.Point(352, 21);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(52, 15);
			this.label10.TabIndex = 34;
			this.label10.Text = "Schools:";
			// 
			// schoolNumeric
			// 
			this.schoolNumeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.schoolNumeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.schoolNumeric.Location = new System.Drawing.Point(410, 17);
			this.schoolNumeric.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
			this.schoolNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.schoolNumeric.Name = "schoolNumeric";
			this.schoolNumeric.Size = new System.Drawing.Size(30, 23);
			this.schoolNumeric.TabIndex = 33;
			this.schoolNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.schoolNumeric.ValueChanged += new System.EventHandler(this.schoolNumeric_ValueChanged);
			// 
			// arsenalNameLabel
			// 
			this.arsenalNameLabel.AutoSize = true;
			this.arsenalNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.arsenalNameLabel.Location = new System.Drawing.Point(6, 21);
			this.arsenalNameLabel.Name = "arsenalNameLabel";
			this.arsenalNameLabel.Size = new System.Drawing.Size(87, 15);
			this.arsenalNameLabel.TabIndex = 6;
			this.arsenalNameLabel.Text = "Arsenal Name:";
			// 
			// arsenalNameBox
			// 
			this.arsenalNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.arsenalNameBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.arsenalNameBox.Location = new System.Drawing.Point(96, 17);
			this.arsenalNameBox.MaxLength = 16;
			this.arsenalNameBox.Name = "arsenalNameBox";
			this.arsenalNameBox.Size = new System.Drawing.Size(170, 23);
			this.arsenalNameBox.TabIndex = 32;
			this.arsenalNameBox.TextChanged += new System.EventHandler(this.arsenalNameBox_TextChanged);
			// 
			// btnSaveToPDH
			// 
			this.btnSaveToPDH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSaveToPDH.ForeColor = System.Drawing.Color.PaleGreen;
			this.btnSaveToPDH.Location = new System.Drawing.Point(249, 206);
			this.btnSaveToPDH.Name = "btnSaveToPDH";
			this.btnSaveToPDH.Size = new System.Drawing.Size(191, 23);
			this.btnSaveToPDH.TabIndex = 28;
			this.btnSaveToPDH.Text = "Save To PDHelper";
			this.btnSaveToPDH.UseVisualStyleBackColor = true;
			this.btnSaveToPDH.Click += new System.EventHandler(this.btnSaveToPDH_Click);
			// 
			// saveToPDbtn
			// 
			this.saveToPDbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.saveToPDbtn.ForeColor = System.Drawing.Color.SkyBlue;
			this.saveToPDbtn.Location = new System.Drawing.Point(6, 206);
			this.saveToPDbtn.Name = "saveToPDbtn";
			this.saveToPDbtn.Size = new System.Drawing.Size(191, 23);
			this.saveToPDbtn.TabIndex = 27;
			this.saveToPDbtn.Text = "Save To Phantom Dust";
			this.saveToPDbtn.UseVisualStyleBackColor = true;
			this.saveToPDbtn.Click += new System.EventHandler(this.saveToPDbtn_Click);
			// 
			// deckListBox
			// 
			this.deckListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.deckListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.deckListBox.ColumnWidth = 140;
			this.deckListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.deckListBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.deckListBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.deckListBox.FormattingEnabled = true;
			this.deckListBox.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.deckListBox.ItemHeight = 15;
			this.deckListBox.Location = new System.Drawing.Point(7, 46);
			this.deckListBox.MultiColumn = true;
			this.deckListBox.Name = "deckListBox";
			this.deckListBox.Size = new System.Drawing.Size(434, 154);
			this.deckListBox.TabIndex = 1;
			this.deckListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.skillList_DrawItem);
			this.deckListBox.SelectedIndexChanged += new System.EventHandler(this.deckListBox1_SelectedIndexChanged);
			// 
			// arsenalListGroupBox
			// 
			this.arsenalListGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.arsenalListGroupBox.Controls.Add(this.colorProfileButton);
			this.arsenalListGroupBox.Controls.Add(this.label1);
			this.arsenalListGroupBox.Controls.Add(this.label6);
			this.arsenalListGroupBox.Controls.Add(this.refreshArsenalListButton);
			this.arsenalListGroupBox.Controls.Add(this.openArsenalFolderButton);
			this.arsenalListGroupBox.Controls.Add(this.partnerLock);
			this.arsenalListGroupBox.Controls.Add(this.deleteArsenalButton);
			this.arsenalListGroupBox.Controls.Add(this.loadArsenalButton);
			this.arsenalListGroupBox.Controls.Add(this.savedArsenalListBox);
			this.arsenalListGroupBox.Enabled = false;
			this.arsenalListGroupBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.arsenalListGroupBox.Location = new System.Drawing.Point(458, 98);
			this.arsenalListGroupBox.Name = "arsenalListGroupBox";
			this.arsenalListGroupBox.Size = new System.Drawing.Size(433, 477);
			this.arsenalListGroupBox.TabIndex = 1;
			this.arsenalListGroupBox.TabStop = false;
			this.arsenalListGroupBox.Text = "Arsenal List";
			// 
			// colorProfileButton
			// 
			this.colorProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.colorProfileButton.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.colorProfileButton.Location = new System.Drawing.Point(240, 346);
			this.colorProfileButton.Name = "colorProfileButton";
			this.colorProfileButton.Size = new System.Drawing.Size(187, 26);
			this.colorProfileButton.TabIndex = 30;
			this.colorProfileButton.Text = "Color Profile Settings";
			this.colorProfileButton.UseVisualStyleBackColor = true;
			this.colorProfileButton.Click += new System.EventHandler(this.colorProfileButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.label1.Location = new System.Drawing.Point(240, 95);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(140, 15);
			this.label1.TabIndex = 29;
			this.label1.Text = "to toggle Partner LockOn";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label6.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.label6.Location = new System.Drawing.Point(240, 80);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(163, 15);
			this.label6.TabIndex = 28;
			this.label6.Text = "Click Right Stick on Gamepad";
			// 
			// refreshArsenalListButton
			// 
			this.refreshArsenalListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.refreshArsenalListButton.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.refreshArsenalListButton.Location = new System.Drawing.Point(240, 378);
			this.refreshArsenalListButton.Name = "refreshArsenalListButton";
			this.refreshArsenalListButton.Size = new System.Drawing.Size(187, 26);
			this.refreshArsenalListButton.TabIndex = 27;
			this.refreshArsenalListButton.Text = "Refresh Arsenal List";
			this.refreshArsenalListButton.UseVisualStyleBackColor = true;
			this.refreshArsenalListButton.Click += new System.EventHandler(this.refreshArsenalList);
			// 
			// openArsenalFolderButton
			// 
			this.openArsenalFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.openArsenalFolderButton.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.openArsenalFolderButton.Location = new System.Drawing.Point(240, 410);
			this.openArsenalFolderButton.Name = "openArsenalFolderButton";
			this.openArsenalFolderButton.Size = new System.Drawing.Size(187, 26);
			this.openArsenalFolderButton.TabIndex = 26;
			this.openArsenalFolderButton.Text = "Open Arsenal Folder";
			this.openArsenalFolderButton.UseVisualStyleBackColor = true;
			this.openArsenalFolderButton.Click += new System.EventHandler(this.openArsenalFolder);
			// 
			// partnerLock
			// 
			this.partnerLock.AutoSize = true;
			this.partnerLock.Location = new System.Drawing.Point(240, 58);
			this.partnerLock.Name = "partnerLock";
			this.partnerLock.Size = new System.Drawing.Size(146, 19);
			this.partnerLock.TabIndex = 25;
			this.partnerLock.Text = "Enable Partner LockOn";
			this.partnerLock.UseVisualStyleBackColor = true;
			this.partnerLock.CheckedChanged += new System.EventHandler(this.partnerLock_CheckedChanged);
			// 
			// deleteArsenalButton
			// 
			this.deleteArsenalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.deleteArsenalButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
			this.deleteArsenalButton.Location = new System.Drawing.Point(240, 442);
			this.deleteArsenalButton.Name = "deleteArsenalButton";
			this.deleteArsenalButton.Size = new System.Drawing.Size(187, 26);
			this.deleteArsenalButton.TabIndex = 24;
			this.deleteArsenalButton.Text = "Delete Arsenal";
			this.deleteArsenalButton.UseVisualStyleBackColor = true;
			this.deleteArsenalButton.Click += new System.EventHandler(this.deleteArsenal);
			// 
			// loadArsenalButton
			// 
			this.loadArsenalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.loadArsenalButton.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.loadArsenalButton.Location = new System.Drawing.Point(240, 29);
			this.loadArsenalButton.Name = "loadArsenalButton";
			this.loadArsenalButton.Size = new System.Drawing.Size(187, 23);
			this.loadArsenalButton.TabIndex = 23;
			this.loadArsenalButton.Text = "Load Arsenal";
			this.loadArsenalButton.UseVisualStyleBackColor = true;
			this.loadArsenalButton.Click += new System.EventHandler(this.loadArsenal);
			// 
			// savedArsenalListBox
			// 
			this.savedArsenalListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.savedArsenalListBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.savedArsenalListBox.FormattingEnabled = true;
			this.savedArsenalListBox.ItemHeight = 15;
			this.savedArsenalListBox.Location = new System.Drawing.Point(6, 29);
			this.savedArsenalListBox.Name = "savedArsenalListBox";
			this.savedArsenalListBox.Size = new System.Drawing.Size(228, 439);
			this.savedArsenalListBox.TabIndex = 0;
			// 
			// arsenalEditorGroupBox
			// 
			this.arsenalEditorGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.arsenalEditorGroupBox.Controls.Add(this.labelSkillDescription);
			this.arsenalEditorGroupBox.Controls.Add(this.labelSkillUse);
			this.arsenalEditorGroupBox.Controls.Add(this.labelSkillStrength);
			this.arsenalEditorGroupBox.Controls.Add(this.labelSkillCost);
			this.arsenalEditorGroupBox.Controls.Add(this.labelSkilLRange);
			this.arsenalEditorGroupBox.Controls.Add(this.label24);
			this.arsenalEditorGroupBox.Controls.Add(this.label23);
			this.arsenalEditorGroupBox.Controls.Add(this.label22);
			this.arsenalEditorGroupBox.Controls.Add(this.labelSkillSchool);
			this.arsenalEditorGroupBox.Controls.Add(this.labelSkillID);
			this.arsenalEditorGroupBox.Controls.Add(this.labelSkillName);
			this.arsenalEditorGroupBox.Controls.Add(this.label11);
			this.arsenalEditorGroupBox.Controls.Add(this.editorSearchTextBox);
			this.arsenalEditorGroupBox.Controls.Add(this.resetSelectedButton);
			this.arsenalEditorGroupBox.Controls.Add(this.replaceSkillButton);
			this.arsenalEditorGroupBox.Controls.Add(this.editorList);
			this.arsenalEditorGroupBox.Enabled = false;
			this.arsenalEditorGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.arsenalEditorGroupBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.arsenalEditorGroupBox.Location = new System.Drawing.Point(12, 330);
			this.arsenalEditorGroupBox.Name = "arsenalEditorGroupBox";
			this.arsenalEditorGroupBox.Size = new System.Drawing.Size(447, 245);
			this.arsenalEditorGroupBox.TabIndex = 27;
			this.arsenalEditorGroupBox.TabStop = false;
			this.arsenalEditorGroupBox.Text = "Quick Arsenal Editor";
			// 
			// labelSkillDescription
			// 
			this.labelSkillDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.labelSkillDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.labelSkillDescription.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.labelSkillDescription.Location = new System.Drawing.Point(222, 166);
			this.labelSkillDescription.Name = "labelSkillDescription";
			this.labelSkillDescription.ReadOnly = true;
			this.labelSkillDescription.Size = new System.Drawing.Size(219, 73);
			this.labelSkillDescription.TabIndex = 42;
			this.labelSkillDescription.Text = "Press once to set. Detonates when anyone enters blast area. Freezes target\'s skil" +
    "l buttons for 3 sec.";
			// 
			// labelSkillUse
			// 
			this.labelSkillUse.AutoSize = true;
			this.labelSkillUse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelSkillUse.Location = new System.Drawing.Point(343, 144);
			this.labelSkillUse.Name = "labelSkillUse";
			this.labelSkillUse.Size = new System.Drawing.Size(19, 15);
			this.labelSkillUse.TabIndex = 41;
			this.labelSkillUse.Text = "00";
			this.labelSkillUse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelSkillStrength
			// 
			this.labelSkillStrength.AutoSize = true;
			this.labelSkillStrength.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelSkillStrength.Location = new System.Drawing.Point(294, 144);
			this.labelSkillStrength.Name = "labelSkillStrength";
			this.labelSkillStrength.Size = new System.Drawing.Size(19, 15);
			this.labelSkillStrength.TabIndex = 40;
			this.labelSkillStrength.Text = "00";
			this.labelSkillStrength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelSkillCost
			// 
			this.labelSkillCost.AutoSize = true;
			this.labelSkillCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelSkillCost.Location = new System.Drawing.Point(250, 144);
			this.labelSkillCost.Name = "labelSkillCost";
			this.labelSkillCost.Size = new System.Drawing.Size(19, 15);
			this.labelSkillCost.TabIndex = 39;
			this.labelSkillCost.Text = "00";
			this.labelSkillCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelSkilLRange
			// 
			this.labelSkilLRange.AutoSize = true;
			this.labelSkilLRange.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelSkilLRange.Location = new System.Drawing.Point(389, 144);
			this.labelSkilLRange.Name = "labelSkilLRange";
			this.labelSkilLRange.Size = new System.Drawing.Size(52, 15);
			this.labelSkilLRange.TabIndex = 38;
			this.labelSkilLRange.Text = "Medium";
			this.labelSkilLRange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label24.Location = new System.Drawing.Point(315, 144);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(31, 15);
			this.label24.TabIndex = 37;
			this.label24.Text = "Use:";
			this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label23.Location = new System.Drawing.Point(219, 144);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(34, 15);
			this.label23.TabIndex = 36;
			this.label23.Text = "Cost:";
			this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label22.Location = new System.Drawing.Point(270, 144);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(27, 15);
			this.label22.TabIndex = 35;
			this.label22.Text = "Str:";
			this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelSkillSchool
			// 
			this.labelSkillSchool.AutoSize = true;
			this.labelSkillSchool.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.labelSkillSchool.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.labelSkillSchool.Location = new System.Drawing.Point(395, 119);
			this.labelSkillSchool.Name = "labelSkillSchool";
			this.labelSkillSchool.Size = new System.Drawing.Size(46, 15);
			this.labelSkillSchool.TabIndex = 34;
			this.labelSkillSchool.Text = "Nature";
			this.labelSkillSchool.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelSkillID
			// 
			this.labelSkillID.AutoSize = true;
			this.labelSkillID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.labelSkillID.Location = new System.Drawing.Point(219, 119);
			this.labelSkillID.Name = "labelSkillID";
			this.labelSkillID.Size = new System.Drawing.Size(28, 15);
			this.labelSkillID.TabIndex = 33;
			this.labelSkillID.Text = "000";
			this.labelSkillID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelSkillName
			// 
			this.labelSkillName.AutoSize = true;
			this.labelSkillName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.labelSkillName.Location = new System.Drawing.Point(246, 119);
			this.labelSkillName.Name = "labelSkillName";
			this.labelSkillName.Size = new System.Drawing.Size(78, 15);
			this.labelSkillName.TabIndex = 32;
			this.labelSkillName.Text = "Aura Particle";
			this.labelSkillName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label11.Location = new System.Drawing.Point(218, 84);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(48, 15);
			this.label11.TabIndex = 6;
			this.label11.Text = "Search:";
			// 
			// editorSearchTextBox
			// 
			this.editorSearchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.editorSearchTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.editorSearchTextBox.Location = new System.Drawing.Point(268, 81);
			this.editorSearchTextBox.Name = "editorSearchTextBox";
			this.editorSearchTextBox.Size = new System.Drawing.Size(173, 23);
			this.editorSearchTextBox.TabIndex = 31;
			this.editorSearchTextBox.TextChanged += new System.EventHandler(this.updateEditorList);
			// 
			// resetSelectedButton
			// 
			this.resetSelectedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.resetSelectedButton.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.resetSelectedButton.Location = new System.Drawing.Point(218, 51);
			this.resetSelectedButton.Name = "resetSelectedButton";
			this.resetSelectedButton.Size = new System.Drawing.Size(223, 23);
			this.resetSelectedButton.TabIndex = 28;
			this.resetSelectedButton.Text = "Reset Selected";
			this.resetSelectedButton.UseVisualStyleBackColor = true;
			this.resetSelectedButton.Click += new System.EventHandler(this.resetSkill);
			// 
			// replaceSkillButton
			// 
			this.replaceSkillButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.replaceSkillButton.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.replaceSkillButton.Location = new System.Drawing.Point(218, 22);
			this.replaceSkillButton.Name = "replaceSkillButton";
			this.replaceSkillButton.Size = new System.Drawing.Size(223, 23);
			this.replaceSkillButton.TabIndex = 27;
			this.replaceSkillButton.Text = "Replace Skill";
			this.replaceSkillButton.UseVisualStyleBackColor = true;
			this.replaceSkillButton.Click += new System.EventHandler(this.replaceSkill);
			// 
			// editorList
			// 
			this.editorList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.editorList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.editorList.ColumnWidth = 140;
			this.editorList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.editorList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.editorList.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.editorList.FormattingEnabled = true;
			this.editorList.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.editorList.ItemHeight = 15;
			this.editorList.Location = new System.Drawing.Point(8, 22);
			this.editorList.Name = "editorList";
			this.editorList.Size = new System.Drawing.Size(205, 214);
			this.editorList.TabIndex = 27;
			this.editorList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.skillList_DrawItem);
			this.editorList.SelectedIndexChanged += new System.EventHandler(this.editorList_SelectedIndexChanged);
			// 
			// GamepadWorker
			// 
			this.GamepadWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.GamepadWorker_DoWork_1);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.costMaxNumeric);
			this.groupBox3.Controls.Add(this.costMinNumeric);
			this.groupBox3.Controls.Add(this.label15);
			this.groupBox3.Controls.Add(this.miscNumberCheckedListBox);
			this.groupBox3.Controls.Add(this.useMaxNumeric);
			this.groupBox3.Controls.Add(this.defMaxNumeric);
			this.groupBox3.Controls.Add(this.useMinNumeric);
			this.groupBox3.Controls.Add(this.defMinNumeric);
			this.groupBox3.Controls.Add(this.strMaxNumeric);
			this.groupBox3.Controls.Add(this.strMinNumeric);
			this.groupBox3.Controls.Add(this.label14);
			this.groupBox3.Controls.Add(this.label13);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.rangeFilterCheckedListBox);
			this.groupBox3.Controls.Add(this.environmentalRadioButton);
			this.groupBox3.Controls.Add(this.specialRadioButton);
			this.groupBox3.Controls.Add(this.statusRadioButton);
			this.groupBox3.Controls.Add(this.eraseRadioButton);
			this.groupBox3.Controls.Add(this.defenseRadioButton);
			this.groupBox3.Controls.Add(this.attackRadioButton);
			this.groupBox3.Controls.Add(this.allSkillsRadioButton);
			this.groupBox3.Controls.Add(this.schoolFilterCheckedListBox);
			this.groupBox3.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.groupBox3.Location = new System.Drawing.Point(12, 572);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(879, 129);
			this.groupBox3.TabIndex = 28;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Filter Settings";
			// 
			// costMaxNumeric
			// 
			this.costMaxNumeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.costMaxNumeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.costMaxNumeric.Location = new System.Drawing.Point(463, 100);
			this.costMaxNumeric.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
			this.costMaxNumeric.Name = "costMaxNumeric";
			this.costMaxNumeric.Size = new System.Drawing.Size(36, 23);
			this.costMaxNumeric.TabIndex = 45;
			this.costMaxNumeric.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
			this.costMaxNumeric.ValueChanged += new System.EventHandler(this.updateEditorList);
			// 
			// costMinNumeric
			// 
			this.costMinNumeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.costMinNumeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.costMinNumeric.Location = new System.Drawing.Point(421, 99);
			this.costMinNumeric.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
			this.costMinNumeric.Name = "costMinNumeric";
			this.costMinNumeric.Size = new System.Drawing.Size(36, 23);
			this.costMinNumeric.TabIndex = 44;
			this.costMinNumeric.ValueChanged += new System.EventHandler(this.updateEditorList);
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label15.Location = new System.Drawing.Point(381, 101);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(37, 15);
			this.label15.TabIndex = 43;
			this.label15.Text = "COST";
			// 
			// miscNumberCheckedListBox
			// 
			this.miscNumberCheckedListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.miscNumberCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.miscNumberCheckedListBox.CheckOnClick = true;
			this.miscNumberCheckedListBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.miscNumberCheckedListBox.FormattingEnabled = true;
			this.miscNumberCheckedListBox.Items.AddRange(new object[] {
            "X STR",
            "- DEF",
            "∞ USE",
            "X COST"});
			this.miscNumberCheckedListBox.Location = new System.Drawing.Point(505, 12);
			this.miscNumberCheckedListBox.Name = "miscNumberCheckedListBox";
			this.miscNumberCheckedListBox.Size = new System.Drawing.Size(63, 72);
			this.miscNumberCheckedListBox.TabIndex = 42;
			this.miscNumberCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.miscNumberCheckedListBox_ItemCheck);
			this.miscNumberCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_SelectedIndexChanged);
			// 
			// useMaxNumeric
			// 
			this.useMaxNumeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.useMaxNumeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.useMaxNumeric.Location = new System.Drawing.Point(463, 70);
			this.useMaxNumeric.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.useMaxNumeric.Name = "useMaxNumeric";
			this.useMaxNumeric.Size = new System.Drawing.Size(36, 23);
			this.useMaxNumeric.TabIndex = 41;
			this.useMaxNumeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.useMaxNumeric.ValueChanged += new System.EventHandler(this.updateEditorList);
			// 
			// defMaxNumeric
			// 
			this.defMaxNumeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.defMaxNumeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.defMaxNumeric.Location = new System.Drawing.Point(463, 41);
			this.defMaxNumeric.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
			this.defMaxNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.defMaxNumeric.Name = "defMaxNumeric";
			this.defMaxNumeric.Size = new System.Drawing.Size(36, 23);
			this.defMaxNumeric.TabIndex = 40;
			this.defMaxNumeric.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
			this.defMaxNumeric.ValueChanged += new System.EventHandler(this.updateEditorList);
			// 
			// useMinNumeric
			// 
			this.useMinNumeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.useMinNumeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.useMinNumeric.Location = new System.Drawing.Point(421, 70);
			this.useMinNumeric.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.useMinNumeric.Name = "useMinNumeric";
			this.useMinNumeric.Size = new System.Drawing.Size(36, 23);
			this.useMinNumeric.TabIndex = 39;
			this.useMinNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.useMinNumeric.ValueChanged += new System.EventHandler(this.updateEditorList);
			// 
			// defMinNumeric
			// 
			this.defMinNumeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.defMinNumeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.defMinNumeric.Location = new System.Drawing.Point(421, 41);
			this.defMinNumeric.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
			this.defMinNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.defMinNumeric.Name = "defMinNumeric";
			this.defMinNumeric.Size = new System.Drawing.Size(36, 23);
			this.defMinNumeric.TabIndex = 38;
			this.defMinNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.defMinNumeric.ValueChanged += new System.EventHandler(this.updateEditorList);
			// 
			// strMaxNumeric
			// 
			this.strMaxNumeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.strMaxNumeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.strMaxNumeric.Location = new System.Drawing.Point(463, 12);
			this.strMaxNumeric.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.strMaxNumeric.Name = "strMaxNumeric";
			this.strMaxNumeric.Size = new System.Drawing.Size(36, 23);
			this.strMaxNumeric.TabIndex = 37;
			this.strMaxNumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.strMaxNumeric.ValueChanged += new System.EventHandler(this.updateEditorList);
			// 
			// strMinNumeric
			// 
			this.strMinNumeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.strMinNumeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.strMinNumeric.Location = new System.Drawing.Point(421, 12);
			this.strMinNumeric.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.strMinNumeric.Name = "strMinNumeric";
			this.strMinNumeric.Size = new System.Drawing.Size(36, 23);
			this.strMinNumeric.TabIndex = 36;
			this.strMinNumeric.ValueChanged += new System.EventHandler(this.updateEditorList);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label14.Location = new System.Drawing.Point(388, 72);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(29, 15);
			this.label14.TabIndex = 16;
			this.label14.Text = "USE";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label13.Location = new System.Drawing.Point(388, 43);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(28, 15);
			this.label13.TabIndex = 15;
			this.label13.Text = "DEF";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label7.Location = new System.Drawing.Point(389, 14);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(29, 15);
			this.label7.TabIndex = 14;
			this.label7.Text = "STR";
			// 
			// rangeFilterCheckedListBox
			// 
			this.rangeFilterCheckedListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.rangeFilterCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rangeFilterCheckedListBox.CheckOnClick = true;
			this.rangeFilterCheckedListBox.ColumnWidth = 75;
			this.rangeFilterCheckedListBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.rangeFilterCheckedListBox.FormattingEnabled = true;
			this.rangeFilterCheckedListBox.Items.AddRange(new object[] {
            "Short",
            "Medium",
            "Long",
            "Mine",
            "Capsule",
            "[N/A]",
            "Self",
            "All",
            "Auto",
            "Env"});
			this.rangeFilterCheckedListBox.Location = new System.Drawing.Point(250, 22);
			this.rangeFilterCheckedListBox.MultiColumn = true;
			this.rangeFilterCheckedListBox.Name = "rangeFilterCheckedListBox";
			this.rangeFilterCheckedListBox.Size = new System.Drawing.Size(154, 90);
			this.rangeFilterCheckedListBox.TabIndex = 13;
			this.rangeFilterCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.rangeFilterCheckedListBox_ItemCheck);
			this.rangeFilterCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_SelectedIndexChanged);
			// 
			// environmentalRadioButton
			// 
			this.environmentalRadioButton.AutoSize = true;
			this.environmentalRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
			this.environmentalRadioButton.Location = new System.Drawing.Point(142, 91);
			this.environmentalRadioButton.Name = "environmentalRadioButton";
			this.environmentalRadioButton.Size = new System.Drawing.Size(102, 19);
			this.environmentalRadioButton.TabIndex = 12;
			this.environmentalRadioButton.Text = "Environmental";
			this.environmentalRadioButton.UseVisualStyleBackColor = true;
			this.environmentalRadioButton.CheckedChanged += new System.EventHandler(this.updateEditorList);
			// 
			// specialRadioButton
			// 
			this.specialRadioButton.AutoSize = true;
			this.specialRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(112)))));
			this.specialRadioButton.Location = new System.Drawing.Point(77, 91);
			this.specialRadioButton.Name = "specialRadioButton";
			this.specialRadioButton.Size = new System.Drawing.Size(62, 19);
			this.specialRadioButton.TabIndex = 11;
			this.specialRadioButton.Text = "Special";
			this.specialRadioButton.UseVisualStyleBackColor = true;
			this.specialRadioButton.CheckedChanged += new System.EventHandler(this.updateEditorList);
			// 
			// statusRadioButton
			// 
			this.statusRadioButton.AutoSize = true;
			this.statusRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(239)))), ((int)(((byte)(118)))));
			this.statusRadioButton.Location = new System.Drawing.Point(142, 66);
			this.statusRadioButton.Name = "statusRadioButton";
			this.statusRadioButton.Size = new System.Drawing.Size(57, 19);
			this.statusRadioButton.TabIndex = 10;
			this.statusRadioButton.Text = "Status";
			this.statusRadioButton.UseVisualStyleBackColor = true;
			this.statusRadioButton.CheckedChanged += new System.EventHandler(this.updateEditorList);
			// 
			// eraseRadioButton
			// 
			this.eraseRadioButton.AutoSize = true;
			this.eraseRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(112)))), ((int)(((byte)(239)))));
			this.eraseRadioButton.Location = new System.Drawing.Point(77, 66);
			this.eraseRadioButton.Name = "eraseRadioButton";
			this.eraseRadioButton.Size = new System.Drawing.Size(52, 19);
			this.eraseRadioButton.TabIndex = 9;
			this.eraseRadioButton.Text = "Erase";
			this.eraseRadioButton.UseVisualStyleBackColor = true;
			this.eraseRadioButton.CheckedChanged += new System.EventHandler(this.updateEditorList);
			// 
			// defenseRadioButton
			// 
			this.defenseRadioButton.AutoSize = true;
			this.defenseRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(135)))), ((int)(((byte)(239)))));
			this.defenseRadioButton.Location = new System.Drawing.Point(142, 41);
			this.defenseRadioButton.Name = "defenseRadioButton";
			this.defenseRadioButton.Size = new System.Drawing.Size(67, 19);
			this.defenseRadioButton.TabIndex = 8;
			this.defenseRadioButton.Text = "Defense";
			this.defenseRadioButton.UseVisualStyleBackColor = true;
			this.defenseRadioButton.CheckedChanged += new System.EventHandler(this.updateEditorList);
			// 
			// attackRadioButton
			// 
			this.attackRadioButton.AutoSize = true;
			this.attackRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(144)))), ((int)(((byte)(107)))));
			this.attackRadioButton.Location = new System.Drawing.Point(77, 41);
			this.attackRadioButton.Name = "attackRadioButton";
			this.attackRadioButton.Size = new System.Drawing.Size(59, 19);
			this.attackRadioButton.TabIndex = 7;
			this.attackRadioButton.Text = "Attack";
			this.attackRadioButton.UseVisualStyleBackColor = true;
			this.attackRadioButton.CheckedChanged += new System.EventHandler(this.updateEditorList);
			// 
			// allSkillsRadioButton
			// 
			this.allSkillsRadioButton.AutoSize = true;
			this.allSkillsRadioButton.Checked = true;
			this.allSkillsRadioButton.Location = new System.Drawing.Point(77, 16);
			this.allSkillsRadioButton.Name = "allSkillsRadioButton";
			this.allSkillsRadioButton.Size = new System.Drawing.Size(68, 19);
			this.allSkillsRadioButton.TabIndex = 6;
			this.allSkillsRadioButton.TabStop = true;
			this.allSkillsRadioButton.Text = "All Skills";
			this.allSkillsRadioButton.UseVisualStyleBackColor = true;
			// 
			// schoolFilterCheckedListBox
			// 
			this.schoolFilterCheckedListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.schoolFilterCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.schoolFilterCheckedListBox.CheckOnClick = true;
			this.schoolFilterCheckedListBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.schoolFilterCheckedListBox.FormattingEnabled = true;
			this.schoolFilterCheckedListBox.Items.AddRange(new object[] {
            "Psycho",
            "Optical",
            "Nature",
            "Ki",
            "Faith"});
			this.schoolFilterCheckedListBox.Location = new System.Drawing.Point(7, 22);
			this.schoolFilterCheckedListBox.Name = "schoolFilterCheckedListBox";
			this.schoolFilterCheckedListBox.Size = new System.Drawing.Size(64, 90);
			this.schoolFilterCheckedListBox.TabIndex = 0;
			this.schoolFilterCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.schoolFilterCheckedListBox_ItemCheck);
			this.schoolFilterCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_SelectedIndexChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.ClientSize = new System.Drawing.Size(904, 705);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.arsenalEditorGroupBox);
			this.Controls.Add(this.arsenalListGroupBox);
			this.Controls.Add(this.loadedArsenalGroupBox);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label9);
			this.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Name = "Form1";
			this.RightToLeftLayout = true;
			this.Text = "Nuion\'s PD Helper Extended V3 (Arsenal Editor Visuals Update)";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.loadedArsenalGroupBox.ResumeLayout(false);
			this.loadedArsenalGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.schoolNumeric)).EndInit();
			this.arsenalListGroupBox.ResumeLayout(false);
			this.arsenalListGroupBox.PerformLayout();
			this.arsenalEditorGroupBox.ResumeLayout(false);
			this.arsenalEditorGroupBox.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.costMaxNumeric)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.costMinNumeric)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.useMaxNumeric)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.defMaxNumeric)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.useMinNumeric)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.defMinNumeric)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.strMaxNumeric)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.strMinNumeric)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

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
	}
}