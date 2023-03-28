namespace Ch3Ex8
{
    public class QuestionModel
    {
        public bool IsYes { get; set; }
        public bool IsNo { get; set; }
        public string Question { get; set; }
        private List<string> _questions;
        private bool _answers;
        private int _previousIndex = 0;
        private int _currentIndex = 0;
        private string question;
        public QuestionModel()
        {
            _questions = new List<string>();
            FillQuesTions();
        }
        private void FillQuesTions()
        {
            _questions.Add("Have you finished graduation?");//0
            _questions.Add("Are you graduated from GTU?");//1
            _questions.Add("Have you done any programming course?");//2
            _questions.Add("Are you a passout from 2022 batch?");//3
            _questions.Add("Are you graduated from Mumbai University?");//4
            _questions.Add("Have you done any android course?");//5
            _questions.Add("Have you done any ios course?");//6
            _questions.Add("Have you done internship?");//7
            _questions.Add("Do you have any previous experience?");//8
            _questions.Add("Do you want to continue further study?");//9
            _questions.Add("Have you done distance learning?");//10
            _questions.Add("Do you have experience in Kotlin?");//11
            _questions.Add("Are you planning to do any android course?");//12
            _questions.Add("Do you have experience in swift?");//13
            _questions.Add("Are you planning to do any ios course?"); //14
        }
        public void StoreAnswer()
        {
            if (IsYes)
                _answers= true;
            if (IsNo)
                _answers=false;
        }

        public void GetQuestion()
        {
            if (!IsYes && !IsNo)
            {
                _previousIndex = 0;
                question = _questions[0];
                Question = question;
                return;
            }
            _currentIndex = _previousIndex + (_previousIndex + 1);
            if(_currentIndex<_questions.Count)
            {
                if (_answers)
                {
                    question = _questions[_currentIndex];
                }
                else
                {
                    _currentIndex = _currentIndex + 1;
                    question = _questions[_currentIndex];
                }
                _previousIndex = _currentIndex;
            }
            Question = question;
        }
    }
}