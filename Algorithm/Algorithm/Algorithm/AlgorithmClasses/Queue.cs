using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.AlgorithmClasses
{
    public class Queue<T> where T : struct
    {
        private static int MaxSize = 100;
        T[] queue = new T[MaxSize];
        int front = 0, back = 0;
        public bool IsEmpty() => front == back;
        public bool IsFull() => front == MaxSize;
        public void Enqueue(T data)
        {
            if (IsFull()) throw new Exception("Queue is full");
            if (front == back) front = back;
            queue[front++] = data;
            Console.WriteLine("front : " + front + ", back : " + back);
        }
        public T Dequeue()
        {
            if (IsEmpty()) throw new Exception("Queue is empty");

            var result = queue[back++];
            Console.WriteLine("front : " + front + ", back : " + back);
            return result;
        }
    }
}
