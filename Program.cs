﻿using System;
using System.IO;

namespace BasicProgramming
{
  class Program
  {
    static void Main(string[] args)
    {
      // variabel
      int? input1;

      // variabel array untuk menyimpan jenis lauk sayur 
      string[] lauk = { "Ayam", "Capcay", "Ikan", "Bakso", "Bayam" };

      // constructor sistemPesan untuk dipanggil di main
      sistemPesan SP = new sistemPesan();
      Console.Clear();
      // menjalankan perintah untuk menampilkan method title dan instruksi 
      do
      {
        // menampilkan judul
        Judul();

        // menampilkan instruksi
        Instruksi();

        // memasukkan inputan
        Console.WriteLine("Beberapa contoh lauk & sayur Catering Boy : \n");
        foreach (string lauk1 in lauk)
        {
          Console.WriteLine(lauk1);
        }
        Console.Write("\nTentukan pilihanmu dari sekarang (1 u/ pesan dan 2 u/ batal) : ");
        input1 = Convert.ToInt32(Console.ReadLine());

        // menjalankan pengulangan sampai user menginput angka 2
        switch (input1)
        {

          // jika user pilih input 1, console akan di clear, masuk ke method tampilan menu, dan method pesen catering dari sistem pesan
          case 1:
            Console.Clear();
            SP.pesanCtrg();
            break;

          // jika user pilih input 2, console akan exit dan menampilkan print string
          case 2:
            Console.Clear();
            Console.WriteLine("Babay~ \n");
            Environment.Exit(1);
            break;

          // jika user memilih diluar 1 atau 2 akan muncul notif pilihan tidak tersedia
          default:
            Console.Clear();
            Console.WriteLine("\nPilihan tidak tersedia.\n");
            break;
        }

      } while (input1 != 2);
    }

    // void method bagian judul
    public static void Judul()
    {
      Console.WriteLine("\n=======================================================");
      Console.WriteLine("             CATERING BOY GADING SERPONG");
      Console.WriteLine("=======================================================\n");
    }

    // void method bagian instruksi
    public static void Instruksi()
    {
      Console.WriteLine("Instruski Pemesanan.\n");
      Console.WriteLine(
              "1. Masukkan inputan angka 1 untuk masuk ke pemilihan menu dan 2 untuk membatalkan pemesanan.\n");
      Console.WriteLine(
              "2. Setelah melihat menu catering masukkan angka yang sesuai dengan pilih jenis catering.\n");
      Console.WriteLine(
              "3. Pemesanan hanya dapat h-1. Masukkan berapa hari anda ingin memesan dengan angka.\n");
      Console.WriteLine(
              "4. Tentukan jumlah makan dalam sehari bisa satu kali atau 2 kali untuk makan siang dan malam. (masukkan angka 1 untuk sekali makana dan 2 untuk 2 kali makan)\n");
      Console.WriteLine(
              "5. Terakhir masukkan alamat pengiriman yang sesuai dan jelas, terimakasih.\n");
    }

    // method void cetak struk
    public class sistemPesan
    {
      int? input2;
      int total;
      string? lanjut;
      string? alamat;
      int jumlah;
      int totalMakan;
      static int[] hargaCtrg = { 23000, 44000, 115000, 228000, 460000, 910000 };
      int i;
      int uangPembayaran;

      // method cetak struk
      public void cetakStruk()
      {
        Console.WriteLine("\n-------------------------------------------------\n");
        Console.WriteLine("\nTerimakasih sudah mempercayai Catering Boy :D\n");
        Console.WriteLine("Kamu telah memesan catering untuk " + jumlah + " hari.\n");
        Console.WriteLine("Total makan untuk " + totalMakan + "x makan.\n");
        Console.WriteLine("Alamat pengantaran catering " + alamat);
        Console.WriteLine("\nTotalnya jadi : " + "Rp." + total + ",00\n");
      }



