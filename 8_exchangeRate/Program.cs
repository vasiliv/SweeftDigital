using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _8_exchangeRate
{
    class Program
    {        
        static void Main(string[] args)
        {
            double usdToGel = exchangeRate("USD", "GEL");
            Console.WriteLine(usdToGel);

            double eurToGel = exchangeRate("EUR", "GEL");
            Console.WriteLine(eurToGel);

            Console.ReadLine();
        }
        static double exchangeRate(String from, String to)
        {
            string result = RssFeed();
            if (from == "USD" && to == "GEL")
            {
                string usdResult = result.Substring(result.IndexOf("USD"), 47);
                return Convert.ToDouble(usdResult.Substring(41));
            }
            else if (from == "EUR" && to == "GEL")
            {
                string eurResult = result.Substring(result.IndexOf("EUR"), 41);
                return Convert.ToDouble(eurResult.Substring(35));
            }
            else
                return 0;
        }
        static string RssFeed()
        {
            WebRequest webRequest = WebRequest.Create("http://www.nbg.ge/rss.php");
            using (var response = webRequest.GetResponse())
            using (var content = response.GetResponseStream())
            using (var reader = new StreamReader(content))
            {
                 return reader.ReadToEnd();                 
            }
        }
    }
}
