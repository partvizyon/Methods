// Girilen 3 Ondalık Sayıdan en büyük olanını bulur.
using System;

namespace Methods_1
    {
    class MaximumFinder
        {
        static void Main()      // satatic   -class'ın hafıza da yönetilmesi- ile ilgilidir. 
            {
            // prompt from and input three floating-point values
            Console.Write("1. Ondalıklı Sayıyı giriniz: ");
            double number1 = double.Parse(Console.ReadLine());
            Console.Write("2. Ondalıklı Sayıyı giriniz: ");
            double number2 = double.Parse(Console.ReadLine());
            Console.Write("3. Ondalıklı Sayıyı giriniz: ");
            double number3 = double.Parse(Console.ReadLine());

            // determine the maximum of three values
            // 3 girdiden en yüksek değeri belirle
            double result = Maximum(number1, number2, number3);

            //display maximum value
            // En yüksek değeri ekrana bas
            Console.WriteLine("Maximum is: " + result);
            Console.Read();
            }

        static double Maximum(double x, double y, double z)
            {
            double maximumValue = x;        // assume x is the largest to start (Başlangıçta x'in en büyük olduğunu varsayalım)

            if (y > maximumValue)           // y'nin büyük olup olmadığını belirle "MaximumValue" den (Yani x den)
                {
                maximumValue = y;
                }
            if (z > maximumValue)           // z'nin büyük olup olmadığını belirle "MaximumValue" den (Yani x den)
                {
                maximumValue = z;
                }
            return maximumValue;
            }
        }

    }
