using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, float> weights = new Dictionary<string, float>();

            weights.Add("2016/12/10", 41.2f);
            weights.Add("2016/12/11", 42.5f);
            weights.Add("2016/12/12", 44.9f);
            weights.Add("2016/12/13", 43.2f);
            weights.Add("2016/12/14", 43.2f);
            weights.Add("2016/12/16", 41.7f);

            Console.WriteLine(weights["2016/12/13"]);

            //List<float> weights = new List<float>();

            //weights.Add(41.2f);
            //weights.Add(42.5f);
            ////   weights.Add(3.2f);
            //weights.Add(44.9f);
            //weights.Add(43.2f);
            //weights.Add(43.2f);
            //weights.Add(42.7f);
            //weights.Add(41.7f);

            ////weights.RemoveAt(2);
            //weights.Sort();

            //for(int i = 0; i < weights.Count; i++)
            //{
            //    Console.WriteLine(weights[i]);
            //}
            //Console.WriteLine(weights.IndexOf(43.2f));

            //List<string> names = new List<string>();

            //names.Add("AAA");
            //names.Add("BBB");
            //names.Add("CCC");

            //for (int i = 0; i < names.Count; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}
        }
    }
}
