using System;

namespace döngüler_for_loop
{
    class Program
    {
        static void Main(string[] args)
        { /*
            //ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır.
            //belli şartları birden fazla kullanmak için
            Console.Write("Lütfen bir sayı giriniz:");
            int sayac=int.Parse(Console.ReadLine());
            for (int i = 1; i <= sayac; i++)
            { //komutlar 
                if(i%2 == 1)
                  Console.WriteLine(i);  

            }

            //1-1000 arasındaki tek ve çift sayıların toplamınım hesaplayan program
             
            int tektoplam = 0;
            int cifttoplam = 0;

            for (int i = 1; i <= 1000; i++)
            {
                if(i%2 == 1)
                   tektoplam += i; //tektoplam=tektoplam+1;
                else
                 cifttoplam += i;     
            }
            Console.WriteLine("Tek toplam:" + tektoplam);
            Console.WriteLine("Çift toplam:" + cifttoplam);
            */
            //break,continue 
            //break döngü sonlandırmak için kullanılır.
            //continue bir şarta bağla olarak o bölümünü atlamak istiyorsanız 
 
            //break ile deniyoruz 
            //4de durdu devam etmedi.
            for (int i = 1; i < 10; i++)
            {
                if(i==4)
                  break;
                Console.WriteLine(i);
            }
            //contiune ile deniyoruz
            //sadece 4 atladı
            for (int i = 1; i < 10; i++)
            {
                if(i==4)
                  continue;
                Console.WriteLine(i);
            }
        }
    }
}
