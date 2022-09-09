using Newtonsoft.Json.Linq;
using System.Net.Http;



for (int i = 0; i < 5; i++)
{
    var Kclient = new HttpClient();
    var kanye = "https://api.kanye.rest";
    var kResponse = Kclient.GetStringAsync(kanye).Result;
    var kQuote = JObject.Parse(kResponse);   //.GetValue("quote").ToString();
    Console.WriteLine($"Mr. West# {kQuote["quote"]}");

    var Rclient = new HttpClient();
    var ron = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
    var rResponse = Rclient.GetStringAsync(ron).Result;
    var rQuote = JArray.Parse(rResponse); // ToString();
    Console.WriteLine($"Mr. Swanson# {rQuote[0]}");
    Console.WriteLine();
}



