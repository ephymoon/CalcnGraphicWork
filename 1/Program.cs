using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void BubbleSort(ref List<int> values)
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
            List <int> values = new List <int>();
            for (int i = 0;i < 6;i++) 
            {
                values.Add(Convert.ToInt32(Console.ReadLine()));
            }
            InsertionSort(ref values);
            for (int i = 0; i < 6; i++)
            {
                Console.Write(values[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
