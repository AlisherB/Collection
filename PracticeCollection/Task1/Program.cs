using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task1
{
    class Program
    {
        /*
         1.	Удалить все нечетные элементы списка ArrayList
         */
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            Write("Введите количество элементов: ");
            int size = Convert.ToInt32(ReadLine());
            for(int i = 0; i < size; i++)
            {
                list.Add(i);
                Write(list[i] + " ");
            }
            WriteLine();
            ArrayList newList = new ArrayList();
            for (int i = 0; i < size; i++)
            {
                if (i % 2 == 0)
                {
                    newList.Add(list[i]);
                }
            }
            list.Clear();
            WriteLine("Четные элементы:");
            foreach(var i in newList)
            {
                Write(i + " ");
            }
            ReadLine();
        }
    }
}
