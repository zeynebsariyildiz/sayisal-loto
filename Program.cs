using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayisal_loto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random sayi = new Random();
            int[] rastgele = new int[6];
            for (int i = 0; i < 6; i++)
            {
                rastgele[i] = sayi.Next(1, 50);
            }
            Array.Sort(rastgele);
            Console.WriteLine("0-49 ARASINDAKİ SAYILAR");
            Console.WriteLine("----------------------------");
            for (int i = 0; i < 6; i++)
            {
                Console.Write(rastgele[i] + "-");
            }
            Console.WriteLine("");
            Console.WriteLine("----------------------------");
            Console.ReadLine();
            for (int i = 0; i < ; i++)
            {

            }
        }
    }
}
