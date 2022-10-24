using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GetDataFromServer
{
    public class HTTPGetter
    {
        string addres;

        public string Addres { get => addres; set => addres = value; }

        public object GetData(string path)
        {
            object res=null;

            using (var client = new WebClient())
            {
                
                Stream stream = client.OpenRead("https://ptime.ru/robots.txt");
                StreamReader reader = new StreamReader(stream);
                res = reader.ReadToEnd();
            }

            return res;
        }

    }
}
