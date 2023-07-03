namespace GIT_CONSOLE.Classes
{
    public class Simplereplacement
    {
        private static Dictionary<string, string> getDictionary (string KeyFile)
        {
            StreamWriter keyF = new StreamWriter (KeyFile);
            keyF.WriteLine("А-01\nБ-02\nВ-03\nГ-04\nД-05\nЕ-06\nЁ-07\nЖ-08\nЗ-09\nИ-10" +
                         "\nЙ-12\nК-13\nЛ-14\nМ-15\nН-16\nО-17\nП-18\nР-19\nС-20\nТ-21\nУ-23\nФ-24" +
                         "\nХ-25\nЦ-26\nЧ-27\nШ-28\nЩ-29\nЬ-30\nЪ-31\nЫ-32\nЭ-34\nЮ-35\nЯ-36\n -11\n_-22\n.-33\n,-44\n" +
                         "а-37\nб-38\nв-39\nг-40\nд-41\nе-42\nё-43\nж-45\nз-46\nи-47" +
                         "\nй-48\nк-49\nл-50\nм-51\nн-52\nо-53\nп-54\nр-56\nс-57\nт-58\nу-59\nф-60" +
                         "\nх-61\nц-62\nч-63\nш-64\nщ-65\nь-67\nъ-68\nы-69\nэ-70\nю-71\nя-72");
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
                result += work[text[i].ToString()];
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