namespace Delegate_Lab
{
    #region Assignment
    /*
    Considering the Code Below , Write Down the Body of all Listed
    Methods and Properties ,
    you need to Define fPtr as the following cases:
    a. User Defined Delegate Datatype
    b. BCL Delegates
    c. Anonymous Method (GetISBN)
    d. Lambda Expression (GetPublicationDate)

    public class LibraryEngine
    {
    public static void ProcessBooks ( List<Book> bList
                                      ,(Pointer To BookFunciton) fPtr)
        {
        foreach (Book B in bList)
            {
            Console.WriteLine(fPtr(B));
            }
        }
    }
    */
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("978-0132350884", "Clean Code", new string[] { "Robert C. Martin" }, new DateTime(2008,8,1), 50);
            Book b2 = new Book("978-0201616224", "The Pragmatic Programmer", new string[] { "Andrew Hunt", "David Thomas" }, new DateTime(1999,10,30), 75);
            Book b3 = new Book("978-0201633610", "Design Patterns", new string[] { "Erich Gamma", "Richard Helm", "Ralph Johnson", "John Vlissides" }, new DateTime(1994,10,21), 90);
            Book[] bList = { b1, b2, b3 };

            // Using user defined delegate
            myDelegate del = BookFunctions.GetTitle;
            LibraryEngine.ProcessBooks(bList, del);

            Console.WriteLine("-----------------------");

            // Using anonymous function
            LibraryEngine.ProcessBooks(bList, delegate(Book b) {
                return $"Book Price: {b.Price}";
            });

            Console.WriteLine("-----------------------");

            // Using Lambda Expression
            LibraryEngine.ProcessBooksBIDelegate(bList, b=> $"Book Author(s): {string.Join(", ", b.Authors)}");
        }
    }
}
