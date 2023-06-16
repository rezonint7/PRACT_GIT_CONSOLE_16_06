using GIT_CONSOLE.Classes;
using System.Text.RegularExpressions;

try
{
    for (;;)
    {
        Console.WriteLine("Введите команду: ");
        string[] rezon = new string[3] { "HELP", "0", "text.txt" }; 
        var rezon_array = Console.ReadLine().ToUpper().Split(' ');

        if (rezon_array.Length == 2)
        {
            rezon[0] = rezon_array[0];
            rezon[2] = rezon_array[1];
        } 
        else
            rezon = rezon_array;

        var text = FileWork.ReadFile(rezon[2]);
        var result = cryptText(rezon[0], rezon[1], text);
        if(result == "") break;
        Console.WriteLine(result);
        FileWork.WriteFile(rezon[2], result);
    }
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

string cryptText (string command, object? arg1 = null, string arg2 = "") => (command, arg1, arg2) switch
{
    ("HELP", _, _) => getHelp(),
    ("CAESAR", _, _) => Cesar.Encrypt(Convert.ToInt32(arg1), arg2),
    ("DECRYPT_CAESAR", _, _) => Cesar.Decrypt(Convert.ToInt32(arg1), arg2),
    ("SUB", _, _) => getHelp(),
    ("DECRYPT_SUB", _, _) => getHelp(),
    ("VIGENERE", _, _) => Vagner.Encrypt(arg2.ToString()),
    ("DECRYPT_VIGENERE", _, _) => Vagner.Decrypt(arg2.ToString()),
    _ => ""
};


string getHelp () => "===ДОСТУПНЫЕ КОМАНДЫ===\r\n" +
    "CAESAR <KEY> <FILE> - выполняет шифровку файла с помощью шифра Цезаря, используя сдвиг KEY\r\n" +
    "DECRYPT CAESAR <KEY> <FILE> - выполняет рассшифровку файла с помощью шифра Цезаря, используя сдвиг KEY;\r\n" +
    "SUB <KEYFILE> <FILE> - выполняет шифровку файла FILE методом подстановки, используя в качестве словаря KEYFILE;\r\n" +
    "DECRYPT SUB <KEYFILE> <FILE> - выполняет рассшифровку файла FILE методом подстановки, используя в качестве словаря KEYFILE;\r\n" +
    "VIGENERE <FILE> - выполняет шифровку файла с помощью метода Виженера, использовать квадрат Виженера;\r\n" +
    "DECRYPT VIGENERE <FILE> - выполняет рассшифровку файла FILE с помощью метода Виженера, использовать квадрат Виженера;";