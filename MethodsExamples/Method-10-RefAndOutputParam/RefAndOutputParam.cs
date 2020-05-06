// Referans ve Çıkış Parametreleri
//
using System;

namespace Methods_5
    {
    class ReferenceAndOutputParameters
        {
        // call methods with reference, output and value parameters
        static void Main()
            {

            int y = 5;  // y 5 ile başlatılıyor.
            int z;      // z deklare ediliyor (bildir) başlangıç değeri verilmiyor 


            // y ve z'nin başlangıç değerlerini göster 
            Console.WriteLine($"y'nin ilk değeri: {y}");
            Console.WriteLine("z'nin ilk değeri: değer verilmemiş\n");


            SquareRef(ref y);
            SquareOut(out z);

            Console.WriteLine($"y'nin KareReferans sonrası değeri: {y}");
            Console.WriteLine($"z'nin Kare Referanstan üretilmiş değeri: {z}\n");

            Square(y);
            Square(z);

            Console.WriteLine($"y'nin Kare değeri: {y}");
            Console.WriteLine($"z'nin Kare değeri: {z}");

            static void SquareRef(ref int x)
                {
                x = x * x;
                }

            static void SquareOut(out int x)
                {
                x = 6;
                x = x * x;
                }

            static void Square(int x)
                {
                x = x * x;
                }
            Console.ReadLine();
            }
        }
    }