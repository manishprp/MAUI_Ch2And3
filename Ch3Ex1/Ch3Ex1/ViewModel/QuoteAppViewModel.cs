using Ch3Ex1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Ch3Ex1.ViewModel
{
    class QuoteAppViewModel : INotifyPropertyChanged
    {
        private QuoteApp _quoteAppModel;
        private string _quote;
        private string _author;
        public ICommand getQuoteCommand { get; private set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public string Quote
        {
            get { return _quote; }
            set
            {
                _quote = value;
                NotifyPropertyChanged();
            }
        }
        public string Author
        {
            get { return _author; }
            set
            {
                _author = value;
                NotifyPropertyChanged();
            }
        }
        public QuoteAppViewModel()
        {
            getQuoteCommand = new Command(GetQuote);
            _quoteAppModel = new QuoteApp();
        }

        private void GetQuote()
        {
            _quoteAppModel.GetRandomQuote();
            Quote=_quoteAppModel.Quote;
            Author=_quoteAppModel.Author;
        }

        
       

        
        private void NotifyPropertyChanged([CallerMemberName] string propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
