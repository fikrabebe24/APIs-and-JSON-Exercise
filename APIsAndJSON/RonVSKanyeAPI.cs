using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using static System.Net.WebRequestMethods;

namespace APIsAndJSON
{
    

    public class RonVSKanyeAPI
    {
        public static void RonSwanson()
        {
            //https client
            var client = new HttpClient();

            //URL and/or end-point
            var ronUrl = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            //Get request
            var ronSaid = client.GetStringAsync(ronUrl).Result;

            //parse
            var ronArray = JArray.Parse(ronSaid);

            Console.WriteLine(ronArray[0].ToString());
        }

       public static void SaidYe()
       {
                var client = new HttpClient();

                var yeEndPointUrl = "https://api.kanye.rest";

                var yeSaid = client.GetStringAsync(yeEndPointUrl).Result;

                var yeObject = JObject.Parse(yeSaid);

            Console.WriteLine(yeObject["quote"].ToString());
       }

        public static void Conversation()
        {
            for(int i = 0; i < 5; i++)
            {
                SaidYe();
                RonSwanson();
                Console.WriteLine();

            //Console.WriteLine();
            //Console.WriteLine($"Kanye West: [instance.HSaidYe()]);
            //Console.WriteLine();
            //Console.WriteLine($"Ron Swanson: {instance.RonSwanson[]});
            //
            }
        }
    }


    
}
