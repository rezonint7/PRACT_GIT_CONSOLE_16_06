namespace GIT_CONSOLE.Classes
{
    public class Simplereplacement
    {
        private static Dictionary<string, string> getDictionary (string KeyFile)
        {
            StreamWriter keyF = new StreamWriter (KeyFile);
            keyF.WriteLine("А-33\nБ-17\nВ-08\nГ-16\nД-02\nЕ-15\nЁ-14\nЖ-13\nЗ-73\nИ-98" +
                         "\nЙ-19\nК-97\nЛ-96\nМ-24\nН-27\nО-47\nП-05\nР-32\nС-93\nТ-03\nУ-99\nФ-26" +
                         "\nХ-66\nЦ-69\nЧ-04\nШ-06\nЩ-36\nЬ-21\nЪ-22\nЫ-23\nЭ-37\nЮ-39\nЯ-18\n -44\n_-88\n.-11\n,-77");
            keyF.Close();
            var diction = new Dictionary<string, string>();
            string[] key = FileWork.ReadFile(KeyFile).Split("\n");
            for (int i = 0; i < key.Length; i++)
            {
                var split = key[i].Split('-');

                diction.Add(split[0], split[1]);
            }
            
            return diction;
            
        }

        public static string Encrypt (string KeyFile, string text) //Шифровка
        {
            var work = getDictionary(KeyFile);
            string result = "";
            for (int i = 0; i < text.Length; i++)
            {
                result += work[text[i].ToString().ToUpper()];
            }
            return result;
        }
        public static string Decipher (string KeyFile, string text) //Расшифровка
        {
            var work = getDictionary(KeyFile);
            string result = "";
            for (int i = 0; i < text.Length; i=i+2)
            {
                string num = text[i].ToString()+text[i+1].ToString();
                var myKey = work.FirstOrDefault(x => x.Value == num).Key;
                result += myKey;
            }
            return result;
        }

    }
}