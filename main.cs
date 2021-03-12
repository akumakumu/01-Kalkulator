using System;

namespace _01_Kalkulator
{
    class main
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.Title = "Kalkulator";

            Console.WriteLine("Pilih menu kalkulator:");
            Console.WriteLine("");
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.WriteLine();

            Console.Write("Input nomor menu : ");
            int dec = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (dec)
            {
                case 1:
                    Console.Write("Inputkan Nilai a = ");
                    a = int.Parse(Console.ReadLine());

                    Console.Write("Inputkan Nilai b = ");
                    b = int.Parse(Console.ReadLine());

                    Console.WriteLine();

                    Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
                    break;
                case 2:
                    Console.Write("Inputkan Nilai a = ");
                    a = int.Parse(Console.ReadLine());

                    Console.Write("Inputkan Nilai b = ");
                    b = int.Parse(Console.ReadLine());

                    Console.WriteLine();

                    Console.WriteLine("Hasil Pengurangan " + a + " - " + b + " = " + Pengurangan(a, b));
                    break;
                case 3:
                    Console.Write("Inputkan Nilai a = ");
                    a = int.Parse(Console.ReadLine());

                    Console.Write("Inputkan Nilai b = ");
                    b = int.Parse(Console.ReadLine());

                    Console.WriteLine();

                    Console.WriteLine("Hasil Perkalian " + a + " * " + b + " = " + Perkalian(a, b));
                    break;
                case 4:
                    Console.Write("Inputkan Nilai a = ");
                    a = int.Parse(Console.ReadLine());

                    Console.Write("Inputkan Nilai b = ");
                    b = int.Parse(Console.ReadLine());

                    Console.WriteLine();

                    Console.WriteLine("Hasil Pembagian " + a + " / " + b + " = " + Pembagian(a, b));
                    break;
                default:
                    Console.WriteLine("Maaf, menu yang anda pilih tidak tersedia");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Tekan sembarang untuk keluar");
            Console.ReadKey();
        }
        static int Penambahan(int a, int b)
        {
            return a + b;
        }

        static int Pengurangan(int a, int b)
        {
            return a - b;
        }

        static int Perkalian(int a, int b)
        {
            return a * b;
        }

        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
