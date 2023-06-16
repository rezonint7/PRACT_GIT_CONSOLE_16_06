namespace GIT_CONSOLE.Classes
{
    public class Simplereplacement
    {
        private static Dictionary<string, int> getDictionary (string KeyFile)
        {
            var diction = new Dictionary<string, int>();
            string[] key = FileWork.ReadFile(KeyFile).Split("\n");
            for (int i = 0; i < key.Length; i++)
            {
                var split = key[i].Split('-');

                diction.Add(split[0], Convert.ToInt32(split[1]));
            }
            return diction;
        }

        public static void Encrypt (string KeyFile, string FileSR) //Шифровка
        {
            var work = getDictionary(KeyFile);
            string word = FileWork.ReadFile(FileSR);
            for (int i = 0; i < word.Length; i++)
            {
                
            }
        }
        public static void Decipher (string KeyFile, string FileSR) //Расшифровка
        {
            var work = getDictionary(KeyFile);
            string word = FileWork.ReadFile(FileSR);

        }

    }
}
//FileWork.ReadFile("***")