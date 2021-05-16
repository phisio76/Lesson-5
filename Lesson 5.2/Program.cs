using System;

namespace ClassMessage
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Дан текст: {Message.text}");

            Console.WriteLine("\nСлова, содержащие не более 5 букв:\n");
            Message.GetWords(5);

            Console.WriteLine();
            Console.WriteLine("\nСлова, оканчивающиеся на 'ы' должны быть удалены: "); // А они не удаляются
            Message.DeleteWord('ы');

            Console.WriteLine();
            Console.WriteLine("\nСамое длинное слово в тексте: " + Message.FindMaxWord());

            Console.WriteLine("\nСтрока StringBuilder из самых длинных слов сообщения: " + Message.LongWordsString());

        }
    }
}
