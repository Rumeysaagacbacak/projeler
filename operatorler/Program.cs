﻿using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Atama ve işlemli atama ****");
            //Atama ve işlemli atama
            int x =3;
            int y =3;
            y=y+2;

            Console.WriteLine(y);
            y+=2;
            Console.WriteLine(y);
            y/=1;
            Console.WriteLine(y);
            x+=2;
            Console.WriteLine(x);

            Console.WriteLine("****mantıksal operatörler ****");
            //mantıksal operatörler
            // || ,&&,!

            bool isSuccess=true;
            bool isCompleted=false;

            if(isSuccess &&isCompleted)
               Console.WriteLine("Perfect");

            if(isSuccess || isCompleted)
               Console.WriteLine("Great");
            
              if(isSuccess &&! isCompleted)
               Console.WriteLine("Fine");

          Console.WriteLine("****İlişkisel Operatörler ****");
          //İlişkisel operatorler
          //<,>,<=,>=,==,!=

          int a=3;
          int b=4;
          bool sonuc =a<b;
          Console.WriteLine(sonuc);
          sonuc =a>b;
          Console.WriteLine(sonuc);
          sonuc=a>=b;
          Console.WriteLine(sonuc);
          sonuc=a<=b;
          Console.WriteLine(sonuc);
          sonuc=a==b;
          Console.WriteLine(sonuc);
          
          Console.WriteLine("****Aritmetik operatörler ****");
          //, *,+,-,
          int sayi1=10;
          int sayi2=5;
          int sonuc2 =sayi1/sayi2;
          Console.WriteLine("sonuc2");
          sonuc2=sayi1*sayi2;
          Console.WriteLine("sonuc2");
          sonuc2=sayi1+sayi2;
          Console.WriteLine("sonuc2");
          sonuc2=sayi1++;
          Console.WriteLine("sonuc2");
          
          //mod % : mod alır
          int sonuc1=20%3;
          Console.WriteLine("sonuc1");
        }
    }
}
