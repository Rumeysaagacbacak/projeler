using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            //buranın içerisine hataya neden olacak kodu yazıyoruz.
            /*
            //hata alsada almasada bu mesajı gösteririz.
           // finally
            //{
            //    Console.WriteLine("İşlem tamamlandı."); 
           // }*/
           try
           {
               //int a =int.Parse(null);
               // int a =int.Parse("test");
                int a =int.Parse("-20000000000");
           }
           catch (ArgumentNullException ex)
           {
               Console.WriteLine("Boş değer girdiniz");
               Console.WriteLine(ex);
           }
           catch (FormatException ex)
           {
               Console.WriteLine("Veri tipi uygun değil");
               Console.WriteLine(ex);
           }
           catch (OverflowException ex)
           {
               Console.WriteLine("Çok büyük veya çok küçük değer girdiniz");
               Console.WriteLine(ex);
           }
           finally
           {
               Console.WriteLine("İşlem başarıyla tamamlandı.");
           }
           
            
        }
    }
}
