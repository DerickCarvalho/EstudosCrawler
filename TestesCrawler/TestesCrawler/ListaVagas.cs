using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TestesCrawler
{
    internal class ListaVagas
    {
        public void CrawlUrl(string url)
        {  
            Vaga vaga = new Vaga();
            HtmlDocument html = new HtmlDocument();

            // Ao usar o var, não precisamos necessariamene digitar o tipo da variável.
            var client = new WebClient();

            string htmlString = client.DownloadString(url);

            html.LoadHtml(htmlString);

            // Exemplo de usar o tipo ao inves do var.
            HtmlNodeCollection listaDeVagas = html.DocumentNode.SelectNodes("//a[@title='Clique aqui para visualizar os detalhes da vaga']");

            foreach (var urlVaga in listaDeVagas)
            {
                string novaUrlVaga = "https://bauruempregos.com.br/" + urlVaga.GetAttributeValue("href",null);
                vaga.CrawlUrl(novaUrlVaga);
            }
        }
    }
}
