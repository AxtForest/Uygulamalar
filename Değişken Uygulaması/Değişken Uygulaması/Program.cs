using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Değişken_Uygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            void DegiskenUyg()
            {
                int sayi = 23;// bir değişken atadık
                sayi = sayi * 2;//sayının değeri değişti
                Console.WriteLine(sayi);//sayımızı ekrana yazdırdık
                int max, min, a;// bir değer atamazsak otomatik 0 değerinin döndürür(atar)

                max = System.Int16.MaxValue;//int değişkeninin max ve min değeri (16bit)
                min = System.Int16.MinValue;
                Console.WriteLine("İnt16 degiskeninin max degeri : " + max);
                Console.WriteLine("İnt16 degiskeninin min degeri :" + min);



                max = System.Int32.MaxValue;//int değişkeninin max ve min değeri (32bit)
                min = System.Int32.MinValue;
                Console.WriteLine("İnt32 degiskeninin max degeri : " + max);
                Console.WriteLine("İnt32 degiskeninin min degeri :" + min);


                byte minbyte, maxbyte;
                minbyte = System.Byte.MinValue;
                maxbyte = System.Byte.MaxValue;
                Console.WriteLine("byte degiskeninin max degeri : " + maxbyte);
                Console.WriteLine("byte degiskeninin min degeri :" + minbyte);

                Console.ReadLine();
            }
        }
    }
}
