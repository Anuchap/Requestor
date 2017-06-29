using System;
using System.Net;

namespace Requestor
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                foreach (var url in args)
                {
                    var request = (HttpWebRequest)WebRequest.Create(url);
                    using (var response = (HttpWebResponse)request.GetResponse())
                    {
                        Console.WriteLine(response.StatusCode);
                    }
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}