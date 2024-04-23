using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2
{
    internal class Program
    {
        static void InsertionSort(ref List<int> values)
        {
            for (int step = 1; step < values.Count(); step++)
            {
                int key = values[step];
                int j = step - 1;
                while (j >= 0 && values[j] > key)
                {
                    values[j + 1] = values[j];
                    j = j - 1;
                }
                values[j + 1] = key;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Сортировка Вставками.\n");
            Random rnd = new Random();
            Console.Write("Введите кол-во элементов в массиве: ");
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> values = new List<int>();
            for (int i = 0; i < n; i++)
            {
                values.Add(rnd.Next(-20, 20));
            }
            Console.WriteLine("Вывод неотсортированного массива:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(values[i] + " ");
            }
            InsertionSort(ref values);
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
