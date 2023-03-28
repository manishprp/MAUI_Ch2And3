using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Ch3Ex8.ViewModel
{
    public class QuestionViewModel : INotifyPropertyChanged
    {
        private bool _isYes;
        public bool IsYes
        {
            get { return _isYes; }
            set
            {
                _isYes = value;
                NotifyPropertyChanged();
            }
        }
        private bool _isNo;
        public bool IsNo
        {
            get { return _isNo; }
            set
            {
                _isNo = value;
                NotifyPropertyChanged();
            }
        }
        private string _question;
        public string Question 
        { get { return _question; }
            set {
                _question = value;
                NotifyPropertyChanged(); }
            }
        public ICommand NextCommand { get; private set; }
        private QuestionModel _model;

        public event PropertyChangedEventHandler PropertyChanged;
        public QuestionViewModel()
        {
            NextCommand = new Command(GiveNextQuestion);
            _model = new QuestionModel();
            _model.GetQuestion();
            Question = _model.Question;
        }
        private void GiveNextQuestion(object obj)
        {
            _model.IsYes = IsYes;
            _model.IsNo = IsNo;
            _model.StoreAnswer();
            _model.GetQuestion();
            Question = _model.Question; 
            IsYes= false;
            IsNo= false;
        }
        private void NotifyPropertyChanged([CallerMemberName] string propertyname = "")
        {
            PropertyChanged?.Invoke (this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
