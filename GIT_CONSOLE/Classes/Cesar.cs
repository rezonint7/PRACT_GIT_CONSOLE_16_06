using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace GIT_CONSOLE.Classes
{
    public static class Cesar
    {
        const string alfabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        const string alfabetLower = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

        public static string Crypt(int key, string input)
        {
            var alfabetLen = alfabet.Length;
            var output = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (alfabet.IndexOf(input[i]) < 0 && alfabetLower.IndexOf(input[i]) < 0)
                {
                    output += input[i].ToString();
                }
                else
                {
                    if (alfabet.IndexOf(input[i]) < 0)
                    {
                        var codeIndex = (alfabetLen + alfabetLower.IndexOf(input[i]) + key) % alfabetLen;
                        output += alfabetLower[codeIndex];
                    }
                    else
                    {
                        var codeIndex = (alfabetLen + alfabet.IndexOf(input[i]) + key) % alfabetLen;
                        output += alfabet[codeIndex];
                    }
                }
            }
            return output;
        }

        public static string Encrypt(int key, string input) => Crypt(key, input);
        public static string Decrypt(int key, string input) => Crypt(-key, input);

    }
}
