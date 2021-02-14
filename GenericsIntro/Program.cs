using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyList isimler = new MyList();   böyle olmaz.

            MyList<string> isimler = new MyList<string>();
            isimler.Add("Engin");

            //aşağıdaki kısımlar test etmek için yazıldı.
            Console.WriteLine(isimler.Length);

            isimler.Add("Kerem");
            Console.WriteLine(isimler.Length);

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }
        }
    }
}
