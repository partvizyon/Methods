using System;

namespace Method_2
    {
    class RandomIntegers
        {
        static void Main()
            {
            Random randomNumbers = new Random();    // Rastgele sayı üretme

            // Loop (Döngü) 20  kez
            for (int counter = 1; counter <= 20; ++counter)
                {
                // 1 ile 6 arası rastgele bir sayı seç
                int face = randomNumbers.Next(1, 7);
                Console.Write($"{face}  ");
                }
            Console.WriteLine();
            Console.Read();
            }
        }
    }
