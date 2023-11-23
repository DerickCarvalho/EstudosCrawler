using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TestesCrawler
{
    internal class Vaga
    {
        public void CrawlUrl(string urlDaVaga)
        {
            HtmlDocument htmlDocument = new HtmlDocument();
            var client = new WebClient();

            string htmlString = client.DownloadString(urlDaVaga);
            htmlDocument.LoadHtml(htmlString);

            string titulo = htmlDocument.DocumentNode.SelectSingleNode("//div[@class='descricao-vaga']/h1").InnerText;
            string descricao = htmlDocument.DocumentNode.SelectSingleNode("//div[@class='descricao-vaga']/pre").InnerText;

            Console.WriteLine($"Titulo: {titulo}\n\nDescrição: {descricao}");


        }
    }
}
