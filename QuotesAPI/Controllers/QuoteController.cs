using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QuotesAPI.Models;

namespace QuotesAPI.Controllers
{
    public class QuoteController : ApiController
    {
        public  static List<Quote> quotes = new List<Quote>()
        {
            new Quote(){Id=1,Author="Kalam",Title="Life of kalam",Description="About Rocket Science"},
            new Quote(){Id=2,Author="Murthy",Title="Life of Murthy",Description="About Life"}

        };

        public IEnumerable<Quote> GetQuotes()
        {
            return quotes;
        }

        public void Post([FromBody]Quote quote)
        {
            quotes.Add(quote);
        }

        public void Put(int id,[FromBody]Quote quote)
        {
            quotes[id] = quote;
        }

        public void Delete(int id)
        {
            quotes.RemoveAt(id);
        }
    }
}
