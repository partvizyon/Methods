// Scope Class statik ve yerel değişken kapsamlarını gösterir.
// Class içinde tanımlanan bir değişkeni herhangi bir metot değiştirebilir. Değiştirilmiş hali Obje ile birlikte yaşar.
// O obje var olduğu sürece yaşamaya devam eder. Değiştirildiği zaman son hali tutulur.
// Metot içinde tanımlanan değişken ise metot çalıştırıldıktan sonra hafızadan silinir. 
// aynı Metot tekrar çağrıldığında değişken ilk değeri ile başlatılır.
using System;

namespace Method_5
    {
    class Scope
        {
        private static int x = 1;  // Statik değikene   SCOPE sınıfının tüm metotları erişebilir.

        // Main içinde oluşturularak başlatılan local x değişkeni
        // UseLocalVariable ve Use StaticVariable metodları tarafından çağırılır.
        static void Main()
            {
            int x = 5;   // Main clasının local değişkeni olan x'i  static değişken olan x gizler 

            Console.WriteLine($"local x in method Main is {x}");

            // UseLocalVariable kendi lokalinde x değişkenine sahip  
            UseLocalVariable();

            // UseStaticVariable ise SCOPE clasındaki statik x değişkenini kullanır.
            UseStaticVariable();

            // UseLocalVariable kendi lokalindeki x değişkenine ulaşır.
            UseLocalVariable();

            // SCOPE class'ındaki x değişkeninin değerini korur.
            UseStaticVariable();

            Console.WriteLine($"\nlocal x in method Main is {x}");
            }
        // Lokaldeki x değişkeni her çağrıldığında oluşturularak başlatılır. 
        static void UseLocalVariable()
            {
            int x = 25;  // UseLocalVariable her çağrıldığında başlatılır

            Console.WriteLine($"\nlocal x on entering method UseLocalVariable is {x}");
            ++x; // Bu metotun yerel değişkeni x' i değiştirir

            Console.WriteLine($"local x before exiting method UseLocalVariable is {x}");
            }
        static void UseStaticVariable()
            {
            Console.WriteLine("\nstatic variable x on entering method" + $"UseStaticVariable is {x}");
            x *= 10; // SCOPE Clasının lokal değişkeni olan x(1) ile kullanılır. Yani sonuç 1 * 10 = 10 olur. 

            Console.WriteLine("static variable x before exiting " + $"method UseStaticVariable is {x}");
            }
        }
    }
