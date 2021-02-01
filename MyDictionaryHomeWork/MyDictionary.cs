using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryHomeWork
{
    class MyDictionary<T>
    {   //class  cagırıldıgında direkt olusan bos liste
        T[] _array;
        //gecici liste
        T[] _tempArray;
        public MyDictionary()
        {   //constructor icinde newledik cünkü direkt calismasini istedik.
            _array = new T[0];
        }
        public void Add(T item)    //item kullanıcının gönderdigi string
        { //burada _array'i geciciliste'ye aktardık.Cünkü her eleman eklendiginde bellekte yeni bir referans no alacak ve eski no'daki elemanlar kaybolacak.Bunu engellemek icin.
            _tempArray = _array;
            //burada yeni bir _array listesi olusturduk ve eleman sayını 1 artır dedik.
            _array = new T[_array.Length + 1];
            //burada geciciliste emanet ettigimiz elemanları _array listesine geri aldık.
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            //kullanıcının gonderdigini dizinin son elemanına ekliyoruz.
            _array[_array.Length - 1] = item;
        }

        //kendi Count attribute'umuzu yaptık.
        //_array listesinin eleman sayısını getir dedik.
        public int Count
        {
            get { return _array.Length; }
        }

        public void GetAll()
        {
            Console.WriteLine("----İsimler----");
            foreach (T isim in _array)
            {
                Console.WriteLine(isim);
            }
        }

    }
}
