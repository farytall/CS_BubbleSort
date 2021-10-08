using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Class_BubbleSort var = new Class_BubbleSort();
            var.Rand_element();
            var.Sort_List();
            var.Show_minimal();
        }
    }
}
