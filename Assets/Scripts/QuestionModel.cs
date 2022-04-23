namespace Assets.Scripts
{
    public class QuestionModel
    {
        private string _questionText;
        private string _leftButtonText;
        private string _rightButtonText;
        private bool _isLeft;

        public void setQuestionText(string questionText)
        {
            _questionText = questionText;
        }

        public void setleftButtonText(string leftButtonText)
        {
            _leftButtonText = leftButtonText;
        }

        public void setRightButtonText(string rightButtonText)
        {
            _rightButtonText = rightButtonText;
        }

        public void setIsLeft(bool isLeft)
        { 
            _isLeft = isLeft;
        }

        public string getQuestionText()
        {
            return _questionText;
        }

        public string getleftButtonText()
        {
            return _leftButtonText;
        }

        public string getRightButtonText()
        {
            return _rightButtonText;
        }

        public bool getIsLeft()
        {
            return _isLeft;
        }
    }
}

