namespace Delegate_Lab
{
    delegate string myDelegate(Book book);
    class LibraryEngine
    {
        public static void ProcessBooks(Book[] bList
        ,/*Pointer To BookFunciton*/ myDelegate fPtr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }

        public static void ProcessBooksBIDelegate(Book[] bList
        ,/*Pointer To BookFunciton*/ Func<Book, string> fPtr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }
    }
}
