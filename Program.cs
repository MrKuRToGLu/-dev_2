using System.Diagnostics.CodeAnalysis;

namespace Ödev_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir ay giriniz");
            String ay = Console.ReadLine();
            switch (ay)
            { 
                case  ("Aralık") or ("aralık"):
                    Console.WriteLine("Kış");
                    Console.WriteLine("12.Ay");

                    break;
                case ("Ocak") or ("ocak"):
                    Console.WriteLine("Kış");
                    Console.WriteLine("1.Ay");
                    break;

                case ("Şubat") or ("şubat"):
                    Console.WriteLine("Kış");
                    Console.WriteLine("2.Ay");
                    break;
                case ("Mart") or ("mart"):
                    Console.WriteLine("İlk Bahar");
                    Console.WriteLine("3.Ay");
                    break;
                case ("Nisan") or ("nisan"):
                    Console.WriteLine("İlk Bahar");
                    Console.WriteLine("4.Ay");
                    break;
                case ("Mayıs") or ("mayıs"):
                    Console.WriteLine("İlk Bahar");
                    Console.WriteLine("5.Ay");
                    break;
                case ("Haziran") or ("haziran"):
                    Console.WriteLine("Yaz");
                    Console.WriteLine("6.Ay");
                    break;
                case ("Temmuz") or ("temmuz"):
                    Console.WriteLine("Yaz");
                    Console.WriteLine("7.Ay");
                    break;
                case ("Ağustos") or ("ağustos"):
                    Console.WriteLine("Yaz");
                    Console.WriteLine("8.Ay");
                    break;
                case ("Eylül") or ("eylül"):
                    Console.WriteLine("Son Bahar ");
                    Console.WriteLine("9.Ay");
                    break;
                case ("Ekim") or ("ekim"):
                    Console.WriteLine("Son Bahar");
                    Console.WriteLine("10.Ay");
                    break;
                case ("Kasım") or ("kasım"):
                    Console.WriteLine("İlk Bahar");
                    Console.WriteLine("11.Ay");
                    break;
                    Console.ReadKey(); Console.WriteLine("Kapatmak için bir tuşa basınız");
            }
            
            Console.ReadKey();


        
        }
 }   } 