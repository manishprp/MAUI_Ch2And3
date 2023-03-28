using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3Ex1.Data
{
    class QuotesProvider
    {
        
        private List<Quotes> _quotes;
        private Random _random;
        public QuotesProvider()
        {
            _random = new Random();
        }
        public Quotes GetQuotes() 
        {
            
            if (_quotes != null)
            {
                var index = _random.Next(0, _quotes.Count);
                return _quotes[index];
            }
            else
            {
                return FillInquotes();
            }
        }

        private Quotes FillInquotes()
        {
            _quotes= new List<Quotes>();
            _quotes.Add(new Quotes() { Author="-Osho",Quote= "“Friendship is the purest love. It is the highest form of Love where nothing is asked for, no condition, where one simply enjoys giving.”" });
            _quotes.Add(new Quotes() { Author="-Osho",Quote= "“Drop the idea of becoming someone, because you are already a masterpiece. You cannot be improved. You have only to come to it, to know it, to realize it.”" });
            _quotes.Add(new Quotes() { Author="-Osho",Quote= "“Truth is not something outside to be discovered, it is something inside to be realized.”" });
            _quotes.Add(new Quotes() { Author="-Osho",Quote= "“Life begins where fear ends.”" });
            _quotes.Add(new Quotes() { Author="-Osho",Quote= "“My meditation is simple. It does not require any complex practices. It is simple. It is singing. It is dancing. It is sitting silently”" });
            _quotes.Add(new Quotes() { Author="-J Krishnamurti",Quote= "Each one of us has built up this competitive, ruthless civilization, in which man is against man." });
            _quotes.Add(new Quotes() { Author= "-J Krishnamurti", Quote= "To live in the eternal present there must be death to the past, to memory. In this death there is timeless renewal." });
            _quotes.Add(new Quotes() { Author= "-J Krishnamurti", Quote= "When death comes, it does not ask your permission; it comes and takes you, it destroys you on the spot." });
            _quotes.Add(new Quotes() { Author= "-J Krishnamurti", Quote= "A mind that is full of conclusions is a dead mind, it is not a living mind. A living mind is a free mind, learning, never concluding." });
            _quotes.Add(new Quotes() { Author="-J Krishnamurti",Quote= "When one loses the deep intimate relationship with nature, then temples, mosques and churches become important." });

            return _quotes[_random.Next(0, _quotes.Count)];
            
        }
    }
}
