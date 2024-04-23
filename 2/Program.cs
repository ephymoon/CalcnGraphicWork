using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        
        static bool LinearSearch(List <int> values, int item, ref int index)
        {
            bool changed = false;
            for (int i = 0; i < values.Count; i++)
            {
                if (values[i] == item) 
                {
                    changed = true;
                    index = i;
                    break;
                }
            }
            return changed;
        }

        static void Main(string[] args)
        {
            Console.Write("Программа линейного алгоритма find.\nВведите кол-во элементов массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите элемент для поиска: ");
            int item = Convert.ToInt32(Console.ReadLine());
            int index = 0;
            Random rnd = new Random();
            List <int> values = new List <int>();
            for (int i = 0;i < n;i++) 
            {
                values.Add(rnd.Next(0,6));
            }
            Console.Write("Вывод сгенерированного массива:\n");
            for (int i = 0; i < n; i++)
            {
                Console.Write(values[i] + " ");
            }
            if (LinearSearch(values, item, ref index))
                Console.Write("\nИндекс искомого элемента: " + index + "\n");
            else Console.Write("\nТакого числа не найдено.\n");
            Console.Write("Нажмите любую клавишу для выхода из программы..."); Console.ReadKey();
        }
    }
}
