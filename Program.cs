using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectProduk
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek produk
        static List<Produk> daftarProduk = new List<Produk>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";
            
            bool loop = true;
            while (loop)
            {
                TampilMenu();
                
                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());
                
                switch (nomorMenu)
                {
                    case 1:
                        TambahProduk();
                        break;
                        
                    case 2:
                        HapusProduk();
                        break;
                        
                    case 3:
                        TampilProduk();
                        break;
                        
                    case 4:
                        loop = false;
                        // keluar dari program
                        break;
                        
                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            
            // PERINTAH: lengkapi kode untuk menampilkan menu
            Console.WriteLine("Pilih menu Aplikasi");
            Console.WriteLine("\n1. Tambah Produk");
            Console.WriteLine("2. Hapus Produk");
            Console.WriteLine("3. Tampilkan Produk");
            Console.WriteLine("4. Keluar");
        }

        static void TambahProduk()
        {
            Console.Clear();
            
            // PERINTAH: lengkapi kode untuk menambahkan produk ke dalam collection
            Produk produk = new Produk();
            Console.WriteLine("Tambah Data Produk");
            Console.Write("\nKode Produk : ");
            produk.KodeProduk = Console.ReadLine();
            Console.Write("Nama Produk : ");
            produk.NamaProduk = Console.ReadLine();
            Console.Write("Harga Beli : ");
            produk.HargaBeli = double.Parse(Console.ReadLine());
            Console.Write("Harga Jual : ");
            produk.HargaJual = double.Parse(Console.ReadLine());
            daftarProduk.Add(produk);
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusProduk()
        {
            Console.Clear();
            
            // PERINTAH: lengkapi kode untuk menghapus produk dari dalam collection
            int no = -1, hapus = -1;
            Console.WriteLine("Hapus Data Produk");
            Console.Write("Kode Produk : ");
            string kode = Console.ReadLine();
            foreach (Produk produk in daftarProduk)
            {
                no++;
                if(produk.KodeProduk == kode)
                {
                    hapus = no;
                }
            }
            if (hapus != -1)
            {
                daftarProduk.RemoveAt(hapus);
                Console.WriteLine("\nData produk berhasil di hapus");
            }
            else
            {
                Console.WriteLine("\nKode produk tidak ada");
            }
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilProduk()
        {
            Console.Clear();
            
            // PERINTAH: lengkapi kode untuk menampilkan daftar produk yang ada di dalam collection
            int noUrut = 0;
            Console.WriteLine("Data Produk");
            foreach (Produk produk in daftarProduk)
            {
                noUrut++;
                Console.WriteLine("{0}. \nKode Produk: {1}, \nNama Produk: {2}, \nHarga Beli: {3}, \nHarga Jual: {4}\n", noUrut, produk.KodeProduk, produk.NamaProduk, produk.HargaBeli, produk.HargaJual);
            }
            if (noUrut < 1)
            {
                Console.WriteLine("Produk Kosong");
            }
            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
