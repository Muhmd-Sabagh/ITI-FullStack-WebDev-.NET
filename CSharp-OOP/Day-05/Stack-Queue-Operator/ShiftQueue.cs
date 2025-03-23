namespace Stack_Queue_Operator
{
    class ShiftQueue
    {
        int[] arr;
        int size;
        int topOfQueue;

        #region Constructors
        public ShiftQueue()
        {
            size = 5;
            arr = new int[size];
            topOfQueue = 0;
        }
        public ShiftQueue(int _size)
        {
            size = _size;
            arr = new int[size];
            topOfQueue = 0;
        }
        #endregion

        #region Functions
        public string Inqueue(int value)
        {
            if (IsFull())
                return "Unsuccessful, The queue is FULL!!";
            else
            {
                arr[topOfQueue] = value;
                topOfQueue++;
                return $"Successfully added {value} to the queue.";
            }
        }
        public string Dequeue()
        {
            if (IsEmpty())
                return "Unsuccessful, The queue is Empty!!";
            else
            {
                int deqNum = arr[0];
                for (int i = 1; i < size; i++)
                {
                    arr[i - 1] = arr[i];
                }
                topOfQueue--;
                return $"Successfully retrieved the value {deqNum} from the queue.";
            }
        }
        public bool IsFull()
        {
            return topOfQueue == size;
        }
        public bool IsEmpty()
        {
            return topOfQueue == 0;
        }
        #endregion
    }
}
