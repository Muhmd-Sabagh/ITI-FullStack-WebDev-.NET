namespace Collections
{
    class Question
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string[]? Body { get; set; }

        public Question(int _id = 0, string _header = "", string[]? _body = null)
        {
            Id = _id;
            Header = _header;
            Body = _body;
        }

        public override string ToString()
        {
            return $"Q#{Id}: {Header}\n{string.Join("\n",Body)}";
        }
    }
}
