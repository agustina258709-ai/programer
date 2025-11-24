using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KASIRMINI_AULIYA_XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("================================");
            Console.WriteLine("     💸 APLIKASI KASIR MINI 💸   ");
            Console.WriteLine("================================");
            Console.WriteLine("Daftar Menu:");
            Console.WriteLine("1. Nasi Goreng  - Rp15000");
            Console.WriteLine("2. Mie Goreng   - Rp12000");
            Console.WriteLine("3. Ayam Geprek  - Rp18000");
            Console.WriteLine("4. Es Teh       - Rp5000");
            Console.WriteLine("5. Es Jeruk     - Rp7000");
            Console.WriteLine("================================");

            Console.Write("Pilih nomor menu: ");
            int pilihan = int.Parse(Console.ReadLine());

            string nama = "";
            int harga = 0;

            // Pilih barang sesuai nomor
            switch (pilihan)
            {
                case 1: nama = "Nasi Goreng"; harga = 15000; break;
                case 2: nama = "Mie Goreng"; harga = 12000; break;
                case 3: nama = "Ayam Geprek"; harga = 18000; break;
                case 4: nama = "Es Teh"; harga = 5000; break;
                case 5: nama = "Es Jeruk"; harga = 7000; break;
                default:
                    Console.WriteLine("⚠️ Nomor menu tidak valid!");
                    return;
            }

            Console.Write("Jumlah Beli   : ");
            int jumlah = int.Parse(Console.ReadLine());

            int total = harga * jumlah;

            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Barang        : {nama}");
            Console.WriteLine($"Total Bayar   : Rp{total}");
            Console.Write("Uang Pembeli  : Rp");
            int bayar = int.Parse(Console.ReadLine());

            int kembalian = bayar - total;
            Console.WriteLine("--------------------------------");

            if (bayar < total)
                Console.WriteLine($"⚠️  Uang kurang Rp{Math.Abs(kembalian)}");
            else
                Console.WriteLine($"Kembalian     : Rp{kembalian}");

            Console.WriteLine("================================");
            Console.WriteLine("✅ Terima kasih telah berbelanja!");
            Console.WriteLine("================================");
        }
    }
}
        
    

    

