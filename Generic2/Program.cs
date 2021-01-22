using System;

namespace Generic2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string>();
            myList.Add("Kemal");
            myList.Add("aysel");
            myList.Add("mahmut");
            myList.Add("arif");
            myList.Add("melike");
            Console.WriteLine(myList.Count);
        }
    }
    class MyList<K>
    {

        K[] _array;
        K[] _TempArray;
        public MyList()
        {
            _array = new K[0];
        }

        public void Add(K item)
        {
            _TempArray = _array;
            _array = new K[_array.Length + 1];
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

        
    
