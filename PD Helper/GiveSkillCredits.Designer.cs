namespace PD_Helper
{
    partial class GiveSkillCredits
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label8 = new Label();
            maxSkillsButton = new Button();
            label5 = new Label();
            maxCreditsButton = new Button();
            label1 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(33, 33, 33);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(maxSkillsButton);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(maxCreditsButton);
            groupBox1.ForeColor = SystemColors.ScrollBar;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(229, 165);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Get Resources";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 34);
            label3.Name = "label3";
            label3.Size = new Size(181, 15);
            label3.TabIndex = 6;
            label3.Text = "2. Click both buttons below once";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ScrollBar;
            label8.Location = new Point(6, 100);
            label8.Name = "label8";
            label8.Size = new Size(163, 15);
            label8.TabIndex = 11;
            label8.Text = "Fix for skills not showing up:";
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
            maxSkillsButton.Click += maxSkillsButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Aquamarine;
            label5.Location = new Point(6, 115);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 8;
            label5.Text = "1. Go to shop";
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
            maxCreditsButton.Click += maxCreditsButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Aquamarine;
            label1.Location = new Point(6, 130);
            label1.Name = "label1";
            label1.Size = new Size(149, 15);
            label1.TabIndex = 12;
            label1.Text = "2. Sell one \"Phantom Dust\"";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Aquamarine;
            label2.Location = new Point(6, 145);
            label2.Name = "label2";
            label2.Size = new Size(211, 15);
            label2.TabIndex = 13;
            label2.Text = "FOR MODDING: Sell the highest ID skill";
            // 
            // GiveSkillCredits
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            ClientSize = new Size(253, 193);
            Controls.Add(groupBox1);
            ForeColor = SystemColors.ScrollBar;
            Name = "GiveSkillCredits";
            Text = "Give Skills and Credits";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label8;
        private Button maxSkillsButton;
        private Label label5;
        private Button maxCreditsButton;
        private Label label2;
        private Label label1;
    }
}