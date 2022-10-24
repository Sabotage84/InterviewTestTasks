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
        public object GetData(string path)
        {
            object res=null;

            using (var client = new WebClient())
            {
                try
                {
                    using (Stream stream = client.OpenRead(path))
                    {
                        using (StreamReader reader = new StreamReader(stream))
                        {
                            res = reader.ReadToEnd();
                        }
                    }
                }
                catch (WebException e)
                {

                    res = "File or server not found!\n"+ path+"\n";
                    res += e.Message;
                }
                
            }

            return res;
        }

        public string GetString(string path)
        {
           string res = "";
            try
            {
                using (var client = new WebClient())
                {
                    using (Stream stream = client.OpenRead(path))
                    {
                        using (StreamReader reader = new StreamReader(stream))
                        {
                            res = reader.ReadToEnd();
                        }
                    }
                }
            }
            catch(WebException e)
            {
                res = "File or server not found!\n" + path + "\n";
                res += e.Message;
            }

            return res;
        }

    }
}
