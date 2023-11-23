using HtmlAgilityPack;
using System.Net;
using TestesCrawler;

/*

// WebClient funciona como um "navegador" porém ele não manipula nada do HTML.
WebClient client = new WebClient();

// Instancia o HtmlAgilityPack
HtmlDocument html = new HtmlDocument();

string url = "https://bauruempregos.com.br/home/vagas?offset=0&max=200";

// Faz o download do HTML da página
string htmlString = client.DownloadString(url);

// Carrega o HTML da página
html.LoadHtml(htmlString);

// Pega o obj com o HTML carregado dentro, pega os nós, e seleciona o que a gente quer
 string funcao = html.DocumentNode.SelectSingleNode("//div[@class='descricao-vaga']").InnerText;

*/

Paginacao paginacao = new Paginacao();
paginacao.CrawlUrl();