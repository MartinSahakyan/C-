using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace AssembliesAndNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
         
            WebClient client = new WebClient();
            string reply = client.DownloadString("https://www.google.com/search?q=Qaos+-+seria+6%3A+%D5%94%D5%A1%D5%B8%D5%BD+-+%D5%BD%D5%A5%D6%80%D5%AB%D5%A1+6&rlz=1C1NDCM_enAM834AM834&oq=Qaos+-+seria+6%3A+%D5%94%D5%A1%D5%B8%D5%BD+-+%D5%BD%D5%A5%D6%80%D5%AB%D5%A1+6&aqs=chrome..69i57.4783j0j4&sourceid=chrome&ie=UTF-8");
            Console.WriteLine(reply);
            File.WriteAllText(@"D:\MyC#\WriteText.txt", reply);
            Console.ReadLine();
        }
        

    }
   
}
