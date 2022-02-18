using System;

namespace donguler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //while
            //satırdaki ifade doğru oldugu sürece parantez içerisi üsrekli döner

           
           //1 den başlayarak consoledan girilen sayıya kaadar (sayı dahil) ortalama hesaplayıp console yazdıran program
            Console.WriteLine("Lütfen bir sayı giriniz:");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1 ; //1 den başlaması için 
            int toplam = 0;
            while (sayac <= sayi) //sayac sayıya kücük olana kadar sürekli dön anlamında
            {
                toplam +=sayac;
                sayac++;
            }
            Console.WriteLine(toplam/sayi);

            //adan zye kadar tüm harfleri konsole yazdıralım
            char  character='a';
            while (character < 'z')
            {
                Console.Write(character );
                character++;
            }
            
            Console.WriteLine("****Foreach****");
            string[] arabalar = {"BMV","Ford","Toyata","Nissan"};
            
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }


        }
    }
}
