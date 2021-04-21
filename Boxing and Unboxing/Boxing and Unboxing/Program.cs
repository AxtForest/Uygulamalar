using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing_and_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {


            // kutulama - boxing

            int i = 30;//Değer türünde olan bir değişken tanımladık

            //Değer türünün bir değeri var Referans türünün ise bir değeri
            //yoktur referans aldığı yere göre işlem yapar

            object o = i; //Referans türünde bir değişken tanımladık ve Kutulama(boxing)
                          //yaptık bir Referans değeri aldık -- bir nevi kopyalama gibi


            // kutudan çıkarma - unboxing

            i *= 2;// i = i*2; i'yi 2 ile çarptık değeri 46 oldu 

            i = (int)o; // (int) diyerek int olan bir değişkene  object türünde bir değer alıyoruz


            //(o nun değerini  i ye atıyoruz) ve i değeri tekrar 30 degerini alıyor 


            Console.WriteLine("Deger turu: {0}", i);
            Console.WriteLine("Referans turu: {0}", o);



            Console.ReadLine();
        }
    }
}
