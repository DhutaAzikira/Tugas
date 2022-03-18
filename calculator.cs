using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculator";
            int a=0;
            int b=0;
            int menu;

            Console.WriteLine("Calculator");
            Console.WriteLine("Pilih menu calculator");
            Console.WriteLine("1.\tpertambahan");
            Console.WriteLine("2.\tpengurangan");
            Console.WriteLine("3.\tPerkalian");
            Console.WriteLine("4.\tPembagian");
            Console.Write("Input menu calculator ");
            menu = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Inputkan nilai a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Inputkan nilai b = ");
            b = Convert.ToInt32(Console.ReadLine());


            switch (menu)
            {
                case 1:
                    Console.WriteLine($"Hasil: {a} + {b} = " + (a + b));
                    break;
                case 2:
                    Console.WriteLine($"Hasil: {a} - {b} = " + (a - b));
                    break;
                case 3:
                    Console.WriteLine($"Hasil: {a} * {b} = " + (a * b));
                    break;
                case 4:
                    Console.WriteLine($"Hasil: {a} / {b} = " + (a / b));
                    break;

                default:
                    Console.WriteLine("Pilihan tidak tersedia");
                    break;
            }
            Console.Write("Press any key to quit.");
            Console.ReadKey();
        }

    }
}