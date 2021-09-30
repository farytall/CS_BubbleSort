using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_BubbleSort
{
    class bubble
    {
        public int i, z, j, min, change, n = 10;
        int[] arr = new int[10];
        Random val = new Random();
        public void randomize()
        {
            for (i = 0; i < n; i++)
            {
                arr[i] = val.Next(1000);
                Console.Write(arr[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
        public void sort()
        {
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        change = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = change;
                    }
                }
            }
        }
        public void result()
        {
            for (z = 0; z < n; z++)
            {
                Console.Write(arr[z]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
        public void minimal()
        {
            min = arr[0];
            for (i = 0; i < n; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("{0} - is minimal element", min);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bubble first = new bubble();
            first.randomize();
            first.sort();
            first.result();
            first.minimal();
        }
    }
}
