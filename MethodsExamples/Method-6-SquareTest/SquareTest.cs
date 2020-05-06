using System;

namespace Method_6
    {
    class SquareTest
        {
        static void Main()
            {
            int x = 10; // value to square (local variable in Main)
            Console.WriteLine($"x karesi: {Square(x)}");  // Square metotu aşağıda tanımlanıyor ve buraya döndürülüyor. (return ediliyor) 
            }
        // aşağıdaki metot bir tamsayının(int) karesini döndürür. Main Class'ında ki statik değişkeni çağırır.
        static int Square(int y) // y Square metodundaki lokal bir değişkendir.
            {
            return y * y; // kare y değişkeni ile hesaplanır ve sonucu Main Class'ında ki Square 'e döndürür. callback stack
            }
        }
    }
