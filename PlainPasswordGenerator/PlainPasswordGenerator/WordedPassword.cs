using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlainPasswordGenerator {

	class WordedPassword {
		public static String GeneratePassword(int length, int randomChars, PasswordSettings settings) {

			//Get Words
			//Replace Vowels
			//Random Caps
			//  insert random chars
			//  add random chars
			//Last two steps use the same number of random chars.


			string[] words = ReadAllWords();
			Random ran = new Random();

			string pass = "";
			int tries = 1000;
			while (tries>0) { //There has got to be a better way to do this, right?
				string word = words[ran.Next(words.Length)];
				if (word.Length + pass.Length <= length) {
					pass += word;
					tries = 1000;
				} else {tries--;}
			}

			if (settings.HasFlag(PasswordSettings.replaceVowels) && settings.HasFlag(PasswordSettings.useNumbers)) {
				for (int i = 0; i < pass.Length; i++) {
					char c = pass[i];
					if ("aeio".IndexOf(c) >= 0 && ran.NextDouble() > .5f) {
						//a->4 or @, e -> 3, i -> 1 or !, o -> 0

						char replacedChar = c;

						if (c == 'a') {
							replacedChar = (settings.HasFlag(PasswordSettings.useSpecialChars) && ran.NextDouble() > .5f) ? '@' : '4';
						}else if(c == 'e') {
							replacedChar = '3';
						}else if(c == 'i') {
							replacedChar = (settings.HasFlag(PasswordSettings.useSpecialChars) && ran.NextDouble() > .5f) ? '!' : '1';
						}else if(c == 'o') {
							replacedChar = '0';
						}

						pass = pass.Remove(i, 1);
						pass = pass.Insert(i, replacedChar+"");
					}
				}
			}

			if (settings.HasFlag(PasswordSettings.randomCaps)) {
				for (int i = 0; i < pass.Length; i++) {
					char c = pass[i];
					if ("abcdefghijklmnopqrstuvwxyz".IndexOf(c) >= 0 && ran.NextDouble() > .5f) {
						pass = pass.Remove(i, 1);
						pass = pass.Insert(i, (c+"").ToUpper());
					}
				}
			}

			string charPool = "";
			charPool += (settings.HasFlag(PasswordSettings.useLowercase)) ? "abcdefghijklmnopqrstuvwxyz" : "";
			charPool += (settings.HasFlag(PasswordSettings.useUppercase)) ? "ABCDEFGHIJKLMNOPQRSTUVWXYZ" : "";
			charPool += (settings.HasFlag(PasswordSettings.useNumbers)) ? "1234567890" : "";
			charPool += (settings.HasFlag(PasswordSettings.useSpecialChars)) ? "!@#$%^&*()" : "";

			for(int i=0; i<randomChars; i++) {
				if(settings.HasFlag(PasswordSettings.insertRandom) && ran.NextDouble() > .6f) { //.6 because we want random inserts less likley
					pass = pass.Insert(ran.Next(pass.Length), charPool[ran.Next(charPool.Length)]+"");
				} else {
					pass = pass.Insert(((ran.NextDouble() > .5f) ? 0 : pass.Length), charPool[ran.Next(charPool.Length)] + "");
				}
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
