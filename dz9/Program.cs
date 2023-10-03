using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте, сколько карт у вас на руках?");
            int userNumber = int.Parse(Console.ReadLine());
            int count = 0;
            int nominal = 0;

            for (int i = 1; i <= userNumber; i++)
            {
                Console.WriteLine("Введите номинал каждой карты");
                string imagine = Console.ReadLine();
                switch (imagine)
                {
                    case "1":
                        nominal = 1;
                        break;
                    case "2":
                        nominal = 2;
                        break;
                    case "3":
                        nominal = 3;
                        break;
                    case "4":
                        nominal = 4;
                        break;
                    case "5":
                        nominal = 5;
                        break;
                    case "6":
                        nominal = 6;
                        break;
                    case "7":
                        nominal = 7;
                        break;
                    case "8":
                        nominal = 8;
                        break;
                    case "9":
                        nominal = 9;
                        break;
                    case "10":
                        nominal = 10;
                        break;
                    case "J":
                        nominal = 10;
                        break;
                    case "Q":
                        nominal = 10;
                        break;
                    case "K":
                        nominal = 10;
                        break;
                    case "T":
                        nominal = 10;
                        break;
                }
                count += nominal;
            }
            Console.WriteLine($"Сумма карт {count}");
            Console.ReadKey();

        }
    }
}
   