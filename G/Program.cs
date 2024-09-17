using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вариант 3
            List<int>ints = new List<int>();
            int x = 0;
            for (int i = -14; i < 25; i+= 6) // Цикл для заполнения списка + вывод списка
            {
                ints.Add(i);
                Console.Write(ints[x] + " ");
                x++;  
            }
            Console.WriteLine();
            for (int i = 0; i < ints.Count; i++)  // Цикл для удаления значений в диапозоне [-5 10)
            {
                if (ints[i] >= -5 && ints[i] < 10) 
                {
                    Console.Write(ints[i] + " ");
                    ints.RemoveAt(i);
                    i--;
                }
            }
            Console.WriteLine();
            for (int i = 0; i < ints.Count; i++) // вывод списка
            {
                Console.Write(ints[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
