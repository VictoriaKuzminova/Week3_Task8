using System;
using System.Text.RegularExpressions;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            //Проверка на пустоту
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите строку:  ");
                    str = Console.ReadLine();
                    if (String.IsNullOrWhiteSpace(str))
                    {
                        Console.WriteLine("Строка пустая");
                        continue;
                    }
                    break;
                }
                catch { }
            }
            string res = Regex.Replace(str, @"([а-я]+)|([А-Я]+)", "");
            Console.WriteLine("Результат:"+res);
        }
    }
}
