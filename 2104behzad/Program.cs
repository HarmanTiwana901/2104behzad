using System;
using System.Collections.Generic;

namespace _2104behzad
{
    class Program<T>
    {
        Stack<T> thestack = new Stack<T>(); // our stack
        int stackCount = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

           




        }

        public int Stack(int size)
        {
            return size;
        }

        public void Push(T item)
        {
            thestack.Push(item);
            stackCount++;
        }

        public T Pop()
        {
            return thestack.Pop();
            stackCount--;
        }

        /*
        public T Peek()
        {

        }
        */
        public int Count()
        {
            return stackCount;
        }

        public Program()
        {

        }
    }
}