      // method untuk memunculkan menu catering
      public void pesanCtrg()
      {
        while (true)
        {
          Console.WriteLine("===============================================================");
          Console.WriteLine("                     Pilihan Catering                ");
          Console.WriteLine("===============================================================");
          Console.WriteLine("      1. Catering Harian Makan Sendiri            Rp.23000,00");
          Console.WriteLine("      2. Catering Harian Makan Berdua             Rp.44000,00");
          Console.WriteLine("      3. Catering Mingguan Makan Sendiri          Rp.115000,00");
          Console.WriteLine("      4. Catering Mingguan Makan Berdua           Rp.228000,00");
          Console.WriteLine("      5. Catering Bulanan Makan Sendiri           Rp.460000,00");
          Console.WriteLine("      6. Catering Bulanan Makan Berdua            Rp.910000,00");
          Console.WriteLine("================================================================");
          Console.Write("\nTentukan jenis Catering yang diinginkan : ");
          input2 = Convert.ToInt32(Console.ReadLine());
          switch (input2)
          {
            case 1:
              Console.WriteLine("\nKamu pesan Catering Harian Makan Sendiri\n");
              i = 0;
              mPesan(hargaCtrg, i);
              break;

            case 2:
              Console.WriteLine("\nKamu pesan Catering Harian Makan Berdua\n");
              i = 1;
              mPesan(hargaCtrg, i);
              break;

            case 3:
              Console.WriteLine("\nKamu pesan Catering Mingguan Makan Sendiri\n");
              i = 2;
              mPesan(hargaCtrg, i);
              break;

            case 4:
              Console.WriteLine("\nKamu pesan Catering Mingguan Makan Berdua\n");
              i = 3;
              mPesan(hargaCtrg, i);
              break;

            case 5:
              Console.WriteLine("\nKamu pesan Catering Bulanan Makan Sendiri\n");
              i = 4;
              mPesan(hargaCtrg, i);
              break;

            case 6:
              Console.WriteLine("\nKamu pesan Catering Bulanan Makan Berdua\n");
              i = 5;
              mPesan(hargaCtrg, i);
              break;

            default:
              Console.WriteLine("Pilihan Catering tidak tersedia.");
              break;
          }

          // method non void untuk masukkan data dan hitung total
          int mPesan(int[] HargaCtrg, int index)
          {
            hargaCtrg = HargaCtrg;
            i = index;
            Console.Write("Pesan untuk berapa hari? ");
            jumlah = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nPesan untuk 1 kali makan atau 2 kali makan? ");
            totalMakan = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nMasukkan alamat pengantaran catering : ");
            alamat = Console.ReadLine();
            if (totalMakan == 1)
            {
              total = total + jumlah * HargaCtrg[index];
            }
            else if (totalMakan == 2)
            {
              total = total + jumlah * HargaCtrg[index] * 2;
            }

            return total;

          }

          cetakStruk();


          Console.Write("\nApakah pesanan anda sudah sesuai? (y/n) : ");
          lanjut = Console.ReadLine();

          if (lanjut == "n" || lanjut == "N")
          {
            Console.Clear();
            total = 0;
            jumlah = 0;
            totalMakan = 0;
            alamat = "";
            pesanCtrg();
          }
          else if (lanjut == "y" || lanjut == "y")
          {
            Console.WriteLine("\nDitunggu yah untuk cateringnya :D\n");
            Environment.Exit(1);
          }
          else
          {
            Console.WriteLine("\nPilih yang bener.\n");
          }
        }
      }

      public void menuBayar()
      {
        Console.Clear();
        Console.WriteLine("==============================================");
        Console.WriteLine("                  Pembayaran                ");
        Console.WriteLine("==============================================\n");
        Console.WriteLine("Total harga pesanan anda : " + "Rp." + total + ",00\n");
        Console.Write("Masukkan uang pembayaran : ");
        uangPembayaran = Convert.ToInt32(Console.ReadLine());

      }


    }
  }
}



