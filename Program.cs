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
        }
        

        static void Main(string[] args)
        {
            
        }
    }
}