using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIT_CONSOLE.Classes
{
    public static class Vagner
    {
        public static string Encrypt (string input)
        {
            string input_source = input;
            string text = input.ToUpper();
            string keyword = Generate_Keycode(text.Length, 100).ToUpper();

            string result = "";
            for(int i = 0; i < text.Length; i++)
            {
                var keyChar = keyword[i % keyword.Length];
                if (!char.IsLetter(text[i]))
                {
                    result += text[i];
                    continue;
                }
                result += (char)(((text[i] + keyChar - 2 * 'А') % 32) + 'А');

                Console.WriteLine($"{text[i]} - {text[i] * 1}");
                Console.WriteLine($"{keyChar} - {keyChar * 1}");
            }
            return keepRegister(result, input_source);
        }

        public static string Decrypt (string input)
        {
            string input_source = input;
            string text = input.ToUpper();
            string keyword = Generate_Keycode(text.Length, 100).ToUpper();

            string result = "";
            for (int i = 0; i < text.Length; i++)
            {
                var keyChar = keyword[i % keyword.Length];
                if (!char.IsLetter(text[i]))
                {
                    result += text[i];
                    continue;
                }
                result += (char)(((text[i] - keyChar + 32) % 32) + 'А');
            }
            return keepRegister(result, input_source);
        }

        private static string keepRegister(string text, string source)
        {
            string result = "";
            for(int i = 0; i < text.Length; i++)
            {
                if (char.IsLower(source[i])) result += text[i].ToString().ToLower();
                else result += text[i];
            }
            return result;
        }

        private static string Generate_Keycode (int length, int startSeed)
        {
            const string alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            var random = new Random(startSeed);
            string result = "";

            for(int i = 0; i < length; i++) result += alphabet[random.Next(0, alphabet.Length)];
            return result;
        }
    }
}
