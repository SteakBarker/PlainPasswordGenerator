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
				textBox_Pass.Text = RandomPassword.GeneratePassword((int)numericUpDown_PassLength.Value, LoadSettings());
			} else {
				textBox_Pass.Text = WordedPassword.GeneratePassword((int)numericUpDown_PassLength.Value, LoadSettings());
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

		private PasswordSettings LoadSettings() {
			PasswordSettings settings = 0;

			settings |= (checkBox_UseSpecial.Checked) ? PasswordSettings.useSpecialChars : 0;
			settings |= (checkBox_UseNumbers.Checked) ? PasswordSettings.useNumbers : 0;
			settings |= (checkBox_UseLower.Checked) ? PasswordSettings.useLowercase : 0;
			settings |= (checkBox_UseUpper.Checked) ? PasswordSettings.useUppercase : 0;
			settings |= (checkBox_ReplaceVowels.Checked) ? PasswordSettings.replaceVowels : 0;
			settings |= (checkBox_RandomCaps.Checked) ? PasswordSettings.randomCaps : 0;

			return settings;
		}
	}
}
