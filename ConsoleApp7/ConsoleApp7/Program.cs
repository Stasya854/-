using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string inputFile = "F1.txt";
        string outputFile = "F2.txt";

        try
        {
            string[] lines = File.ReadAllLines(inputFile, Encoding.UTF8);

            // Обработка каждой строки текста
            for (int i = 0; i < lines.Length; i++)
            {
                string processedLine = RemovePunctuation(lines[i]);
                lines[i] = processedLine;
            }

            // Запись нового текста в файл F2
            File.WriteAllLines(outputFile, lines, Encoding.UTF8);

            Console.WriteLine("Программа успешно выполнена.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }

        Console.ReadKey();
    }

    static string RemovePunctuation(string input)
    {
        // Используем регулярное выражение для удаления знаков препинания
        string result = Regex.Replace(input, @"[\p{P}-[.]]", "");

        return result;
    }
}

