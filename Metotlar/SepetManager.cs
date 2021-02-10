using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention - isimlendirme kuralı  Ekle'nin E'si büyük.
        //ekle yazsakta çalışır ama kodun okunurluğunu arttırmak için Ekle yazıyoruz. doğrusu budur.
        //eğer bir yerde normal parantez () varsa orada metot çalışıyor demektir. c# ve java için
        public void Ekle(Product product)
        {
            Console.WriteLine("Sepete Eklendi : " + product.Adi);
        }
        //şuan uygulamamız bir parametre,metodumuz parametre alıyor. parantez içinde yazan: (Product product) kısmı 
        //bu parametrenin tipi Product.
        //void Ekle(Product product) : bu kısma imza denir. yazım şeklin, metodun imzaya uymalıdır.
        //sen bunu çağıracak kişinin, product'ı parametre olarak vermesi gerektiğini söylemişsin. çünkü ne ekleyeceğini bilmek ister.

        //bir classın içinde birden fazla metot olabilir.
        //bu şu demek ben ürünü eklicem ama bana ürünün adını,açıklamasını,fiyatını verki ben gidip veri kaynağına üçünü birden ekleyeyim.
        public void Ekle2(string Adi, string Aciklama, double Fiyati)
        {
            Console.WriteLine("Sepete Eklendi : " + Adi);
            //(string Adi, string Aciklama, double Fiyati) : böyle de yazabilirsin ama yazmamalısın
            //ürünü böylede gönderebilirsin ama bu yöntemi değil classı kullanıyoruz?
            //bu özellikleri ayrı ayrı yazınca class olmuyor. bunların tamamını içeren kolay yapıya class deniyor. (Product classı)
        }
    }
}
