namespace Solution
{
    public class MinStack
    {
        private Stack<int> _stack;
        private Stack<int> _minStack;

        public MinStack()
        {
            _stack = new Stack<int>();
            _minStack = new Stack<int>();
        }

        public void Push(int val)
        {
            _stack.Push(val);

            if (_minStack.Count == 0 || val <= _minStack.Peek()) _minStack.Push(val);

            Console.WriteLine($"MinStack Count: {_minStack.Count}");
            Console.WriteLine($"DefaultStack Count: {_stack.Count}");
        }

        public void Pop()
        {
            if (_minStack.Peek() == _stack.Peek()) _minStack.Pop();

            _stack.Pop();

            Console.WriteLine($"MinStack Count: {_minStack.Count}");
            Console.WriteLine($"DefaultStack Count: {_stack.Count}");
        }

        public int Top()
        {
            Console.WriteLine($"MinStack Count: {_minStack.Count}");
            Console.WriteLine($"DefaultStack Count: {_stack.Count}");
            return _stack.Peek();
        }

        public int GetMin()
        {
            Console.WriteLine($"MinStack Count: {_minStack.Count}");
            Console.WriteLine($"DefaultStack Count: {_stack.Count}");
            return _minStack.Peek();
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            var minStack = new MinStack();

            minStack.Push(10);
            minStack.Push(100);
            minStack.Push(1);
            minStack.Push(1000);
            minStack.Push(10000);
            minStack.Pop();
            var top = minStack.Top();
            var min = minStack.GetMin();
            Console.WriteLine($"Top: {top}");
            Console.WriteLine($"Min: {min}");
        }
    }
}