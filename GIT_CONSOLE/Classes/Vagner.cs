using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIT_CONSOLE.Classes
{
    public static class Vagner
    {
        private static readonly char[] alphabet = new char[]{ 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И','Й', 'К', 'Л', 'М', 'Н','О',
            'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ',
            'Э', 'Ю', 'Я', ' ', '1', '2', '3', '4', '5', '6', '7','8', '9', '0' };

        private static readonly int alphabetLength = alphabet.Length;
        public static string Encrypt (string input)
        {
            string keycode = Generate_Keycode(input.Length, 100);

            input = input.ToUpper();
            keycode = keycode.ToUpper();

            string result = "";

            int keyword_index = 0;
            foreach(var symbol in input)
            {
                int index = (Array.IndexOf(alphabet, symbol) +  Array.IndexOf(alphabet, keycode[keyword_index])) % alphabetLength;
                result += alphabet[index];
                keyword_index++;

                if ((keyword_index + 1) == keycode.Length) keyword_index = 0;
            }
            return result;
        }
        public static string Decrypt (string input)
        {
            string keycode = Generate_Keycode(input.Length, 100);

            input = input.ToUpper();
            keycode = keycode.ToUpper();

            string result = "";
            int keyword_index = 0;
            foreach (char symbol in input)
            {
                int index = (Array.IndexOf(alphabet, symbol) + alphabetLength - Array.IndexOf(alphabet, keycode[keyword_index])) % alphabetLength;
                result += alphabet[index];
                keyword_index++;

                if ((keyword_index + 1) == keycode.Length) keyword_index = 0;
            }

            return result;
        }

        private static string Generate_Keycode (int length, int startSeed)
        {
            var random = new Random(startSeed);
            string result = "";

            for(int i = 0; i < length; i++) result += alphabet[random.Next(0, alphabetLength)];
            return result;
        }
    }
}
