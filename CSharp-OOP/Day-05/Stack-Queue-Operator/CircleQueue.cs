namespace Stack_Queue_Operator
{
    class CircleQueue
    {
        int[] arr;
        int size;
        int first;
        int last;
        int numOfElements;

        #region Constructors
        public CircleQueue()
        {
            size = 5;
            arr = new int[size];
            first = 0;
            last = 0;
            numOfElements = 0;
        }
        public CircleQueue(int _size)
        {
            size = _size;
            arr = new int[size];
            first = 0;
            last = 0;
            numOfElements = 0;
        }
        #endregion

        #region Functions
        public string Inqueue(int value)
        {
            if (IsFull())
                return "Unsuccessful, The queue is FULL!!";
            else
            {
                if (last == size)
                    last = 0;
                arr[last] = value;
                numOfElements++;
                last++;
                return $"Successfully added {value} to the queue.";
            }
        }
        public string Dequeue()
        {
            if (IsEmpty())
                return "Unsuccessful, The queue is Empty!!";
            else
            {
                if (first == size)
                    first = 0;
                numOfElements--;
                first++;
                return $"Successfully retrieved the value {arr[first-1]} from the queue.";
            }
        }
        public bool IsFull()
        {
            return numOfElements == size;
        }
        public bool IsEmpty()
        {

            return numOfElements == 0;
        }
        #endregion
    }
}
