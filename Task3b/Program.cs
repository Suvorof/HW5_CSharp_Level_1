using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3b
{
    // 3.б) Разработать статический класс Message , содержащий следующие статические методы для обработки текста:
    // Удалить из сообщения все слова, которые заканчиваются на заданный символ.
    // Константин Суворов. Санкт-Петербург.

    static class Message
    {
        public static string DeleteSomeWord(string str, char lastSymbol)
        {
            char[] punctuation = { ',', '.' }; // при необходимости - может быть расширен
            string substr = null; // именуем и указываем тип переменной, объект типа string ещё не создан

            string[] str1 = str.Split(); // делаем из str массив строк str1
            for (int i = 0; i < str1.Length; i++) // работатем с каждым элементом массива str1 в цикле for
            {
                char[] a = str1[i].ToCharArray(); // каждый элемент массива str1 разбиваем на символы и формируем из них массив
                if ((a.Length != 1 && a[a.Length - 1] == lastSymbol) |
                    (a.Length != 1 && a[a.Length - 2] == lastSymbol & a[a.Length - 1] == punctuation[0]) |
                    (a.Length != 1 && a[a.Length - 2] == lastSymbol & a[a.Length - 1] == punctuation[1])) // прописываем условия по которому будут удаляться слова
                {
                    str1[i] = string.Empty;
                    substr = string.Join(" ",str1); // склеиваем строку после каждого удаления неудовлетворяющего условию слова
                }
            }
            return substr; // возвращаем результат работы метода
        }

    }

    class Program
    {
        static void Main()
        {
            string result = Message.DeleteSomeWord("сунул грека руку в реку, рак за руку греку цап.", 'у');
            Console.WriteLine($"{result}");
            Console.ReadKey();
        }
    }
}
