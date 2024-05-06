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
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
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
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label10 = new System.Windows.Forms.Label();
			this.schoolNumeric = new System.Windows.Forms.NumericUpDown();
			this.arsenalNameLabel = new System.Windows.Forms.Label();
			this.arsenalNameBox = new System.Windows.Forms.TextBox();
			this.btnSaveToPDH = new System.Windows.Forms.Button();
			this.saveToPDbtn = new System.Windows.Forms.Button();
			this.deckListBox = new System.Windows.Forms.ListBox();
			this.arsenalListBox = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button7 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.partnerLock = new System.Windows.Forms.CheckBox();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.savedArsenalListBox = new System.Windows.Forms.ListBox();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button13 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.editorList = new System.Windows.Forms.ListBox();
			this.GamepadWorker = new System.ComponentModel.BackgroundWorker();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.schoolFilterCheckedListBox = new System.Windows.Forms.CheckedListBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.schoolNumeric)).BeginInit();
			this.arsenalListBox.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.groupBox3.SuspendLayout();
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
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button3
			// 
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.button3.Location = new System.Drawing.Point(6, 52);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(97, 23);
			this.button3.TabIndex = 2;
			this.button3.Text = "Max Skills";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.button4.Location = new System.Drawing.Point(109, 52);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(97, 23);
			this.button4.TabIndex = 3;
			this.button4.Text = "Max Credits";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
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
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.button4);
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
			this.label12.Click += new System.EventHandler(this.label12_Click_1);
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
			this.arsenalDropdown.SelectionChangeCommitted += new System.EventHandler(this.arsenalDropdown_SelectionChangeCommitted);
			// 
			// groupBox4
			// 
			this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.groupBox4.Controls.Add(this.label10);
			this.groupBox4.Controls.Add(this.schoolNumeric);
			this.groupBox4.Controls.Add(this.arsenalNameLabel);
			this.groupBox4.Controls.Add(this.arsenalNameBox);
			this.groupBox4.Controls.Add(this.btnSaveToPDH);
			this.groupBox4.Controls.Add(this.saveToPDbtn);
			this.groupBox4.Controls.Add(this.deckListBox);
			this.groupBox4.Enabled = false;
			this.groupBox4.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.groupBox4.Location = new System.Drawing.Point(12, 98);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(447, 239);
			this.groupBox4.TabIndex = 17;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Loaded Arsenal";
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
			this.deckListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.deckListBox1_DrawItem);
			this.deckListBox.SelectedIndexChanged += new System.EventHandler(this.deckListBox1_SelectedIndexChanged);
			// 
			// arsenalListBox
			// 
			this.arsenalListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.arsenalListBox.Controls.Add(this.label6);
			this.arsenalListBox.Controls.Add(this.label1);
			this.arsenalListBox.Controls.Add(this.button7);
			this.arsenalListBox.Controls.Add(this.button2);
			this.arsenalListBox.Controls.Add(this.partnerLock);
			this.arsenalListBox.Controls.Add(this.button6);
			this.arsenalListBox.Controls.Add(this.button5);
			this.arsenalListBox.Controls.Add(this.savedArsenalListBox);
			this.arsenalListBox.Enabled = false;
			this.arsenalListBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.arsenalListBox.Location = new System.Drawing.Point(458, 98);
			this.arsenalListBox.Name = "arsenalListBox";
			this.arsenalListBox.Size = new System.Drawing.Size(433, 651);
			this.arsenalListBox.TabIndex = 1;
			this.arsenalListBox.TabStop = false;
			this.arsenalListBox.Text = "Arsenal List";
			this.arsenalListBox.Enter += new System.EventHandler(this.arsenalListBox_Enter);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label6.Location = new System.Drawing.Point(240, 95);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(163, 15);
			this.label6.TabIndex = 28;
			this.label6.Text = "Click Right Stick on Gamepad";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(240, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(153, 15);
			this.label1.TabIndex = 12;
			this.label1.Text = "Hotkey \"T\" on Keyboard OR";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// button7
			// 
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button7.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.button7.Location = new System.Drawing.Point(240, 564);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(187, 23);
			this.button7.TabIndex = 27;
			this.button7.Text = "Refresh Arsenal List";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.button2.Location = new System.Drawing.Point(240, 593);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(187, 23);
			this.button2.TabIndex = 26;
			this.button2.Text = "Open Arsenal Folder";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
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
			// button6
			// 
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
			this.button6.Location = new System.Drawing.Point(240, 622);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(187, 23);
			this.button6.TabIndex = 24;
			this.button6.Text = "Delete Arsenal";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button5
			// 
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.button5.Location = new System.Drawing.Point(240, 29);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(187, 23);
			this.button5.TabIndex = 23;
			this.button5.Text = "Load Arsenal";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// savedArsenalListBox
			// 
			this.savedArsenalListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.savedArsenalListBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.savedArsenalListBox.FormattingEnabled = true;
			this.savedArsenalListBox.ItemHeight = 15;
			this.savedArsenalListBox.Location = new System.Drawing.Point(6, 29);
			this.savedArsenalListBox.Name = "savedArsenalListBox";
			this.savedArsenalListBox.Size = new System.Drawing.Size(228, 619);
			this.savedArsenalListBox.TabIndex = 0;
			// 
			// groupBox6
			// 
			this.groupBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.groupBox6.Controls.Add(this.labelSkillDescription);
			this.groupBox6.Controls.Add(this.labelSkillUse);
			this.groupBox6.Controls.Add(this.labelSkillStrength);
			this.groupBox6.Controls.Add(this.labelSkillCost);
			this.groupBox6.Controls.Add(this.labelSkilLRange);
			this.groupBox6.Controls.Add(this.label24);
			this.groupBox6.Controls.Add(this.label23);
			this.groupBox6.Controls.Add(this.label22);
			this.groupBox6.Controls.Add(this.labelSkillSchool);
			this.groupBox6.Controls.Add(this.labelSkillID);
			this.groupBox6.Controls.Add(this.labelSkillName);
			this.groupBox6.Controls.Add(this.label11);
			this.groupBox6.Controls.Add(this.textBox1);
			this.groupBox6.Controls.Add(this.button13);
			this.groupBox6.Controls.Add(this.button12);
			this.groupBox6.Controls.Add(this.editorList);
			this.groupBox6.Enabled = false;
			this.groupBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox6.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.groupBox6.Location = new System.Drawing.Point(12, 330);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(447, 245);
			this.groupBox6.TabIndex = 27;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Quick Arsenal Editor";
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
			this.labelSkillDescription.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
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
			this.labelSkillCost.Click += new System.EventHandler(this.labelSkillCost_Click);
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
			this.labelSkillSchool.Click += new System.EventHandler(this.label21_Click);
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
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.textBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.textBox1.Location = new System.Drawing.Point(268, 81);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(173, 23);
			this.textBox1.TabIndex = 31;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// button13
			// 
			this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button13.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.button13.Location = new System.Drawing.Point(218, 51);
			this.button13.Name = "button13";
			this.button13.Size = new System.Drawing.Size(223, 23);
			this.button13.TabIndex = 28;
			this.button13.Text = "Reset Selected";
			this.button13.UseVisualStyleBackColor = true;
			this.button13.Click += new System.EventHandler(this.button13_Click);
			// 
			// button12
			// 
			this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button12.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.button12.Location = new System.Drawing.Point(218, 22);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(223, 23);
			this.button12.TabIndex = 27;
			this.button12.Text = "Replace Skill";
			this.button12.UseVisualStyleBackColor = true;
			this.button12.Click += new System.EventHandler(this.button12_Click);
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
			this.editorList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.editorList_DrawItem);
			this.editorList.SelectedIndexChanged += new System.EventHandler(this.editorList_SelectedIndexChanged);
			// 
			// GamepadWorker
			// 
			this.GamepadWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.GamepadWorker_DoWork_1);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.schoolFilterCheckedListBox);
			this.groupBox3.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.groupBox3.Location = new System.Drawing.Point(12, 581);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(440, 165);
			this.groupBox3.TabIndex = 28;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Filter Settings";
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
			this.schoolFilterCheckedListBox.Size = new System.Drawing.Size(86, 90);
			this.schoolFilterCheckedListBox.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.ClientSize = new System.Drawing.Size(904, 761);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox6);
			this.Controls.Add(this.arsenalListBox);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label9);
			this.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.RightToLeftLayout = true;
			this.Text = "Nuion\'s PD Helper Extended V2.7 (HotkeyUpdate)";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.schoolNumeric)).EndInit();
			this.arsenalListBox.ResumeLayout(false);
			this.arsenalListBox.PerformLayout();
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button3;
        private Button button4;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label8;
        private Label label9;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private GroupBox arsenalListBox;
        private ListBox deckListBox;
        private Button button6;
        private Button button5;
        private ListBox savedArsenalListBox;
        private GroupBox groupBox6;
        private Button button13;
        private ListBox editorList;
        private Button button12;
        private ComboBox arsenalDropdown;
        private TextBox textBox1;
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
        private Button button2;
        private Label label12;
        private Button button7;
        private System.ComponentModel.BackgroundWorker GamepadWorker;
        private Label label1;
        private Label label6;
		private GroupBox groupBox3;
		private CheckedListBox schoolFilterCheckedListBox;
	}
}