using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3c
{
    // 3.в) Разработать статический класс Message , содержащий следующие статические методы для обработки текста:
    // Найти самое длинное слово сообщения.
    // Константин Суворов. Санкт-Петербург.

    static class Message
    {
        public static string LongestWord(string str)
        {
            string wordWithMaxLength = null; // именуем и указываем тип переменной, объект типа string ещё не создан
            int maxLength=0;
            int[] lengthOfString; // именуем и указываем тип переменной, объект типа целочисленного массива ещё не создан

            string[] str1 = str.Split(); // делаем из str массив строк str1
            lengthOfString = new int[str1.Length]; // инициализируем массив lengthOfString
            for (int i = 0; i < str1.Length; i++) // работатем с каждым элементом массива str1 в цикле for
            {
                lengthOfString[i] = str1[i].Length; // заполняем массив значениями длин слов, входящщих в массив str1
                maxLength = lengthOfString.Max(); // используем метод расширения .Max(), чтобы определить максимальное из чисел, вошедших в массив
            }

            for (int j = 0; j < str1.Length; j++) // работатем с каждым элементом массива str1 в цикле for
            {
                if (str1[j].Length == maxLength)
                    wordWithMaxLength += string.Format($"{str1[j]} "); // формируем строку, при условии выполнения вышеописанного условия.
            }
            return wordWithMaxLength; // возвращаем результатт работы метода
        }
    }

    class Program
    {
        static void Main()
        {
            string result = Message.LongestWord("сунул грека руку в реку , рак за руку греку цап .");
            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
