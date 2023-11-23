using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace TestesCrawler
{
    internal class Paginacao
    {
        private string url = "https://bauruempregos.com.br/home/vagas?offset=";

        public void CrawlUrl()
        {
            string novaUrl = "";
            ListaVagas listaVagas = new ListaVagas();
            for ( int i = 1; i < 3; i++)
            {
                if (i == 1)
                {
                    novaUrl = url + "0&max=200";
                } else
                {
                    novaUrl = url + i + "00&max=200";
                }
                listaVagas.CrawlUrl(novaUrl);
            }
        }
    }
}
