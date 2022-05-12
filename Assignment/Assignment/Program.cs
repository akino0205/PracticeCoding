// See https://aka.ms/new-console-template for more information

using System.Collections;

//Queue
Console.WriteLine("================ Queue ================");
Queue qu = new Queue();
qu.Enqueue(1);
qu.Enqueue(2);
qu.Enqueue(3);

int quTotal = qu.Count;
for (int i = 0; i < quTotal; i++)
{
    Console.WriteLine($"idx : {i}");
    Console.WriteLine($"qu.Count : {qu.Count}");
    Console.WriteLine($"qu.Dequeue() : {qu.Dequeue()}");
}

//Stack
Console.WriteLine("================ Stack ================");
Stack st = new Stack();
st.Push(1);
st.Push(2);
st.Push(3);

int stTotal = st.Count;
for (int i = 0; i < stTotal; i++)
{
    Console.WriteLine($"idx : {i}");
    Console.WriteLine($"st.Count : {st.Count}");
    Console.WriteLine($"st.Pop() : {st.Pop()}");
}