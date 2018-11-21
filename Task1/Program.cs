using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    static class Program
    {
        // 1) Написать статический метод void CreateCharsFile(string filename, int start, int finish), который
        // создает файл содержащий символы из заданного диапазона(от start до finish). Обработать корректно исключения связанные с невозможностью создания файла.
        // Константин Суворов. Санкт-Петербург.

        static void CreateCharsFile(string path, int start, int finish)
        {
            try
            {
                StreamWriter sw = new StreamWriter(path); // создаём файл по пути, сохранённому в переменной path
                for (int i = start; i <= finish; i++) // создаём цикл в диапазоне от 0 до 1000
                {
                    sw.WriteLine(i + " " + (char)i); // пишем строки в файл по правилу номер строки (итерации) + номер преобразованный в тип char.
                }
                sw.Close(); //закрываем файл для возможности работы с ним другим программам
            }
            catch(DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message); // для проверки введите в path @"C:\Users\Konstantin\Desktopp\Somesymbol.txt"
            }
        }


        static void Main()
        {
            Program.CreateCharsFile(@"C:\Users\Konstantin\Desktop\Somesymbol.txt", 0, 1000);
            //Console.ReadKey();
        }
    }
}
