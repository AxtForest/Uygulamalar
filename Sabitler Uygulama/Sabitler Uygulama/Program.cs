using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sabitler_Uygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            const int a = 10;// Bu tanımın degeri her zaman 10 olacaktır (const) sabitler sabitlere katılabilir 
                             // static const birlikte kullanılamaz
                             // static const int c=23; bu ifade hatalıdır

            const int b = 20 + 11;//Sabitler sabitlere katılabilir

            //Sabitler oluşturuduğu anda deger almalıdır 
            // Eger vermek istemezsek readonly kullanabiliriz fakat yapılandırıcı sınıf gereklidir 
            // Yapılandırıcı sınıf nasıl yapılır:: main class ile aynı adda bir fonksiyon oluşturulur(geri dönmeyen) bir üst satıra ile readonly deyimi olur fonksiyon içine ile readonly degeri atanır

            Console.WriteLine(a);

            

          
        }
        //Sabitler oluşturuduğu anda deger almalıdır 
        // Eger vermek istemezsek readonly kullanabiliriz fakat yapılandırıcı sınıf gereklidir 
        // Yapılandırıcı sınıf nasıl yapılır:: main class ile aynı adda bir fonksiyon oluşturulur(geri dönmeyen) bir üst satıra ile readonly deyimi olur fonksiyon içine ile readonly degeri atanır
        // bunlar main dışında gerçekleşir

        readonly int abc;
        public Program()
        {
            abc=29+2;
        }

    }
}
