using Ch3Ex1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3Ex1.Model
{
    class QuoteApp
    {
        private QuotesProvider _quotesProvider;
        public string Quote { get; set; }
        public string Author { get; set;}

        public QuoteApp()
        {
            _quotesProvider = new QuotesProvider();
        }

        public void GetRandomQuote()
        {
            var data = _quotesProvider.GetQuotes();
            Quote = data.Quote;
            Author = data.Author;
        }
    }
}
