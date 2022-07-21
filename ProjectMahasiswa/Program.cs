using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        Mahasiswa Mahasiswa = new Mahasiswa();

        static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>();

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
                        Console.ReadKey();
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

            Mahasiswa mhs = new Mahasiswa();
            //NIM
            Console.Write("NIM                  : ");
            mhs.NIM = Console.ReadLine();
            //Nama
            Console.Write("Nama                 : ");
            mhs.Nama = Console.ReadLine();
            //Jenis Kelamin
            Console.Write("Jenis Kelamin(L/P)   : ");
            mhs.Jenisk = Console.ReadLine();
            if (mhs.Jenisk == "L")
            {
                mhs.Jenisk = "Laki-Laki";
            }
            else if (mhs.Jenisk == "P")
            {
                mhs.Jenisk = "Perempuan";
            }
            // IPK
            Console.Write("IPK                  : ");
            mhs.IPK = Console.ReadLine();
            Console.WriteLine();

            daftarMahasiswa.Add(mhs);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();

        }

        static void TampilMahasiswa()
        {
            Console.WriteLine("Data Mahasiswa\n");
            int no = 1;

            Console.WriteLine("No\tNIM\tNama \tJenis Kelamin\tIPK");
            foreach (Mahasiswa mhs in daftarMahasiswa)
            {

                Console.WriteLine("{0}.\t{1}\t{2} \t{3}\t{4}", no, mhs.NIM, mhs.Nama, mhs.Jenisk, mhs.IPK);
                no++;
            }
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

    }
}
