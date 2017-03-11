using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlainPasswordGenerator {

	[FlagsAttribute]
	enum PasswordSettings {
		useSpecialChars = 1,
		useNumbers = 2,
		useLowercase = 4,
		useUppercase = 8,
		replaceVowels = 16,
		randomCaps = 32,
		insertRandom = 64,
	}

	class RandomPassword {
		public static String GeneratePassword(int length, PasswordSettings settings) {
			string charPool = "";
			charPool += (settings.HasFlag(PasswordSettings.useLowercase)) ? "abcdefghijklmnopqrstuvwxyz" : "";
			charPool += (settings.HasFlag(PasswordSettings.useUppercase)) ? "ABCDEFGHIJKLMNOPQRSTUVWXYZ" : "";
			charPool += (settings.HasFlag(PasswordSettings.useNumbers)) ? "1234567890" : "";
			charPool += (settings.HasFlag(PasswordSettings.useSpecialChars)) ? "!@#$%^&*()" : "";

			Random ran = new Random();

			char[] pass = new char[length];
			for(int i=0; i<length; i++) {
				pass[i] = charPool[ran.Next(charPool.Length)];
			}
			return new String(pass);
		}
	}
}
