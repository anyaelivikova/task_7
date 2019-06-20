using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_15
{
    class Program
    {
        static void Print(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }

        static void swap(int[] a, int i, int j)
        {
            int s = a[i];
            a[i] = a[j];
            a[j] = s;
        }
        static bool NextSet(int[] a, int n)
        {
            int j = n - 2;
            while (j != -1 && a[j] >= a[j + 1]) j--;
            if (j == -1)
                return false; // больше перестановок нет
            int k = n - 1;
            while (a[j] >= a[k]) k--;
            swap(a, j, k);
            int l = j + 1, r = n - 1; // сортируем оставшуюся часть последовательности
            while (l < r)
                swap(a, l++, r--);
            return true;
        }

        static void Main(string[] args)
        {
            const int n = 5;
            int[] a = { 1, 2, 3, 4, 5 };

            Print(a);

            while (NextSet(a, n))
                Print(a);

            Console.ReadLine();
        }
    }
}
