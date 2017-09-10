using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task2
{
    class Program
    {
        /*
        2.	Дана коллекция. Вывести на экран элементы, 
        значение которых больше среднего арифметического всех элементов коллекции. 
        */
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 4, 25, 64, 11, 8, 6, 30, 17, 2 };
            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                Write(list[i] + " ");
                sum += list[i];
            }
            WriteLine();

            double average = sum / list.Count;
            WriteLine("\nСреднее арифметическое всех элементов = " + average);
            WriteLine("\nСписок элементов, значения которых больше " + average + ":\n");
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > average)
                {
                    Write(list[i] + " ");
                }
            }

            ReadLine();
        }
    }
}
