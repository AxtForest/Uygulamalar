using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Örnek_soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random sayısı için random nesnesi oluşturdum
            Random random1;
            //Gerekli atamaları yaptım
            int toplam, dogrucevap, puan = 0, dogru = 0, yanlis = 0;

            //random sayı aldım
            random1 = new Random();
            //programın devam etmesi için bir devam harfi koydum
            char devam;
            do
            {


              
                //random sayıları oluşturdum ve ekrana yazdırdım
                int sayi1 = random1.Next(1, 101);

                int sayi2 = random1.Next(1, 101);

                Console.WriteLine("Birinci Sayi :" + sayi1);

                Console.WriteLine("İkinci Sayi :" + sayi2);

                dogrucevap = sayi1 + sayi2;
                //kullanıcıdan toplam degerini aldım
                Console.WriteLine("Bu İki Sayinin Toplami Nedir ?");

                toplam = Convert.ToInt32(Console.ReadLine());
                //eğer kullancının girdiği deger toplama eşitse 
                if (toplam == dogrucevap)
                {
                    Console.WriteLine("Tebrikler Cevabiniz Dogru");
                    puan = puan + 5;
                    dogru = dogru + 1;
                }//yanlışsa
                else
                {
                    Console.WriteLine("Yanlis Cevap");
                    puan = puan - 2;
                    yanlis = yanlis + 1;
                }
                //devam etmek için chara deger aldım
                Console.WriteLine("Devam Etmek İstiyormusunuz E/H");

                devam = Convert.ToChar(Console.ReadLine());
            }
            while (devam == 'e' || devam =='E');
            { }//oyun bittikten sonra dogru yanlışı ve puanı gösteren kodları yazdım
            Console.WriteLine("Oyun Bitti");

            Console.WriteLine("Dogru Cevap Sayisi :" + dogru);

            Console.WriteLine("Yanlis Cevap Sayisi :" + yanlis);

            Console.WriteLine("Puan :" + puan);

            Console.ReadLine();
        }
    }
}
