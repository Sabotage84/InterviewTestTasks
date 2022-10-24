using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetDataFromServer
{
    class Program
    {
        static void Main(string[] args)
        {
            HTTPGetter test = new HTTPGetter();

            string t= (string)test.GetData(@"https://ptime.ru/robots.txt");
            Console.WriteLine(t);
            Console.ReadLine();
        }
    }
}
