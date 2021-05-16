using System; // папка метода: CorrectLogin
using System.Text.RegularExpressions;

namespace CorrectLogin
{
    class Login
    {
        static public bool CheckLogin(string login) // Метод проверяет количество символов в логине. Д.б. от 2 до 10
        {
            int length = login.Length;
            if (length >= 2 && length <= 10)
            {
                bool check = true;
                char letter = login[0];
                if (Char.IsDigit(letter))
                    return false;
                for (int i = 1; i < length; i++)
                {
                    letter = login[i];
                    if (!(Char.IsDigit(letter) || IsLatinLetter(letter)))
                    {
                        check = false;
                        break;
                    }
                }
                if (check)
                    return true;
            }
            return false;
        }
        public static bool IsLatinLetter(char letter) // Метод проверяте соответствие требованиям: цифры или латинские буквы
        {
            int num = letter;
            if ((num >= 65 && num <= 90) || (num >= 97 && num <= 122))
                return true;
            else
                return false;
        }
        static public bool CheckLoginReg(string login) // Метод проверяет соответствие логина требованиям с применением регулярных выражений
        {
            char letter = login[0];
            {
                if (Char.IsDigit(letter))
                    return false;
                if (!Regex.IsMatch(login, @"[a-zA-Z0-9]")) // любой символ из указанных в скобках [...] применим
                    return false;
            }
            return true;
        }
    }
}