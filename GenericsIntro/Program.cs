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

        }
    }
}
