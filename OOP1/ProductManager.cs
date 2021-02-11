using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //bir ürün ekliceksek bu ekleme operasyonuna neyi ekliceğini söylememiz gerekir.
        //beni ProductManager'ın içinden çağıracaksın, benim adım Add, parametre olarak bana bir tane Product yolla
        //buraya Product türünde bir şey gönderince burası onu product ismiyle tutuyor olacak.
        public void Add(Product product)
        {
            //product.ProductName = "Kamera";
            Console.WriteLine(product.ProductName + " eklendi.");
        }
        //Add ve Update operasyonları
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2); 
        }



        public void BiseyYap(int sayi)
        {
            sayi = 99;
        }
    }
}
