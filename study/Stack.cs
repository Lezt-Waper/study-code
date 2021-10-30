using System;
using System.Collections.Generic;
using System.Text;

namespace study
{
    class Stack
    {
        private int[] stack;
        private int max;
        private int top;

        // creat new stack
        public Stack(int size)
        {
            stack = new int[size];
            max = size;
            top = -1;
        }

        // check full
        public bool Full()
        {
            return top == max - 1;
        }

        // check emty
        public bool Emty()
        {
            return top == -1;
        }

        // push value
        public void Push(int pValue)
        {
            if (Full())
            {
                Console.WriteLine("Stack is full");
            }
            else
            {
                Console.WriteLine("Insert" + pValue);
                stack[++top] = pValue;
            }
        }

        // pop value
        public int Pop(int pValue)
        {
            if (Emty())
            {
                Console.WriteLine("Stack is emty");
                return 0;
            }
            else
            {
                return stack[--top];
            }
        }

        public void PrintStack()
        {
            for (int i = 0; i <= top; i++)
            {
                Console.WriteLine(stack[i]);
            }
        }

        public static void ink() 
        {
            Console.WriteLine("hehe");
        }
    }
}
