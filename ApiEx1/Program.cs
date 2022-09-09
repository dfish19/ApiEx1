//Use a for loop to generate at least 5 quotes from each api and have them alternate to simulate a conversation

//Here is some code to utilize for parsing the ron swanson response:
//https://ron-swanson-quotes.herokuapp.com/v2/quotes

//https://api.kanye.rest

using Newtonsoft.Json.Linq;
using System.Net.Http;

var Kclient = new HttpClient();
var kanye = "https://api.kanye.rest";
var kResponse = Kclient.GetStringAsync(kanye).Result;
var kQuote = JObject.Parse(kResponse).GetValue("quote").ToString();
//Console.WriteLine($"{kQuote}");

var Rclient = new HttpClient();
var ron = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
var rResponse = Rclient.GetStringAsync(ron).Result;
var rQuote = JObject.Parse(rResponse).GetValue("value").ToString();
//Console.WriteLine($"{rQuote}");


for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"{kQuote}");
    Console.WriteLine($"{rQuote}");
}