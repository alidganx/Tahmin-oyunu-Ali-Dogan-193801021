using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tahmin_oyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("lütfen bir seviye seçiniz:kolay,orta,zor");
            string seviye = Console.ReadLine();
            if (seviye == "kolay")
            {
                int sayi = rnd.Next(1, 10);
                int hak = 6;
                for (; ; )
                {

                    Console.WriteLine("bir tahmin yapınız:");
                    int tahmin = int.Parse(Console.ReadLine());
                    hak--;
                    if (sayi == tahmin)
                    {
                        Console.WriteLine("Tebrikler  bildiniz...");
                        break;
                    }
                    else if (hak == 0)
                    {
                        Console.WriteLine("Bilemediniz:hakkınız bitti");
                        Console.WriteLine($"Doğru Cevap:{sayi} :)");
                        break;
                    }

                    Console.WriteLine($"{hak}:hakkınız kaldı");
                }
            }
            else if (seviye == "orta")
            {
                int sayi = rnd.Next(1, 25);
                int hak = 4;
                for (; ; )
                {
                    Console.WriteLine("bir tahmin yapınız:");
                    int tahmin = int.Parse(Console.ReadLine());
                    hak--;
                    if (sayi == tahmin)
                    {
                        Console.WriteLine("Tebrikler  bildiniz...");
                        break;
                    }
                    else if (hak == 0)
                    {
                        Console.WriteLine("Bilemediniz:hakkınız bitti");
                        Console.WriteLine($"Doğru Cevap:{sayi} :)");
                        break;
                    }
                    Console.WriteLine($"{hak}:hakkınız kaldı");
                }
            }
            else if (seviye == "zor")
            {
                int sayi = rnd.Next(1, 50);
                int hak = 2;
                for (; ; )
                {
                    Console.WriteLine("bir tahmin yapınız:");
                    int tahmin = int.Parse(Console.ReadLine());
                    hak--;
                    if (sayi == tahmin)
                    {
                        Console.WriteLine("Tebrikler  bildiniz...");
                        break;
                    }
                    else if (hak == 0)
                    {
                        Console.WriteLine("Bilemediniz:hakkınız bitti");
                        Console.WriteLine($"Doğru Cevap:{sayi} :)");
                        break;
                    }

                    Console.WriteLine($"{hak}:hakkınız kaldı");
                }
            }
            else
            {
                Console.WriteLine("lütfen:kolay,orta,zor arasından bir seviye seçiniz");
            }
            Console.ReadKey();

        }
    }
    }

