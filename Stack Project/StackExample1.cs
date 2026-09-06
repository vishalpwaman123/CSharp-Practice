namespace Stack_Project
{
    public class StackExample1
    {
        private int[] _stack;
        private int _top;

        public StackExample1(int capacity)
        {
            _stack = new int[capacity];
            _top = -1;
        }

        public void Push(int element)
        {
            if (_top == _stack.Length - 1)
                throw new InvalidOperationException("Stack Overflow");
            _stack[++_top] = element;
        }

        public int Pop()
        {
            if (_top == -1)
                throw new InvalidOperationException("Stack Is Empty");
            return _stack[_top--];
        }

        public int Peek()
        {
            if (_top == -1)
                throw new InvalidOperationException("Stack Is Empty");
            return _stack[_top];
        }

        public bool Contains(int element)
        {
            for (int i = 0; i <= _top; i++)
                if (_stack[i] == element)
                    return true;

            return false;
        }

        public void Clear()
        {
            _top = -1;
        }

        public int Count()
        {
            return _top + 1;
        }
    }
}
