using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlainPasswordGenerator {

	[FlagsAttribute]
	enum RandomPasswordSettings {
		useLowercase = 0,
		useUppercase = 1,
		useNumbers = 2,
		useSpecialChars = 4,
	}

	class RandomPassword {
		public static String GeneratePassword(int length, RandomPasswordSettings settings) {
			string charPool = "";
			charPool += (settings.HasFlag(RandomPasswordSettings.useLowercase)) ? "abcdefghijklmnopqrstuvwxyz" : "";
			charPool += (settings.HasFlag(RandomPasswordSettings.useUppercase)) ? "ABCDEFGHIJKLMNOPQRSTUVWXYZ" : "";
			charPool += (settings.HasFlag(RandomPasswordSettings.useNumbers)) ? "1234567890" : "";
			charPool += (settings.HasFlag(RandomPasswordSettings.useSpecialChars)) ? "!@#$%^&*()" : "";

			Random ran = new Random();

			char[] pass = new char[length];
			for(int i=0; i<length; i++) {
				pass[i] = charPool[ran.Next(charPool.Length)];
			}
			return new String(pass);
		}
	}
}
