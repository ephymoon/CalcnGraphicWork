using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _1._1
{
    internal class Program
    {
        public static void BubbleSort(ref List<int> values)
        {
            bool swapRequired;
            for (int i = 0; i < values.Count - 1; i++)
            {
                swapRequired = false;
                for (int j = 0; j < values.Count - i - 1; j++)
                {
                    if (values[j] > values[j + 1])
                    {
                        var tuple = (values[j], values[j + 1]);
                        values[j] = tuple.Item2;
                        values[j + 1] = tuple.Item1;
                        swapRequired = true;
                    }
                }
                if (!swapRequired)
                    break;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Сортировка Пузырьком.\n");
            Random rnd = new Random();
            Console.Write("Введите кол-во элементов в массиве: ");
            int n = Convert.ToInt32(Console.ReadLine());
            List <int> values = new List<int>();
            for (int i = 0; i < n; i++)
            {
                values.Add(rnd.Next(-20,20));
            }
            Console.WriteLine("Вывод неотсортированного массива:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(values[i] + " ");
            }
            BubbleSort(ref values);
            Console.WriteLine("\nВывод отсортированного массива:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(values[i] + " ");
            }
            Console.Write("\nДля завершения работы программы нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
