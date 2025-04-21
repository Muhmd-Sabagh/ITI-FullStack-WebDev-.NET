namespace Collections
{
    class Answer
    {
        public int Id { get; set; }
        public string AnswerBody { get; set; }

        public Answer(int _id = 0, string _answer = "")
        {
            Id = _id;
            AnswerBody = _answer;
        }

        public override string ToString()
        {
            return $"A{Id}: {AnswerBody}";
        }
    }
}
