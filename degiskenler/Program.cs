using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("""");
            
            byte b=5;        //1 byte
            sbyte c=5;       //1 byte

            short s = 5;     //2 byte
            ushort us =5;    // 2 byte
            Int16 i16 =2;    //2 byte
            int i =2;        //4 byte
            Int32 i32=2;     //4 byte
            Int64 i64 =2;    //8 byte

            uint ui=2;      //4 byte
            long l=4;       //8 byte
            ulong ul=4;     //8 byte
             
             //Reel sayılar
            float f=5;     //4 byte
            double d =5 ;  //8 byte
            decimal de = 5; // 16 byte

            char ch ='2';              //2 byte
            string str ="rümeysa"     //sınırsız

            bool b1=true;
            bool b2 =false;

            Datetime dt=Datetime.Now; //o an

            object o1="x";
            object o2="y";
            object o3=4;
            object o4=4.3;

            //string ifadeler

            string str1 =string.Empty;
            str1="Bilgi programcılıgı";
            string ad= "bilgi";
            string soyad="programcılıgı";
            string tamisim=ad+" "+soyad;


            //integer tanımlama şekilleri
            int integer1 = 5;
            int integer2 =3;
            int integer3=integer1+integer2;

            //boolean
            bool bool1 =10>2;

            //değişken dönüşümleri
            string str20 ="20";
            int int20 =20
            string yeniDeger=str20 + int20.ToString(); //çıktısı 2020

            int int21=int20 + Convert.ToInt32(str20);//çıktısı 40

            int int22 =int20 + int.Parsel(str20);//çıktısı 40

            //Datetime

            string datetime=Datetime.now.ToString("dd.MM.yyyy");//çıktısı 17.04.2021
            string datetime2=Datetime.now.ToString("dd/MM/yyyy");//çıktısı 17/04/2021
            string hour=Datetime.now.ToString("HH:mm");


            
        }
    }
}
