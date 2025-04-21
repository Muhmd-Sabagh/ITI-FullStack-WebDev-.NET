namespace Delegate_Lab
{
    class BookFunctions
    {
        public static string GetTitle(Book B)
        {
            return $"Book Title: {B.Title}";
        }
        public static string GetAuthors(Book B)
        {
            return $"Book Auther(s): {string.Join(", ", B.Authors)}";
        }
        public static string GetPrice(Book B)
        {
            return $"Book Price: {B.Price}";
        }
    }
}
