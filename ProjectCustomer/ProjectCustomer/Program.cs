using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectCustomer{
    class Program{
        static List<Customer> daftarCustomer = new List<Customer>();

        static void Main(string[] args){
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true){
                TampilMenu();

                Console.Write("\n\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu){
                    case 1:
                        TambahCustomer();
                        break;

                    case 2:
                        HapusCustomer();
                        break;

                    case 3:
                        TampilCustomer();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu(){
            Console.Clear();
            Console.Write("Pilih Menu Aplikasi\n\n");
            Console.Write("1. Tambah Customer");
            Console.Write("\n2. Hapus Customer");
            Console.Write("\n3. Tampilkan Customer");
            Console.Write("\n4. Keluar");
        }

        static void TambahCustomer(){
            Console.Clear();
            Console.WriteLine("Tambah Data Customer\n\n");

            Customer costomer = new Customer();

            Console.Write("Kode Customer \t: ");
            costomer.KodeCustomer=Console.ReadLine();

            Console.Write("Nama Customer \t: ");
            costomer.NamaCustomer=Console.ReadLine();


            Console.Write("Piutang \t: ");
            costomer.Piutang=Convert.ToDouble(Console.ReadLine());

            daftarCustomer.Add(costomer);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusCustomer(){
            Console.Clear();

            int no = 1;
            int jumlahdata = 0;

            foreach (Customer customer in daftarCustomer){
                Console.WriteLine("{0}. {1}  {2}  {3}", no, customer.KodeCustomer, customer.NamaCustomer, customer.Piutang);
                no++;
                jumlahdata += 1;
            }

            Console.Write("\nMasukkan kode customer yang akan dihapus [1-");
            Console.Write(jumlahdata);
            Console.Write("] : ");

            string kodehapus = Console.ReadLine();
            if (daftarCustomer.Any(a => a.KodeCustomer == kodehapus)){
                daftarCustomer.RemoveAll(b => b.KodeCustomer == kodehapus);
                Console.WriteLine("\nData customer berhasil dihapus\n");
            }
            else{
                Console.WriteLine("Kode customer tidak ditemukan\n");
            }
            

            Console.WriteLine("\nTekan Enter Untuk Kembali ke Menu");
            Console.ReadKey();
        }

        static void TampilCustomer(){
            Console.Clear();
            Console.WriteLine("Tampil Data\n");
                int no = 1;

                foreach (Customer customer in daftarCustomer){
                    Console.WriteLine("{0}. {1}  {2}  {3}", no, customer.KodeCustomer, customer.NamaCustomer, customer.Piutang);
                    no++;
                }
            

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
