using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIT_CONSOLE.Classes
{
    public static class Cesar
    {
        const string alfabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

        public static string Crypt (int key, string input)
        {
            input = input.ToUpper();
            var alfabetLen = alfabet.Length;
            var output = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (alfabet.IndexOf(input[i]) < 0)
                {
                    output += input[i].ToString();
                } else
                {
                    var codeIndex = (alfabetLen + alfabet.IndexOf(input[i]) + key) % alfabetLen;
                    output += alfabet[codeIndex];
                }
            }
            return output;
        }
        public static string Encrypt (int key, string input) => Crypt(key, input);
        public static string Decrypt (int key, string input) => Crypt(-key, input);

    }
}
