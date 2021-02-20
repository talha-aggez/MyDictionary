using System;

namespace MyDictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            DictionaryExample<int, string> brandList = new DictionaryExample<int, string>();

            brandList.Add(1, "BMW");
            brandList.Add(2, "Honda");

            brandList.List();
        }
    }
}
