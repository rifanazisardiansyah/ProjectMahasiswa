using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        static List<string> daftarMahasiswa = new List<string>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..3]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahMahasiswa();
                        break;

                    case 2:
                        TampilMahasiswa();
                        break;

                    case 3: // keluar dari program
                        Console.WriteLine("Terimakasih Telah Menggunakan Program Ini");
                        Console.WriteLine("Tekan Sekali Lagi Untuk Keluar");
                        Console.ReadKey();
                        return;

                    default:
                        Console.WriteLine("Menu Yang Anda Masukkan Salah !!!");
                        Console.WriteLine("Silahkan Ulangi !!!");
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            // PERINTAH: lengkapi kode untuk menampilkan menu
            Console.Clear();
            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine();
            Console.WriteLine("1. Tambah Mahasiswa");
            Console.WriteLine("2. Tampilkan Mahasiswa");
            Console.WriteLine("3. Keluar");
        }

        static void TambahMahasiswa()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan objek mahasiswa ke dalam collection
            Mahasiswa mhs = new Mahasiswa();

            Console.Write("NIM    : ");
            mhs.NIM = Console.ReadLine();
            Console.Write("Nama  : ");
            mhs.Nama = Console.ReadLine();
            Console.Write("Jenis Kelamin(L/P) : ");
            mhs.Jenisk = Console.ReadLine();
            Console.Write("IPK : ");
            mhs.IPK = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilMahasiswa()
        {
            Console.Clear();
            // PERINTAH: lengkapi kode untuk menampilkan daftar mahasiswa yang ada di dalam collection


            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
