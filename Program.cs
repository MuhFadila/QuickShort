using System;

namespace QuickShort
{
    class Program
    {
        //array of integers to hold values
        private int[] arr = new int[20];
        private int cmp_count = 0; // number of data comparasion
        private int mov_count = 0; // number of data movements

        // number of elements in array
        private int n;

        void input()
        {
            while (true)
            {
                Console.Write("Enter the number of element in array :");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
            }
        }
    }
}
