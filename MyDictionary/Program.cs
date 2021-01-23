using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();  //string : runner , int: time (m/min)
            myDictionary.Add("Aydemir", 30);
            myDictionary.Add("UsainBolt", 70);
            myDictionary.Add("Powel", 60);

            Console.WriteLine(myDictionary.CountKeys);
            Console.WriteLine(myDictionary.CountValues);

          

        }
    }
}
