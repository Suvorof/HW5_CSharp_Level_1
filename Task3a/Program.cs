using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3a
{
    // 3) Разработать статический класс Message , содержащий следующие статические методы для обработки текста:
    // а) Вывести только те слова сообщения, которые содержат не более n букв.
    // Константин Суворов. Санкт-Петербург.

    static class Message
    {
        public static void LeterCounter(string str, int numberOfleter)
        {
            string[] str1 = str.Split(); // делаем из str массив строк str1
            for (int i = 0; i < str1.Length; i++) // работатем с каждым элементом массива str1 в цикле for
            {
                char[] a = str1[i].ToCharArray();
                if (a.Length <= numberOfleter) // длинна слов не должнв быть больше некоторго numberOfleter (numberOfleter - кол-во букв)
                {
                    string substr = new string(a); // формируем строку из всех элементов массива, которые удовлетворяют вышеописанному условию
                    Console.Write($"{substr} | "); // выводим в консоль сформированную строку.
                }
            }
        }
    }


    class Program
    {
        static void Main()
        {
            string firstStr = "сунул грека руку в реку, рак за руку греку цап";
            Message.LeterCounter(firstStr, 3);
            Console.ReadKey();
        }
    }
}
