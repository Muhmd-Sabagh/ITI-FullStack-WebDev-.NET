namespace Stack_Queue_Operator
{
    class DynamicStack
    {
        int[] arr;
        int size;
        int topOfStack;
        static int counter = 0;

        public static int Counter { get { return counter; } }

        #region Constructors
        public DynamicStack()
        {
            counter++;
            size = 5;
            arr = new int[5];
            topOfStack = 0;
        }

        public DynamicStack(int _size)
        {
            counter++;
            size = _size;
            arr = new int[size];
            topOfStack = 0;
        }
        #endregion

        #region Stack Functions
        public string Push(int value)
        {
            if (IsFull())
            {
                return "Unsuccessfull, Stack is FULL!!";
            }
            else
            {
                arr[topOfStack] = value;
                topOfStack++;
                return $"Successfully pushed {value} to the stack.";
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
