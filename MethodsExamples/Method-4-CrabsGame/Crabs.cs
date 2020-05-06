using System;

namespace Method_4
    {
    class Crabs
        {
        private static Random rastgeleSayi = new Random();

        private enum Durum { Devam, Kazandın, Kaybettin }

        private enum Zarİsimleri
            {
            SnakeEyes = 2,
            Trey = 3,
            Seven = 7,
            YoLeven = 11,
            BoxCars = 12
            }

        static void Main()
            {
            Durum gameStatus = Durum.Devam;
            int benimpuanim = 0;

            int zarToplami = ZarAt();
            switch ((Zarİsimleri)zarToplami)
                {
                case Zarİsimleri.Seven:
                case Zarİsimleri.YoLeven:
                    gameStatus = Durum.Kazandın;
                    break;
                case Zarİsimleri.SnakeEyes:
                case Zarİsimleri.Trey:
                case Zarİsimleri.BoxCars:
                    gameStatus = Durum.Kaybettin;
                    break;
                default:
                    gameStatus = Durum.Devam;  //Kazanan ya da kaybeden yoksa Devam et
                    benimpuanim = zarToplami;
                    Console.WriteLine($"Skor {benimpuanim}");
                    break;
                }
            // Oyun bitmemiş ise
            while (gameStatus == Durum.Devam)
                {
                zarToplami = ZarAt(); // Tekrar zar at

                // oyun durumunu belirle
                if (zarToplami == benimpuanim) // Puan vererek kazanmak
                    {
                    gameStatus = Durum.Kazandın;
                    }
                else
                    {
                    // lose by rolling 7 before point (7 atarak kaybetmek)
                    if (zarToplami == (int)Zarİsimleri.Seven)
                        {
                        gameStatus = Durum.Kaybettin;
                        }
                    }
                }
            // Durum mesajını ekrana bas
            if (gameStatus == Durum.Kazandın)
                {
                Console.WriteLine("Kazandınız.");
                }
            else
                {
                Console.WriteLine("Kaybettiniz.");
                }
            }
        // Zarları at, Hesapla ve Sonuçları Göster
        static int ZarAt()
            {
            // Rastgele zar atışları
            int zar1 = rastgeleSayi.Next(1, 7); // zar1
            int zar2 = rastgeleSayi.Next(1, 7); // zar2

            int toplam = zar1 + zar2; // Zarların değerleri toplamı

            // Sonuçları göster
            Console.WriteLine($"Oyuncunun attığı zar {zar1} + {zar2} = {toplam}");
            return toplam;             // Zarların Toplamı
            }
        }
    }
