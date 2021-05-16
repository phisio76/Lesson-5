using System; //  Дмитрий Павлов 1.Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2 до 10 символов,
using System.Text.RegularExpressions;  // **с использованием регулярных выражений  и с выносом методов в отдельный класс

namespace CorrectLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа проверит корректность ввода логина");
            Console.WriteLine("Должны быть соблюдены следующие условия:"
                        + "\nКорректный логин содержит от 2 до 10 символов;"
                        + "\nПрименимы только буквы латинского алфавита или цифры;"
                        + "\nПервым символом должна быть буква.");
            int count = 3; // количество попыток

            do
            {
                Console.Write("Введите логин: ");
                string login = Console.ReadLine();

                if (Login.CheckLogin(login) && Login.CheckLoginReg(login)) // + регулярные выражения
                {
                    Console.WriteLine("Логин корректен!");
                    break;
                }
                else
                {
                    count--;
                    Console.WriteLine($"Неверный ввод логина. {Environment.NewLine} Осталось попыток: {count}");

                }

            } while (count > 0);



            Console.ReadKey();
        }
    }
}
