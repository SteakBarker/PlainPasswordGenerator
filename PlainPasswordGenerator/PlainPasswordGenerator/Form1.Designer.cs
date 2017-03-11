namespace PlainPasswordGenerator
{
    partial class Form1
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
			this.components = new System.ComponentModel.Container();
			this.panel_Settings = new System.Windows.Forms.Panel();
			this.numericUpDown_PassLength = new System.Windows.Forms.NumericUpDown();
			this.toolTip_Maintip = new System.Windows.Forms.ToolTip(this.components);
			this.numericUpDown_Deviation = new System.Windows.Forms.NumericUpDown();
			this.checkBox_UseSpecial = new System.Windows.Forms.CheckBox();
			this.flowLayoutPanel_Settings = new System.Windows.Forms.FlowLayoutPanel();
			this.checkBox_ReplaceVowels = new System.Windows.Forms.CheckBox();
			this.checkBox_RandomCaps = new System.Windows.Forms.CheckBox();
			this.button_Generate = new System.Windows.Forms.Button();
			this.textBox_Pass = new System.Windows.Forms.TextBox();
			this.checkBox_UseLower = new System.Windows.Forms.CheckBox();
			this.checkBox_UseUpper = new System.Windows.Forms.CheckBox();
			this.comboBox_Type = new System.Windows.Forms.ComboBox();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.checkBox_UseNumbers = new System.Windows.Forms.CheckBox();
			this.panel_Settings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PassLength)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Deviation)).BeginInit();
			this.flowLayoutPanel_Settings.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel_Settings
			// 
			this.panel_Settings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.panel_Settings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel_Settings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel_Settings.Controls.Add(this.flowLayoutPanel1);
			this.panel_Settings.Controls.Add(this.button_Generate);
			this.panel_Settings.Controls.Add(this.flowLayoutPanel_Settings);
			this.panel_Settings.Location = new System.Drawing.Point(12, 12);
			this.panel_Settings.Name = "panel_Settings";
			this.panel_Settings.Size = new System.Drawing.Size(206, 345);
			this.panel_Settings.TabIndex = 0;
			// 
			// numericUpDown_PassLength
			// 
			this.numericUpDown_PassLength.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.numericUpDown_PassLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.numericUpDown_PassLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numericUpDown_PassLength.Location = new System.Drawing.Point(3, 3);
			this.numericUpDown_PassLength.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
			this.numericUpDown_PassLength.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
			this.numericUpDown_PassLength.Name = "numericUpDown_PassLength";
			this.numericUpDown_PassLength.Size = new System.Drawing.Size(187, 47);
			this.numericUpDown_PassLength.TabIndex = 1;
			this.toolTip_Maintip.SetToolTip(this.numericUpDown_PassLength, "Password Length: How long you\'d like your password to be");
			this.numericUpDown_PassLength.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
			this.numericUpDown_PassLength.ValueChanged += new System.EventHandler(this.numericUpDown_PassLength_ValueChanged);
			// 
			// toolTip_Maintip
			// 
			this.toolTip_Maintip.ToolTipTitle = "Description";
			// 
			// numericUpDown_Deviation
			// 
			this.numericUpDown_Deviation.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numericUpDown_Deviation.Location = new System.Drawing.Point(3, 56);
			this.numericUpDown_Deviation.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDown_Deviation.Name = "numericUpDown_Deviation";
			this.numericUpDown_Deviation.Size = new System.Drawing.Size(187, 47);
			this.numericUpDown_Deviation.TabIndex = 1;
			this.toolTip_Maintip.SetToolTip(this.numericUpDown_Deviation, "Deviation: How many chars the password can be off. Only used for worded passwords" +
        "");
			// 
			// checkBox_UseSpecial
			// 
			this.checkBox_UseSpecial.AutoSize = true;
			this.checkBox_UseSpecial.Location = new System.Drawing.Point(3, 30);
			this.checkBox_UseSpecial.Name = "checkBox_UseSpecial";
			this.checkBox_UseSpecial.Size = new System.Drawing.Size(91, 17);
			this.checkBox_UseSpecial.TabIndex = 1;
			this.checkBox_UseSpecial.Text = "Special Chars";
			this.checkBox_UseSpecial.UseVisualStyleBackColor = true;
			// 
			// flowLayoutPanel_Settings
			// 
			this.flowLayoutPanel_Settings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flowLayoutPanel_Settings.Controls.Add(this.comboBox_Type);
			this.flowLayoutPanel_Settings.Controls.Add(this.checkBox_UseSpecial);
			this.flowLayoutPanel_Settings.Controls.Add(this.checkBox_UseNumbers);
			this.flowLayoutPanel_Settings.Controls.Add(this.checkBox_UseLower);
			this.flowLayoutPanel_Settings.Controls.Add(this.checkBox_UseUpper);
			this.flowLayoutPanel_Settings.Controls.Add(this.checkBox_ReplaceVowels);
			this.flowLayoutPanel_Settings.Controls.Add(this.checkBox_RandomCaps);
			this.flowLayoutPanel_Settings.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel_Settings.Location = new System.Drawing.Point(4, 127);
			this.flowLayoutPanel_Settings.Name = "flowLayoutPanel_Settings";
			this.flowLayoutPanel_Settings.Size = new System.Drawing.Size(197, 159);
			this.flowLayoutPanel_Settings.TabIndex = 2;
			// 
			// checkBox_ReplaceVowels
			// 
			this.checkBox_ReplaceVowels.AutoSize = true;
			this.checkBox_ReplaceVowels.Location = new System.Drawing.Point(3, 122);
			this.checkBox_ReplaceVowels.Name = "checkBox_ReplaceVowels";
			this.checkBox_ReplaceVowels.Size = new System.Drawing.Size(103, 17);
			this.checkBox_ReplaceVowels.TabIndex = 1;
			this.checkBox_ReplaceVowels.Text = "Replace Vowels";
			this.checkBox_ReplaceVowels.UseVisualStyleBackColor = true;
			// 
			// checkBox_RandomCaps
			// 
			this.checkBox_RandomCaps.AutoSize = true;
			this.checkBox_RandomCaps.Location = new System.Drawing.Point(191, 3);
			this.checkBox_RandomCaps.Name = "checkBox_RandomCaps";
			this.checkBox_RandomCaps.Size = new System.Drawing.Size(93, 17);
			this.checkBox_RandomCaps.TabIndex = 1;
			this.checkBox_RandomCaps.Text = "Random Caps";
			this.checkBox_RandomCaps.UseVisualStyleBackColor = true;
			// 
			// button_Generate
			// 
			this.button_Generate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.button_Generate.Location = new System.Drawing.Point(4, 292);
			this.button_Generate.Name = "button_Generate";
			this.button_Generate.Size = new System.Drawing.Size(197, 48);
			this.button_Generate.TabIndex = 1;
			this.button_Generate.Text = "Generate!";
			this.button_Generate.UseVisualStyleBackColor = true;
			this.button_Generate.Click += new System.EventHandler(this.button_Generate_Click);
			// 
			// textBox_Pass
			// 
			this.textBox_Pass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_Pass.Location = new System.Drawing.Point(224, 12);
			this.textBox_Pass.Multiline = true;
			this.textBox_Pass.Name = "textBox_Pass";
			this.textBox_Pass.ReadOnly = true;
			this.textBox_Pass.Size = new System.Drawing.Size(685, 345);
			this.textBox_Pass.TabIndex = 1;
			this.textBox_Pass.Text = "PasswordExample_0123";
			this.textBox_Pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// checkBox_UseLower
			// 
			this.checkBox_UseLower.AutoSize = true;
			this.checkBox_UseLower.Checked = true;
			this.checkBox_UseLower.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox_UseLower.Location = new System.Drawing.Point(3, 76);
			this.checkBox_UseLower.Name = "checkBox_UseLower";
			this.checkBox_UseLower.Size = new System.Drawing.Size(100, 17);
			this.checkBox_UseLower.TabIndex = 2;
			this.checkBox_UseLower.Text = "Use Lowercase";
			this.checkBox_UseLower.UseVisualStyleBackColor = true;
			// 
			// checkBox_UseUpper
			// 
			this.checkBox_UseUpper.AutoSize = true;
			this.checkBox_UseUpper.Checked = true;
			this.checkBox_UseUpper.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox_UseUpper.Location = new System.Drawing.Point(3, 99);
			this.checkBox_UseUpper.Name = "checkBox_UseUpper";
			this.checkBox_UseUpper.Size = new System.Drawing.Size(100, 17);
			this.checkBox_UseUpper.TabIndex = 2;
			this.checkBox_UseUpper.Text = "Use Uppercase";
			this.checkBox_UseUpper.UseVisualStyleBackColor = true;
			// 
			// comboBox_Type
			// 
			this.comboBox_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_Type.FormattingEnabled = true;
			this.comboBox_Type.Items.AddRange(new object[] {
            "Random",
            "Worded"});
			this.comboBox_Type.Location = new System.Drawing.Point(3, 3);
			this.comboBox_Type.Name = "comboBox_Type";
			this.comboBox_Type.Size = new System.Drawing.Size(182, 21);
			this.comboBox_Type.TabIndex = 2;
			this.comboBox_Type.SelectedIndexChanged += new System.EventHandler(this.comboBox_Type_SelectedIndexChanged);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.numericUpDown_PassLength);
			this.flowLayoutPanel1.Controls.Add(this.numericUpDown_Deviation);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 3);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(197, 118);
			this.flowLayoutPanel1.TabIndex = 3;
			// 
			// checkBox_UseNumbers
			// 
			this.checkBox_UseNumbers.AutoSize = true;
			this.checkBox_UseNumbers.Checked = true;
			this.checkBox_UseNumbers.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox_UseNumbers.Location = new System.Drawing.Point(3, 53);
			this.checkBox_UseNumbers.Name = "checkBox_UseNumbers";
			this.checkBox_UseNumbers.Size = new System.Drawing.Size(90, 17);
			this.checkBox_UseNumbers.TabIndex = 2;
			this.checkBox_UseNumbers.Text = "Use Numbers";
			this.checkBox_UseNumbers.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(921, 369);
			this.Controls.Add(this.textBox_Pass);
			this.Controls.Add(this.panel_Settings);
			this.Name = "Form1";
			this.Text = "PlainPasswordGenerator";
			this.panel_Settings.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PassLength)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Deviation)).EndInit();
			this.flowLayoutPanel_Settings.ResumeLayout(false);
			this.flowLayoutPanel_Settings.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Settings;
        private System.Windows.Forms.NumericUpDown numericUpDown_PassLength;
        private System.Windows.Forms.ToolTip toolTip_Maintip;
		private System.Windows.Forms.NumericUpDown numericUpDown_Deviation;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Settings;
		private System.Windows.Forms.CheckBox checkBox_UseSpecial;
		private System.Windows.Forms.CheckBox checkBox_ReplaceVowels;
		private System.Windows.Forms.CheckBox checkBox_RandomCaps;
		private System.Windows.Forms.Button button_Generate;
		private System.Windows.Forms.TextBox textBox_Pass;
		private System.Windows.Forms.CheckBox checkBox_UseLower;
		private System.Windows.Forms.CheckBox checkBox_UseUpper;
		private System.Windows.Forms.ComboBox comboBox_Type;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.CheckBox checkBox_UseNumbers;
	}
}

