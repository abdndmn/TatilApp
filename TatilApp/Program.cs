// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;

namespace TatilApp
{

    class Program
    {

        static void Main(string[] args)
        {
            do {

                string location = "";
                while (location != "bodrum" && location != "marmaris" && location != "cesme")
                {
                    Console.Write("Lutfen gitmek istediginiz lokasyonu giriniz!(Bodrum/Marmaris/Cesme): ");
                    location = Console.ReadLine().ToLower();

                    if (location != "bodrum" && location != "marmaris" && location != "cesme")
                    {
                        Console.WriteLine("Hatali giris!");
                    }
                }

                Console.Write("Kac kisi icin tatil planliyorsunuz?: ");
                int person = Convert.ToInt32(Console.ReadLine());
                if (location == "bodrum")
                {
                    Console.WriteLine("\n\nBodrum'da mavi turlara katilabilir, essiz koyları kesfedebilirsiniz.");
                }
                else if (location == "marmaris")
                {
                    Console.WriteLine("\n\nMarmaris'te su sporları yapabilir ve barlar sokaginda eglenebilirsiniz.");
                }
                else if (location == "cesme")
                {
                    Console.WriteLine("\n\nCesme'de Alacati sokaklarinda gezebilir ve plajlarda vakit gecirebilirsiniz.");
                }

                int tripType = 0;
                while (tripType != 1 && tripType != 2)
                {
                    Console.Write("\nUlasim seceneklerimiz:\n\n1 - Kara yolu ( Kisi basi ulasim tutari gidis-donus 1500 TL)\n\n2 - Hava yolu ( Kisi basi ulasim tutari gidis-donus 4000 TL)\n\n Lutfen Kara yolu icin '1', Hava yolu icin '2'yi seciniz!: ");
                    tripType = Convert.ToInt32(Console.ReadLine());

                    if (tripType != 1 && tripType != 2)
                    {
                        Console.WriteLine("Hatali giris! Lütfen sadece '1' veya '2' giriniz.");
                    }
                }

                if (tripType == 1)
                {
                    switch (location)
                    {
                        case "bodrum":
                            int toplam = person * (4000 + 1500);
                            Console.WriteLine($"\n\nKara yolu ile Bodrum tatiliniz {person} kisi icin {toplam} TL'dir!");
                            break;
                        case "marmaris":
                            toplam = person * (3000 + 1500);
                            Console.WriteLine($"\n\nKara yolu ile Marmaris tatiliniz {person} kisi icin {toplam} TL'dir!");
                            break;
                        case "cesme":
                            toplam = person * (3000 + 1500);
                            Console.WriteLine($"\n\nKara yolu ile Cesme tatiliniz {person} kisi icin {toplam} TL'dir!");
                            break;
                    }
                }
                else if (tripType == 2)
                {
                    switch (location)
                    {
                        case "bodrum":
                            int toplam = person * (4000 + 4000);
                            Console.WriteLine($"\n\nHava yolu ile Bodrum tatiliniz {person} kisi icin {toplam} TL'dir!");
                            break;
                        case "marmaris":
                            toplam = person * (3000 + 4000);
                            Console.WriteLine($"\n\nHava yolu ile Marmaris tatiliniz {person} kisi icin {toplam} TL'dir!");
                            break;
                        case "cesme":
                            toplam = person * (3000 + 4000);
                            Console.WriteLine($"\n\nHava yolu ile Cesme tatiliniz {person} kisi icin {toplam} TL'dir!");
                            break;
                    }
                }
                Console.Write("Baska bir tatil planlamak ister misiniz? (Evet/Hayır): ");
            } while (Console.ReadLine().Trim().ToLower() == "evet");
              Console.WriteLine("Bizi tercih ettiginiz icin tesekkur ederiz, İyi günler!");
        } 

        
    }    
}