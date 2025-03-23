namespace Stack_Queue_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Using of DynamicStack Class
            //DynamicStack myStack = new DynamicStack();

            //char opr;
            //while (true)
            //{
            //    Console.WriteLine("Do you want to Push(U) to or Pop(O) from the Stack?");
            //    opr = char.Parse(Console.ReadLine());
            //    if (opr == 'U' || opr == 'u')
            //    {
            //        Console.Write("Enter the value you want to push: ");
            //        Console.WriteLine(myStack.Push(int.Parse(Console.ReadLine())));
            //    }
            //    else if (opr == 'O' || opr == 'o')
            //    {
            //        Console.WriteLine(myStack.Pop());
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}

            //DynamicStack myStack2 = new DynamicStack();
            //DynamicStack myStack3 = new DynamicStack();
            //Console.WriteLine($"You Created {DynamicStack.Counter} Stack(s).");
            #endregion

            #region Using of GenericStack Class
            //GenericStack<string> strStack = new GenericStack<string>();
            //GenericStack<int> intStack = new GenericStack<int>();

            //Console.WriteLine(strStack.Push("Ali"));
            //Console.WriteLine(strStack.Pop());

            //Console.WriteLine(intStack.Push(15));
            //Console.WriteLine(intStack.Pop());
            #endregion

            #region Using of Complex Class
            //Complex c1 = new Complex(2, 3);
            //Complex c2 = new Complex(5, 6);
            //Complex result = new Complex();

            //result = c1 + c2;
            //Console.WriteLine(result.Print());

            //result = c1 + 10;
            //Console.WriteLine(result.Print());

            //Console.WriteLine((c1++).Print());
            //Console.WriteLine((++c1).Print());

            //Console.WriteLine(c1>c2);

            //int real = (int) c1;

            //Console.WriteLine(real);
            #endregion

            #region Using of Shift Queue
            //ShiftQueue myQueue = new ShiftQueue();

            //char opr;
            //while (true)
            //{
            //    Console.Write("Do you want to Inqueue(I) to or Dequeue(D) from the Queue?");
            //    opr = char.Parse(Console.ReadLine());
            //    if (opr == 'I' || opr == 'i')
            //    {
            //        Console.Write("Enter the value you want to inqueue: ");
            //        Console.WriteLine(myQueue.Inqueue(int.Parse(Console.ReadLine())));
            //    }
            //    else if (opr == 'D' || opr == 'd')
            //    {
            //        Console.WriteLine(myQueue.Dequeue());
            //    }
            //    else
            //        break;
            //}
            #endregion

            #region Using of Circle Queue
            //CircleQueue myQueue = new CircleQueue();

            //char opr;
            //while (true)
            //{
            //    Console.Write("Do you want to Inqueue(I) to or Dequeue(D) from the Queue?");
            //    opr = char.Parse(Console.ReadLine());
            //    if (opr == 'I' || opr == 'i')
            //    {
            //        Console.Write("Enter the value you want to inqueue: ");
            //        Console.WriteLine(myQueue.Inqueue(int.Parse(Console.ReadLine())));
            //    }
            //    else if (opr == 'D' || opr == 'd')
            //    {
            //        Console.WriteLine(myQueue.Dequeue());
            //    }
            //    else
            //        break;
            //}
            #endregion
        }
    }
}
