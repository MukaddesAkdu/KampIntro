using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            /*şimdi toplama işlemi yapıcam. benim zaten toplama işlemini yapan metodum var. o metot dortıslem classının
            içinde olduğu için o classdan bir tane örnek oluşturmam lazım.*/
            DortIslem dortIslem = new DortIslem();
            //dörtişlemin içinde topla olduğu için
            dortIslem.Topla(5, 6);
            //parametrenin parametre olmasının sebebi değişken olmasıdır. parametreler değişken olanlardır.
            dortIslem.Topla(6, 10);
        }
    }
}
