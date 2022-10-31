using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise2
{
    class Program
    {
        private int[] Giveonaldo = new int[37];
        private int cmp_count = 0;
        private int mov_count = 0;

        private int n;

        void Read()
        {
            while (true)
            {
                Console.WriteLine("Enter the number of element in the array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n < 37)
                    break;
                else
                    Console.WriteLine("\n array can have maximum 37 elements \n");
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("<"+(i + 1) + ">");
                string s = Console.ReadLine();
                Giveonaldo[i] = int.Parse(s);
            }
        }

        void Swap(int x, int y)
        {
            int temp;
            temp = Giveonaldo[x];
            Giveonaldo[x] = Giveonaldo[y];
            Giveonaldo[x] = temp;
        }

        public void QuickSort(int low, int high)
        {
            int pivot, i, j;
            if (low > high)
                return;
        }

        static void Main(string[] args)
        {
            
        }
    }
}