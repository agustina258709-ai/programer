using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik_5_3_auliya_xpplg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // inisialisasi variable untuk menyimpan input
            string inputUser = "";

                Console.WriteLine("program akan terus berjalan hingga anda mengetik 'keluar' . ");

            // perulangan selama isi variable inputUser TIDAK SAMA DENGAN "keluar"
            while (inputUser.ToLower() != "keluar")
            {
                Console.Write("\nketik sesuatu (atau 'keluar' untuk berhenti): ");

                inputUser = Console.ReadLine(); // baca input dari user

                Console.WriteLine("anda mengetik: " + inputUser);
            }
            Console.WriteLine("\nprogres selesai.terimakasih");
        }
    }
}
