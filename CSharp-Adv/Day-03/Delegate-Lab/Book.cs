namespace Delegate_Lab
{
    class Book
    {
        string _isbn;
        string _title;
        string[] _authors;
        DateTime _publicationDate;
        decimal _price;
        public string ISBN { get { return _isbn; } set { _isbn = value; } }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime? PublicationDate { get; set; }
        public decimal Price { get; set; }
        public Book(string _ISBN = "", string _Title = "",
        string[]? _Authors = null, DateTime? _PublicationDate = null,
        decimal _Price = 0)
        {
            _Authors = _Authors ?? new string[0];
            _PublicationDate = _PublicationDate ?? DateTime.MinValue;
            ISBN = _ISBN;
            Title = _Title;
            Authors = _Authors;
            PublicationDate = _PublicationDate;
            Price = _Price;
        }
        public override string ToString()
        {
            return $"BooK ISBN: {ISBN}, Title: {Title}, Authors: {string.Join(", " ,Authors)}, PublicationDate: {PublicationDate}, Price: {Price}"; 
        }

        public override bool Equals(object? obj)
        {
            Book? book = obj as Book;

            return book?.Price == Price;
        }
    }
}
