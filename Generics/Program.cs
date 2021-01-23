using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("ankara");

            sehirler.Add("ankara");
            sehirler.Add("ankara");
            sehirler.Add("ankara"); 
            sehirler.Add("ankara");
            sehirler.Add("ankara");
            Console.WriteLine(sehirler.Count);
            
            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Samsun");
            sehirler2.Add("Samsun");
            sehirler2.Add("Samsun");
            sehirler2.Add("Samsun");
            sehirler2.Add("Samsun");
            sehirler2.Add("Samsun");

            Console.WriteLine(sehirler2.Count);
        }
    }
    class MyList<T>
    {
        T[] _array;
        T[] _TempArray;
        public MyList()
        {
            _array = new T[0];
        }
        
        public void Add(T item)
        {
            _TempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _TempArray.Length; i++)
            {
                _array[i] = _TempArray[i];
            }
            _array[_array.Length - 1] = item;
        }

        public int Count
        {
            get { return _array.Length; }
            
        }


    }
}
