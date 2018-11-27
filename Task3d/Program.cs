using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3d
{
    // 3.в) Разработать статический класс Message , содержащий следующие статические методы для обработки текста:
    // Сформировать строку с помощью StringBuilder из самых длинных слов.
    // Константин Суворов. Санкт-Петербург.

    static class Message
    {
        public static string LongestWordWithHelpStrBuilder()
        {
            // Решение по сути является решение 3c, только данные вводятся не как параметр метода, а поступают из объекта StringBuilder
            string str = string.Empty;
            StringBuilder a = new StringBuilder("сунул грека руку в реку , рак за руку греку цап .");
            str = a.ToString();

            string wordWithMaxLength = null;
            int maxLength = 0;
            int[] lengthOfString;

            string[] str1 = str.Split();
            lengthOfString = new int[str1.Length];
            for (int i = 0; i < str1.Length; i++)
            {
                lengthOfString[i] = str1[i].Length;
                maxLength = lengthOfString.Max();
            }

            for (int j = 0; j < str1.Length; j++)
            {
                if (str1[j].Length == maxLength)
                    wordWithMaxLength += string.Format($"{str1[j]} ");
            }
            return wordWithMaxLength;
        }
    }

    class Program
    {
        static void Main()
        {
            string result = Message.LongestWordWithHelpStrBuilder();
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
