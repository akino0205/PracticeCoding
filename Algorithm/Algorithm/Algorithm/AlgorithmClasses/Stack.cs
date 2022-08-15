using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.AlgorithmClasses
{
    public class Stack<T> where T : struct
    {
        private static int MaxSize = 100;
        T[] stack = new T[MaxSize];
        int top = 0;
        public bool IsEmpty() => top == 0;
        public bool IsFull() => top == MaxSize;
        public void Push(T data)
        {
            if (IsFull()) throw new Exception("Stack is full");
            stack[top++] = data;
        }
        public T Pop()
        {
            if (IsEmpty()) throw new Exception("Stack is empty");
            return stack[--top];
        }
    }
}
