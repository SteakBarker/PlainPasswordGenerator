using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlainPasswordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown_PassLength_ValueChanged(object sender, EventArgs e){

        }

		private void button_Generate_Click(object sender, EventArgs e){
			if (comboBox_Type.SelectedIndex == 0) { //0 is random
				RandomPasswordSettings settings = 0;
				settings |= (checkBox_UseLower.Checked) ? RandomPasswordSettings.useLowercase : 0;
				settings |= (checkBox_UseUpper.Checked) ? RandomPasswordSettings.useUppercase : 0;
				settings |= (checkBox_UseSpecial.Checked) ? RandomPasswordSettings.useSpecialChars : 0;
				settings |= (checkBox_UseNumbers.Checked) ? RandomPasswordSettings.useNumbers : 0;
				textBox_Pass.Text = RandomPassword.GeneratePassword((int)numericUpDown_PassLength.Value, settings);
			}
		}

		private void comboBox_Type_SelectedIndexChanged(object sender, EventArgs e) {
			if(comboBox_Type.SelectedIndex == 0) { //0 is random
				ShowOnlyRandomSettings(true);
			} else { //1 is worded
				ShowOnlyRandomSettings(false);
			}
		}

		private void ShowOnlyRandomSettings(bool random) {
			checkBox_UseLower.Visible = random;
			checkBox_UseUpper.Visible = random;

			checkBox_ReplaceVowels.Visible = !random;
			checkBox_RandomCaps.Visible = !random;
			numericUpDown_Deviation.Visible = !random;
		}
	}
}
