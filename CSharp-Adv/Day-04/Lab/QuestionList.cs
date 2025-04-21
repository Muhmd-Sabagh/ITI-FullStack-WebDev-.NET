namespace Collections
{
    class QuestionList : List<Question>
    {
        string fileName;
        public QuestionList(string _fileName)
        {
            fileName = _fileName;
        }
        public new void Add(Question q)
        {
            base.Add(q);
            using StreamWriter writer = new StreamWriter(fileName, true);
            {
                writer.WriteLine(q);
                writer.Write("----------------\n");
            }
        }
    }
}
