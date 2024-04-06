using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace StockPageScraping
{
    public class Program
    {
        public static async Task Main()
        {
            // var html = @"http://html-agility-pack.net/";

            // HtmlWeb web = new HtmlWeb();

            // var htmlDoc = web.Load(html);
            // Console.WriteLine("htmlDoc: " + htmlDoc.ToString());

            // var node = htmlDoc.DocumentNode.SelectSingleNode("//head/title");

            // Console.WriteLine("Node Name: " + node.Name + "\n" + node.OuterHtml);

            Console.WriteLine("Initializing app:");
            //string url = "https://public.com/stocks/aso";
            // var httpClient = new HttpClient();
            // var html = await httpClient.GetStringAsync(url);



            // var doc = new HtmlDocument();
            // doc.LoadHtml(html);

            // var ratingNodes = doc.DocumentNode.InnerHtml;

            //Console.WriteLine("ratingNodes: " + ratingNodes);

            var html = @"https://public.com/stocks/aso";

            HtmlWeb web = new HtmlWeb();

            var htmlDoc = web.Load(html);

            var node = htmlDoc.DocumentNode.SelectSingleNode("//head/title");
            var rating = htmlDoc.DocumentNode.SelectNodes("/html/body/div/div/div/div/div/div/main/div/div/div/div/div/div");

            Console.WriteLine("Node Name: " + node.Name + "\n" + node.OuterHtml);

            foreach (HtmlNode node2 in rating)
            {
                string attributeValue = node2.GetAttributeValue("data-section", "");
                if (attributeValue == "rating")
                {
                    Console.WriteLine("Name: " + node2.Name + "\n" + node2.OuterHtml);
                    var ratingNode = node2.LastChild;

                    Console.WriteLine("Rating: " + ratingNode.Name + "\n" + ratingNode.InnerText);
                }

            }



            //var web = new HtmlWeb();



            //List<StockAnalysis> stockAnalysis = new List<StockAnalysis>();

            // foreach (var node in nodes)
            // {
            //     Console.Write("This is node: " + node.InnerHtml);
            // }

        }
    }
}