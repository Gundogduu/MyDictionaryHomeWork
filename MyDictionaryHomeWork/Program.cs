using System;

namespace MyDictionaryHomeWork
{
    class Program
    {
        public static void Main(string[] args)
        {
            MyDictionary<string> isimler = new MyDictionary<string>();
            isimler.Add("Mahmud Nergis");
            isimler.Add("Hayri Gündoğdu");
            isimler.Add("Ebru Demir");
            isimler.Add("Malhun Çiçek");
            Console.WriteLine("Eleman sayısı: " + isimler.Count);
            isimler.GetAll();

        }
    }
}
