using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T,A>
    {
        T[] Keys;
        A[] Values;
        public MyDictionary()
        {
            Keys = new T[0];
            Values = new A[0];
        }

        public void Add(T Key, A Value)
        {
            T[] tempArray1 = Keys;
            A[] tempArray2 = Values;

            Keys = new T[Keys.Length + 1];
            Values = new A[Values.Length + 1];

            for (int i = 0; i < tempArray1.Length; i++)
            {
                Keys[i] = tempArray1[i];
            }

            for (int i = 0; i < tempArray2.Length; i++)
            {
                Values[i] = tempArray2[i];
            }


            Keys[Keys.Length - 1] = Key;
            Values[Values.Length - 1] = Value;
        }


           public int CountKeys
        {
            get { return Keys.Length; }
        }


        public int CountValues
        {
            get { return Values.Length; }
        }
    
    }
}
