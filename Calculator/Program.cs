using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1 = 0;
            float num2 = 0;

            // String number;
            Console.WriteLine("Console Calculator in C#");

            Console.WriteLine("Masukkan angka pertama dan tekan Enter");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Masukkan angka berikutnya, dan tekan Enter");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Silahkan pilih opsi dari list berikut :");
            Console.WriteLine("\ta - Tambah");
            Console.WriteLine("\ts - Pengurangan");
            Console.WriteLine("\tm - Perkalian");
            Console.WriteLine("\td - Pembagian");
            Console.Write("Pilihan Anda? ");

            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"HASIL : {num1} + {num2} = " + (num1 + num2));
                    break;

                case "s":
                    Console.WriteLine($"HASIL : {num1} - {num2} = " + (num1 - num2));
                    break;

                case "m":
                    Console.WriteLine($"Hasil : {num1} * {num2} = " + (num1 * num2));
                    break;

                case "d":
                    Console.WriteLine($"Hasil : {num1} / {num2} = " + (num1 / num2));
                    break;
            }

            Console.WriteLine("Tekan tombol apapun untuk menutup aplikasi");
            Console.ReadKey();
        }
    }
}
