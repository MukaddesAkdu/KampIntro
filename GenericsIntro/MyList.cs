﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    //T= type, tip. T yerine istediğini yazabilirsin.ancak bu tip genericler yazılırken bir tane değer alıyorsa genelde o T olarak yazılır.
    class MyList<T> 
    {
        T[] items;
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)    //Add metodu //item = eleman
        {
            T[] tempArray = items;     //tempArray = geçici dizi
            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }

        //aşağıdaki kısımlar sadece test etmek için yazıldı. 
        //eleman sayısını verir:
        public int Length
        {
            get { return items.Length; }
        }

        //elemanları görmek için şu yapılır:
        public T[] Items

        {
            get { return items; }
        }
    }
}
