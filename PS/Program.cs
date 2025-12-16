using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS
{
    internal class Program
    {
        public static string GetShortestString(List<string>list)
        {
            string str = list[0];
            foreach(string item in list)
            {
                if(item.Length<str.Length)
                {
                    str = item;
                }
            }
            return str;
        }
        static void Main(string[] args)
        {
            List<string>list = new List<string>();
            list.Add("Kamal");
            list.Add("Ali");
            list.Add("Osama");
            list.Add("Mohamed");
            list.Add("O");
            string shortest_string = GetShortestString(list);
            Console.WriteLine(shortest_string);
        }
    }
}
