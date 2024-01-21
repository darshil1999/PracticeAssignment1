using PracticeAssignment1.Models;

namespace PracticeAssignment1.Services
{
    public class QuoteService : IQuoteService
    {
        private readonly List<Quote> _quotes;
        private readonly Random _random = new Random();

        public QuoteService()
        {
            _quotes = new List<Quote>
            {
                new Quote { Text = "The greatest glory in living lies not in never falling, but in rising every time we fall", Author = "-Nelson Mandela" },
                new Quote { Text = "The way to get started is to quit talking and begin doing.", Author = "-Walt Disney" },
                new Quote { Text = "Your time is limited, so don't waste it living someone else's life. Don't be trapped by dogma – which is living with the results of other people's thinking.", Author = "-Steve Jobs" },
                new Quote { Text = "The future belongs to those who believe in the beauty of their dreams.", Author = "-Eleanor Roosevelt" },
                new Quote { Text = "If you look at what you have in life, you'll always have more. If you look at what you don't have in life, you'll never have enough.", Author = "-Oprah Winfrey" },
                new Quote { Text = "If you set your goals ridiculously high and it's a failure, you will fail above everyone else's success.", Author = "-James Cameron" },
                new Quote { Text = "You may say I'm a dreamer, but I'm not the only one. I hope someday you'll join us. And the world will live as one.", Author = "-John Lennon" },
                new Quote { Text = "You must be the change you wish to see in the world.", Author = "-Mahatma Gandhi" },
                new Quote { Text = "Spread love everywhere you go. Let no one ever come to you without leaving happier.", Author = "-Mother Teresa" },
                new Quote { Text = "The only thing we have to fear is fear itself.", Author = "-Franklin D. Roosevelt" }
            };
        }

        public Quote GetRandomQuote()
        {
            int index = _random.Next(_quotes.Count);
            return _quotes[index];
        }
    }
}
