using System;

namespace Method_3
    {
    class RollDie
        {
        static void Main()
            {
            Random randomNumbers = new Random();    // Rastgele sayı üretme

            int frequency1 = 0;     // 1 kaç defa geldi (60 milyonda)
            int frequency2 = 0;     // 2 kaç defa geldi (60 milyonda)
            int frequency3 = 0;     // 3 kaç defa geldi (60 milyonda)
            int frequency4 = 0;     // 4 kaç defa geldi (60 milyonda)
            int frequency5 = 0;     // 5 kaç defa geldi (60 milyonda)
            int frequency6 = 0;     // 6 kaç defa geldi (60 milyonda)

            for (int roll = 1; roll <= 60000000; ++roll)
                {
                int face = randomNumbers.Next(1, 7);

                switch (face)
                    {
                    case 1:
                        ++frequency1; // 1'ler sayacı
                        break;
                    case 2:
                        ++frequency2; // 2'ler sayacı
                        break;
                    case 3:
                        ++frequency3; // 3'ler sayacı
                        break;
                    case 4:
                        ++frequency4; // 4'ler sayacı
                        break;
                    case 5:
                        ++frequency5; // 5'ler sayacı
                        break;
                    case 6:
                        ++frequency6; // 6'lar sayacı
                        break;
                    }
                }
            Console.WriteLine("Face\tFrequency");
            Console.WriteLine($"1\t{frequency1}\n2\t{frequency2}");
            Console.WriteLine($"3\t{frequency3}\n4\t{frequency4}");
            Console.WriteLine($"5\t{frequency5}\n6\t{frequency6}");
            }
        }
    }
