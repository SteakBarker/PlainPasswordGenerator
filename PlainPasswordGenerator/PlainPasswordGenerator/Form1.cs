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
        public Form1(){
            InitializeComponent();
			comboBox_Type.Text = "Random";
			GeneratePassword();
        }

        private void numericUpDown_PassLength_ValueChanged(object sender, EventArgs e){

        }

		private void button_Generate_Click(object sender, EventArgs e){
			GeneratePassword();
		}

		private void comboBox_Type_SelectedIndexChanged(object sender, EventArgs e) {
			if(comboBox_Type.SelectedIndex == 0) { //0 is random
				ShowWordedSettings(false);
			} else { //1 is worded
				ShowWordedSettings(true);
			}
		}

		private void GeneratePassword() {
			if (comboBox_Type.SelectedIndex == 0) { //0 is random
				textBox_Pass.Text = RandomPassword.GeneratePassword((int)numericUpDown_PassLength.Value, LoadSettings());
			} else {
				textBox_Pass.Text = WordedPassword.GeneratePassword((int)numericUpDown_PassLength.Value, LoadSettings());
			}
		}

		private void ShowWordedSettings(bool wordedSettings) {
			checkBox_ReplaceVowels.Visible = wordedSettings;
			checkBox_RandomCaps.Visible = wordedSettings;
			checkBox_InsertRandom.Visible = wordedSettings;
			numericUpDown_RandomChars.Visible = wordedSettings;
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
