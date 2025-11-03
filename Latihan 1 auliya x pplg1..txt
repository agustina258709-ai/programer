using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihan_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== TABEL PERKALIAN 5 ===");
            for (int i = 1; i <= 10; i++)
            {
                int hasil = 5 * i;
                Console.WriteLine("5 * " + i + " = " + hasil);
            }

        }
    }
}
