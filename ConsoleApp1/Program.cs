using System;
using System.Runtime.InteropServices;

namespace RenkliHesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                
            string text = "Coding by Omicron";

                
            ConsoleColor[] colors = {
            ConsoleColor.Red,
            ConsoleColor.Yellow,
            ConsoleColor.Green,
            ConsoleColor.Cyan,
            ConsoleColor.Blue,
            ConsoleColor.Magenta,
            ConsoleColor.White,
            };

                Console.ForegroundColor = ConsoleColor.White;

                for (int i = 0; i < text.Length; i++)
                {
                    char letter = text[i];
                    ConsoleColor color = colors[i % colors.Length]; 
                    Console.ForegroundColor = color;
                    Console.Write(letter);
                    Thread.Sleep(100); 
                }

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("╔═════════════════════════════════════════════════════╗");
                Console.WriteLine("║         Matematik ve Fizik Hesap Makinesi           ║");
                Console.WriteLine("╚═════════════════════════════════════════════════════╝");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("C");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("o");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("d");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("i");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("n");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("g ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("b");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("y ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("o");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("m");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("i");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("c");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("r");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("0n");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nLütfen yapmak istediğiniz işlemi seçin:" + "\n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("1 - Toplama");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("2 - Çıkarma");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("3 - Çarpma");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("4 - Bölme");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("5 - Üs Hesaplama");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("6 - Karekök Hesaplama");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("7 - Mutlak Değer Hesaplama");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("8 - Akım Hesaplama");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("9 - Direnç Hesaplama");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("10 - Alan Hesaplama");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("11 - Hacim Hesaplama");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("12 - Alan Çevresi Hesaplama");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("13 - Daire Dilimi Alanı Hesaplama");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("14 - Üçgen Alan Hesaplama");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("15 - Faktöriyel Hesaplama");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("16 - 2'lik Sayıyı 10'lu Sayıya Dönüştürme");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("17 - 10'lu Sayıyı 2'lik Sayıya Dönüştürme");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("18 - Fibonacci Sayıları");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("0 - Çıkış");
                Console.ResetColor();

                int secim = Convert.ToInt32(Console.ReadLine());

                if (secim == 0)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Çıkış yapılıyor...");
                    break;
                }

                double sonuc = 0;

                switch (secim)
                {
                    case 1:
                        sonuc = ToplamaIslemi();
                        break;

                    case 2:
                        sonuc = CikarmaIslemi();
                        break;

                    case 3:
                        sonuc = CarpmaIslemi();
                        break;

                    case 4:
                        sonuc = BolmeIslemi();
                        break;

                    case 5:
                        sonuc = UsHesaplama();
                        break;

                    case 6:
                        sonuc = KarekokHesaplama();
                        break;

                    case 7:
                        sonuc = MutlakDegerHesaplama();
                        break;

                    case 8:
                        sonuc = AkimHesaplama();
                        break;

                    case 9:
                        sonuc = DirencHesaplama();
                        break;

                    case 10:
                        sonuc = AlanHesaplama();
                        break;

                    case 11:
                        sonuc = HacimHesaplama();
                        break;

                    case 12:
                        sonuc = AlanCevresiHesaplama();
                        break;

                    case 13:
                        sonuc = DaireDilimiAlaniHesaplama();
                        break;

                    case 14:
                        sonuc = UcgenAlanHesaplama();
                        break;

                    case 15:
                        sonuc = FaktoriyelHesaplama();
                        break;

                    case 16:
                        sonuc = BinaryToDecimal();
                        break;

                    case 17:
                        sonuc = DecimalToBinary();
                        break;

                    case 18:
                        FibonacciNumbers();
                        break;
                    case 19:
                        support();
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                        Console.ReadLine();
                        continue;
                }

                Console.WriteLine("Sonuç: " + sonuc);
                TemizleVeBekle();
            }
        }

        static double ToplamaIslemi()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Birinci sayıyı girin: ");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("İkinci sayıyı girin: ");
            double sayi2 = Convert.ToDouble(Console.ReadLine());
            return sayi1 + sayi2;
        }

        static double CikarmaIslemi()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Birinci sayıyı girin: ");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("İkinci sayıyı girin: ");
            double sayi2 = Convert.ToDouble(Console.ReadLine());
            return sayi1 - sayi2;
        }

        static double CarpmaIslemi()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Birinci sayıyı girin: ");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("İkinci sayıyı girin: ");
            double sayi2 = Convert.ToDouble(Console.ReadLine());
            return sayi1 * sayi2;
        }

        static double BolmeIslemi()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Birinci sayıyı girin: ");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("İkinci sayıyı girin: ");
            Console.ForegroundColor = ConsoleColor.White;
            double sayi2 = Convert.ToDouble(Console.ReadLine());

            if (sayi2 != 0)
            {
                return sayi1 / sayi2;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hata: Bölen sıfır olamaz!");
                return 0;
            }
        }

        static double UsHesaplama()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Tabanı girin: ");
            double taban = Convert.ToDouble(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Üssü girin: ");
            double us = Convert.ToDouble(Console.ReadLine());
            return Math.Pow(taban, us);
        }

        static double KarekokHesaplama()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Karekökünü hesaplamak istediğiniz sayıyı girin: ");
            double sayi = Convert.ToDouble(Console.ReadLine());
            return Math.Sqrt(sayi);
        }

        static double MutlakDegerHesaplama()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Mutlak değerini hesaplamak istediğiniz sayıyı girin: ");
            double sayi = Convert.ToDouble(Console.ReadLine());
            return Math.Abs(sayi);
        }

        static double AkimHesaplama()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Voltajı girin (V): ");
            double voltaj = Convert.ToDouble(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Direnç değerini girin (Ω): ");
            double direnc = Convert.ToDouble(Console.ReadLine());
            return voltaj / direnc;
        }

        static double DirencHesaplama()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Voltajı girin (V): ");
            double voltaj = Convert.ToDouble(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Akım değerini girin (A): ");
            double akim = Convert.ToDouble(Console.ReadLine());
            return voltaj / akim;
        }
        static double AlanHesaplama()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Uzunluğu girin: ");
            double uzunluk = Convert.ToDouble(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Genişliği girin: ");
            double genislik = Convert.ToDouble(Console.ReadLine());
            return uzunluk * genislik;
        }

        static double HacimHesaplama()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Uzunluğu girin: ");
            double uzunluk = Convert.ToDouble(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Genişliği girin: ");
            double genislik = Convert.ToDouble(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Yüksekliği girin: ");
            double yukseklik = Convert.ToDouble(Console.ReadLine());
            return uzunluk * genislik * yukseklik;
        }

        static double AlanCevresiHesaplama()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Yarıçapı girin: ");
            double yaricap = Convert.ToDouble(Console.ReadLine());
            return 2 * Math.PI * yaricap;
        }

        static double DaireDilimiAlaniHesaplama()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Yarıçapı girin: ");
            double yaricap = Convert.ToDouble(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Merkez Açısını girin (derece): ");
            double aci = Convert.ToDouble(Console.ReadLine());
            return (aci / 360) * Math.PI * Math.Pow(yaricap, 2);
        }

        static double UcgenAlanHesaplama()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Taban uzunluğunu girin: ");
            double taban = Convert.ToDouble(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Yüksekliği girin: ");
            double yukseklik = Convert.ToDouble(Console.ReadLine());
            return 0.5 * taban * yukseklik;
        }

        static double FaktoriyelHesaplama()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Bir sayı girin: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int faktoriyel = 1;
            for (int i = 1; i <= sayi; i++)
            {
                faktoriyel *= i;
            }
            return faktoriyel;
        }

        static double BinaryToDecimal()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("2'lik tabandaki sayıyı girin: ");
            string binary = Console.ReadLine();

            int decimalValue = Convert.ToInt32(binary, 2);
            return Convert.ToDouble(decimalValue);
        }

        static double DecimalToBinary()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("10'lu tabandaki sayıyı girin: ");
            double decimalNumber;
            while (!double.TryParse(Console.ReadLine(), out decimalNumber))
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Geçerli bir ondalık sayı girin: ");
            }

            int intDecimalNumber = (int)decimalNumber;
            return Convert.ToDouble(Convert.ToString(intDecimalNumber, 2));
        }

        static void FibonacciNumbers()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Kaç adet Fibonacci sayısı görmek istediğinizi girin: ");
            int count;
            while (!int.TryParse(Console.ReadLine(), out count))
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Geçerli bir tam sayı girin: ");
            }

            double a = 0, b = 1;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Fibonacci Sayıları: " + a + " " + b);

            for (int i = 2; i < count; i++)
            {
                double c = a + b;
                Console.Write(" " + c);
                a = b;
                b = c;
            }
        }

        static void support()
        {
            Console.WriteLine("");
        }
        

        static void TemizleVeBekle()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nDevam etmek için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}
