using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task
{
    class Program
    {
        /*
         1.	Создать коллекцию List <int> . 
         * Вывести на экран позицию и значение элемента, являющегося вторым максимальным значением в коллекции. 
         * Вывести на экран сумму элементов на четных позичиях.
         */
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            
            Write("Введите количество элементов: ");
            int size = Convert.ToInt32(ReadLine());
            Random rand = new Random();
            WriteLine();
            for(int i = 0; i < size; i++)
            {
                list.Add(rand.Next(50));
                Write(list[i] + " ");
            }
            int maxSecond = list[0];
            for(int i = 0; i < size; i++)
            {
                if (list[i] == list.Max())
                    continue;
                else if (list[i] > maxSecond)
                    maxSecond = list[i];
            }
            WriteLine("\n\nВторое максимальное число = " + maxSecond + "[" + list.IndexOf(maxSecond) + "]");
            WriteLine();
            int sum = 0;
            for(int i = 0; i < size; i++)
            {
                if (i % 2 == 0)
                    sum += list[i];
            }
            WriteLine("Сумма элементов на четных позициях = " + sum);
            ReadLine();
        }
    }
}
