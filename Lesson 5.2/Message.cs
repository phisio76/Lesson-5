using System; //  Папка класса Message
using System.Text;

namespace ClassMessage // Класс Message, вынесен в отдельный файл
{
    class Message
    {
        static public string text;

        static Message()
        {
            text = "Русским феминисткам даже не было нужды объявлять мужчинам войну," +
                "потому что мужчины добровольно сдались более образованному, более культурному," +
                "более умному, более работящему и менее пьющему полу." +
                " Жельвис В. Эти странные русские ";
        }
        static public void GetWords(int len) // Выводит слова сообщения, которые содержат не более n букв
        {
            string[] words = text.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t' });
            foreach (string word in words)
            {
                if (word == "")
                    continue;
                if (word.Length <= len)
                    Console.Write(word + " ");
            }
        }
        static public void DeleteWord(char ch) // Удаляет из сообщения все слова, которые заканчиваются на заданный символ
        {
            string[] words = text.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t' });
            foreach (string word in words)
            {
                if (word == "")
                    continue;
                if (word[word.Length - 1] == ch)
                {
                    Console.Write(word + " ");
                    text.Replace(word, "");
                }
            }
        }
        static public string FindMaxWord() // Находит самое длинное слово.
        {
            string[] words = text.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t' });
            string maxWord = words[0];
            int max = words[0].Length;

            foreach (string word in words)
            {
                if (word.Length > max)
                {
                    max = word.Length;
                    maxWord = word;
                }
            }
            return maxWord;
        }
        static public StringBuilder LongWordsString() // Формирует строку StringBuilder из самых длинных слов сообщения.
        {
            string[] words = text.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t' });
            StringBuilder result = new StringBuilder();
            int max = Message.FindMaxWord().Length;
            foreach (string word in words)
            {
                if (word.Length == max)
                {
                    result.Append(word.ToLower() + " ");
                }
            }
            return result;
        }
    }
}