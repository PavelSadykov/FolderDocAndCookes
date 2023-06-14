
using System;
using System.IO;

namespace Задание_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeName = typeof(long).FullName;
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string cookiesPath = Environment.GetFolderPath(Environment.SpecialFolder.Cookies);

            string output = $"Тип: {typeName}\n" +
                            $"Папка 'Документы': {documentsPath}\n" +
                            $"Папка 'Cookies': {cookiesPath}";

            File.WriteAllText("output.txt", output);

            Console.WriteLine("Результаты сохранены в файл 'output.txt'.");
        }
    }
}

