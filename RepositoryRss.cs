using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WebJobChollos.Models;

namespace WebJobChollos.Repositories
{
    public class RepositoryRss
    {
        public List<CholloRss> GetChollos()
        {
            String url = "https://www.chollometro.com/rss";
            XDocument docxml = XDocument.Load(url);
            var consulta = from datos in docxml.Descendants("item")
                           select new CholloRss
                           {
                               Titular = datos.Element("title").Value,
                               Enlace = datos.Element("link").Value,
                               Descripcion = datos.Element("description").Value,
                               Categoria = datos.Element("category").Value
                           };
            return consulta.ToList();
        }
    }
}
