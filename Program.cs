using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        private int[] Giveon = new int[37];
        private int cmp_count = 0;
        private int mov_count = 0;
        private int n;

        void read()
        {
            while (true)
            {
                Console.Write("Enter the number of elements in the array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 37)
                    break;
                else
                    Console.WriteLine("\n array can have maximum 20 elements \n");
            }
            Console.WriteLine("=========================");
            Console.WriteLine("Enter Array Elements");
            Console.WriteLine("=========================");


            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s = Console.ReadLine();
                Giveon[i] = Int32.Parse(s);
            }
        }

        void swap(int x, int y)
        {
            int temp;

            temp = Giveon[x];
            Giveon[x] = Giveon[y];
            Giveon[y] = temp;
        }
        public void QuickSort(int low, int high)
        {
            int pivot, i, AA;
            if (low > high)
                return;

            i = low + 1;
            AA = high;

            pivot = Giveon[low];

            while (i <= AA)
            {
                while ((Giveon[i] <= pivot) && (i <= high))
                {
                    i++;
                    cmp_count++;
                }
                cmp_count++;

                while ((Giveon[AA] > pivot) && (AA >= low))
                {
                    AA--;
                    cmp_count++;
                }
                cmp_count++;

                if (i < AA) 
                {
                    swap(i, AA);
                    mov_count++;
                }
            }

            if (low < AA)
            {
                swap(AA, low);
                mov_count++;
            }
            QuickSort(low, AA - 1);

            QuickSort(AA + 1, high);
        }
        void display()
        {
            Console.WriteLine("\n ---------------------------");
            Console.WriteLine("\n Sorted array elements");
            Console.WriteLine("\n -----------------------------");

            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(Giveon[j]);
            }
            Console.WriteLine("\n Number of comparisons : " + cmp_count);
            Console.WriteLine("\n Number of data movements : " + mov_count);
        }
        int getSize()
        {
            return (n);
        }
        static void Main(string[] args)
        {
            Program myList = new Program();
            myList.read();
            myList.QuickSort(0, myList.getSize() - 1);
            myList.display();
            Console.WriteLine("\n\nPress Enter to Exit");
            Console.Read();
        }
    }
}