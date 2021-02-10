using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Don't repeat yourself - Clean Code(temiz kod yazma) - Best Practice(doğru uygulama teknikleri)
            /*string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";
            //Bunların hepsinin bir ürünü tanımladığını ifade etmekte zorlanıyoruz. neyin ne olduğu belli değil.

            string[] meyveler = new string[] {"Elma" , "Karpuz" }; */

            //bir class tanımlamak için şunu yazmak gerekir. buna classın örneği denir.
            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya elması";
            product1.Id = 1;

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 20;
            product2.Aciklama = "Diyarbakır karpuzu";
            product2.Id = 2;
            //bu veriler bir veri kaynağından gelir.

            Product[] products = new Product[] {product1 , product2 };

            //aşağıdaki Product, veri tipidir. product aliasdır yani takma isim. veri tipini yazmamızın nedeni ise C#'ın tip güvenli bir dil olmasıdır.
            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine(product.Id);
                Console.WriteLine("-------------------");
            }

            Console.WriteLine("--------------Metotlar--------------");

            //instance - örnek,class örneği
            SepetManager sepetManager = new SepetManager();
            //metodu şu şekilde çağırıyoruz:
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12);
            sepetManager.Ekle2("Elma", "Amasya elması", 15);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 20);
            /*ürünü böylede gönderebilirsin ama bu yöntemi değil classı kullanıyoruz?
            niye class olarak parametre ekledim : (product1); niye yukarıdaki gibi tek tek yazmadım?
            ama ekle2'yi çağırdığımız 3 tanesi aslında farklı sayfalardır. yönetim dediki ürünün stok adedini de yazalım.
            sen bide sepetmanager'da parametre eklersin, int stokAdedi dersin, ekle2'nin yapacağı işi değiştirirsin.
            program.cs'de ise böyle yapınca tüm sayfalar error verir çünkü sen imzaya uymadın.
            yani senin bütün sayfaları değiştirmen gerekir.
            ama diğer türlü class parametresini eklediğin zaman sadece yeni bir özellik eklersin product.cs'ye.
            public int StokAdedi {get; set;}  : sen ürünü eklediğin zaman bunu da dahil etmiş oldun.
            buna Encapsulation - kapsülleme denir. sen ayrı ayrı yazılan, düzensiz olan bir yapıyı bir düzenin içine sokmuş oluyorsun*/
        }
    }
}
