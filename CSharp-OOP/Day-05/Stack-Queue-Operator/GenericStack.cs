namespace Stack_Queue_Operator
{
    class GenericStack<DT>
    {
        DT[] arr;
        int size;
        int topOfStack;
        static int counter = 0;

        public static int Counter { get { return counter; } }

        #region Constructors
        public GenericStack()
        {
            counter++;
            size = 5;
            arr = new DT[5];
            topOfStack = 0;
        }

        public GenericStack(int _size)
        {
            counter++;
            size = _size;
            arr = new DT[size];
            topOfStack = 0;
        }
        #endregion

        #region Stack Functions
        public string Push(DT value)
        {
            if (IsFull())
            {
                return "Unsuccessfull, Stack is FULL!!";
            }
            else
            {
                arr[topOfStack] = value;
                topOfStack++;
                return "Pushed to the stack successfully.";
            }
        }
        public string Pop()
        {
            if (IsEmpty())
            {
                return "Unsuccessfull, Stack is Empty!!";
            }
            else
            {
                topOfStack--;
                return $"Successfully Poped the value {arr[topOfStack]} from the stack.";
            }
        }
        public bool IsFull()
        {
            return topOfStack == size;
        }
        public bool IsEmpty()
        {
            return topOfStack == 0;
        }
        #endregion
    }
}
