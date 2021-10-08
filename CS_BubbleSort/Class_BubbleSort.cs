using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_BubbleSort
{
    class Class_BubbleSort
    {
        private const int size = 10;
        private List<int> arr = new List<int>(size);
        private int min_element, swap;

        Random val = new Random();              //создаем объект для генерации случайных чисел
        public void Rand_element()
        {
            for (int i = 0; i < size; i++)
            {
                arr.Add(val.Next(100));         //Заполняем список
                Console.Write("{0} ", arr[i]);   //Выводим получившийся список
            }
            Console.WriteLine(" -Non_Sorted");
        }
        public void Sort_List()                 //Метод для сортировки списка
        {
            for (int i = 1; i < size; i++)
            {
                for (int j = 0; j < size - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        swap = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = swap;
                    }
                }
            }
            foreach (int element in arr)
            {
                Console.Write("{0} ", element);     //Выводим результат сортировки
            }
            Console.WriteLine(" -Sorted");
        }
        public void Show_minimal()                  //метод поиска наименьшего
        {
            min_element = arr[0];
            for (int i = 1; i < size; i++)
            {
                if (min_element > arr[i])
                {
                    min_element = arr[i];
                }
            }
            Console.WriteLine("{0} - is minimal element", min_element);

        }
    }
}
