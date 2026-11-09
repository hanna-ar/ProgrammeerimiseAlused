using System.Net.Http;
using System.Xml.Linq;
using System.Net;


Dictionary<string, string> rssVood = new Dictionary<string, string>()
{
    { "Lääne Elu", "https://online.le.ee/feed/" },
    { "Postimees", "https://www.postimees.ee/rss" },
    { "ERR", "https://www.err.ee/rss" },
    { "Äripäev", "https://feeds.feedburner.com/aripaev-rss"},
};

// uudNim = uudiste nimekiri
List<RssItem> uudNim = new List<RssItem>();


using HttpClient client = new HttpClient();


foreach (var rssVoog in rssVood)
{
    string avaldaja = rssVoog.Key;
    string rssUrl = rssVoog.Value;


    try
    {
        string xmlSisu = await client.GetStringAsync(rssUrl);

        XDocument xmlDokument = XDocument.Parse(xmlSisu);

        
        var uudised = xmlDokument.Root?
            .Element("channel")?
            .Elements("item");

        if (uudised != null)
        {
            int lisatud = 0;

            foreach (var uudis in uudised)
            {
                RssItem artikkel = new RssItem();

                artikkel.Title = uudis.Element("title")?.Value ?? "";
                artikkel.Link = uudis.Element("link")?.Value ?? "";
                artikkel.Description = uudis.Element("description")?.Value ?? "";
                artikkel.Publisher = avaldaja;

                string kpv = uudis.Element("pubDate")?.Value ?? "";

                if (DateTimeOffset.TryParse(kpv, out DateTimeOffset aeg))
                {
                    artikkel.PublishedAt = aeg;
                    uudNim.Add(artikkel);
                    lisatud++;
                }
            }

            Console.WriteLine("Lisatud uudiseid: " + lisatud);
        }
        else
        {
            Console.WriteLine("Ei leia uudiseid.");
        }
    }
    catch (HttpRequestException)
    {
        Console.WriteLine("Ei saanud alla laadida: " + avaldaja);
    }
    catch (System.Xml.XmlException)
    {
        Console.WriteLine("XML-i ei saa lugeda: " + avaldaja);
    }
}


Console.WriteLine();
Console.WriteLine("Uudiseid kokku: " + uudNim.Count);

// Sorteerimine
List<RssItem> uuemad = uudNim
    .OrderByDescending(artikkel => artikkel.PublishedAt)
    .Take(20)
    .ToList();



using FileStream fail = new FileStream("uudised.html", FileMode.Create);


using StreamWriter kirjutaja = new StreamWriter(fail);


kirjutaja.WriteLine("<!DOCTYPE html>");
kirjutaja.WriteLine("<html lang=\"et\">");
kirjutaja.WriteLine("<head>");
kirjutaja.WriteLine("    <meta charset=\"UTF-8\">");
kirjutaja.WriteLine("    <title>20 uusimat uudist</title>");
kirjutaja.WriteLine("</head>");
kirjutaja.WriteLine("<body>");
kirjutaja.WriteLine("    <h1>20 uusimat uudist</h1>");
kirjutaja.WriteLine("    <ul>");


// 20 uudist HTMLi

int nr = 1;

foreach (RssItem artikkel in uuemad)
{
    string pealkiri = WebUtility.HtmlEncode(artikkel.Title);
    string link = WebUtility.HtmlEncode(artikkel.Link);
    string kirjeldus = WebUtility.HtmlEncode(artikkel.Description);
    string avaldaja = WebUtility.HtmlEncode(artikkel.Publisher);
    string kpv = artikkel.PublishedAt.ToString("dd.MM.yyyy HH:mm");

    kirjutaja.WriteLine("        <li>");
    kirjutaja.WriteLine("            <h2>" + nr + ". <a href=\"" + link + "\">" + pealkiri + "</a></h2>");
    kirjutaja.WriteLine("            <p>" + avaldaja + " | " + kpv + "</p>");
    kirjutaja.WriteLine("            <p>" + kirjeldus + "</p>");
    kirjutaja.WriteLine("        </li>");

    nr++;
}


kirjutaja.WriteLine("    </ul>");
kirjutaja.WriteLine("</body>");
kirjutaja.WriteLine("</html>");

kirjutaja.Close();
