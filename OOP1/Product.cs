using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //bu tip classlarda sadece özellik olur.
    class Product
    {
        //ana anahtar Id'dir çünkü veriyi anlatan budur. Id numarası ona özeldir.
        public int Id { get; set; }
        //ürünün hangi kategoride olduğunu belirtmek için kategorileri numaralandırırız. CategoryId = referans anahtarı
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        //ürünün stok adedi
        public int UnitsInStock { get; set; }

        //CRUD (CREATE READ UPDATE DELETE) operasyonları
    }
}
