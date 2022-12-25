using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{   //generic class demek kendi type classını oluşturmak demek. string gibi double gibi int gibi vs vs..
    // List 'de sadece string yazabilirsin.
    internal class MyList<T> //T tipiyle ekleyeceğim, rastgele bir tip.
    {
        T[] items;

        //constructor
        public MyList()
        {
            items = new T[0];
        }
        
        public void Add(T item) //item: eleman
        {
            T[] tempArray = items;  //geçici dizi: tempArray, yeni veri ekledikten sonra önceki değerleri korumak için tutulur.
            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length-1] = item;
        }
    }
}
