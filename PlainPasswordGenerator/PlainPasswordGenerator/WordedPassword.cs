using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlainPasswordGenerator {

	[FlagsAttribute]
	enum WordedPasswordSettings {
		useSpecialChars = 0,
		useNumbers = 1,
		replaceVowels = 2,
		randomCaps = 4,
	}

	class WordedPassword {
		public static String GeneratePassword(int length, WordedPasswordSettings settings) {
			string[] words = ReadAllWords();
			Random ran = new Random();

			string pass = "";
			int tries = 1000;
			while (tries>0) {
				string word = words[ran.Next(words.Length)];
				if (word.Length + pass.Length < length) {
					pass += word;
					tries = 1000;
				} else {tries--;}
			}
			string charPool = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
			charPool += (settings.HasFlag(WordedPasswordSettings.useNumbers)) ? "1234567890" : "";
			charPool += (settings.HasFlag(WordedPasswordSettings.useSpecialChars)) ? "!@#$%^&*()" : "";

			for (int i=pass.Length; i<length; i++) {
				pass = pass.Insert(ran.Next(pass.Length), ""+charPool[ran.Next(charPool.Length)]);
			}

			return pass;
		}

		private static string[] ReadAllWords() {
			TextReader reader = new StreamReader(@"EnglishWords.txt");
			List<string> words = new List<string>();
			string line = "";
			while( (line = reader.ReadLine())!=null){
				if (line.Length > 2) { words.Add(line); }
			}
			return words.ToArray();
		}
	}
}
