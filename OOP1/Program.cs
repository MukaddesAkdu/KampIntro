using System;

namespace OOP1
{
    class Program
    {
        //main, ekran görevi görür. manager classı iş yapan classdır. 
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            //numara 2 mobilyaya denk geliyor yani kategorisini gösteriyor. daha sonra kategorisi değişebilir, kodu değil veri kaynağını değiştiririz.
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;
            //bunu bir yukarıdaki gibi bir de aşağıdaki gibi oluşturabiliriz.
            //direkt classın hemen yanında, alanları yukarıdaki gibi ayrı ayrı yazmadan direkt yazabiliriz.
            Product product2 = new Product { Id=2, CategoryId=5, ProductName="Kalem", UnitsInStock=5, UnitPrice=35};

            //PascalCase    camelCase
            ProductManager productManager = new ProductManager();
            // ='in sağ tarafı stack; sol tarafı heap.
            //yukarıdaki satırın anlamı: ProductManager türündeki productManager yeni bir referans numarası almış ProductManager'dır.
            //string isim = "Engin"
            productManager.Add(product1);
            //bunu yazınca product1'i ProductManager'a gönderecek.
            Console.WriteLine(product1.ProductName);


            productManager.Topla2(3,6);

            int toplamaSonucu = productManager.Topla(3, 6);
            Console.WriteLine(toplamaSonucu*2);
            //şöyle de çalışır:
            Console.WriteLine(productManager.Topla(3, 6) * 2);


            int sayi = 100;
            productManager.BiseyYap(sayi);
            Console.WriteLine(sayi);
        }
    }
}
