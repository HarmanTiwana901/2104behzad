using System;

namespace MyStackApp
{
    class Program
    {
        static void Main(string[] args)
        {
           
           // Stack<T> mystack = new Stack<T>(50);
        }
    }

    class Stack<T>
    {
        private T[] thestack;
        private int top = -1;
        private int stackCount = 0;
        private int max;
        public Stack(int size)
        {
            thestack = new T[size];
            max = size;
        }

        public void Push(T item)
        {
            // check size first before pushing
            if (top == max - 1)
            {
                Console.WriteLine("Exceeded stack size amount");
                return;
            }
            else
            {
                stackCount++;
                thestack[++top] = item;
            }
        }

        public T Pop()
        {
            T t = default(T);
            if (top == -1)
            {
                Console.WriteLine("Empty Stack");
                return t;
            }
            else
            {
                stackCount--;
                return thestack[top--];
            }
        }

        public T Peek()
        {
            T t = default(T);
            // check if stack has any items
            if (top == -1)
            {
                Console.WriteLine("Stack empty");
                return t;
            }
            else
            {
                Console.WriteLine("Popped");
                return thestack[top];
            }
        }

        public int Count()
        {
            return stackCount;
        }
    }
}
