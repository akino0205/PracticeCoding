// See https://aka.ms/new-console-template for more information
//스택, 큐, 링크트 리스트, 퀵소트 만들어보기
using Algorithm.AlgorithmClasses;

#region 링크드 리스트 LinkedList
#region 단방향 링크드리스트 SinglyLinkedList
var list = new SinglyLinkedList<int>();
Console.WriteLine("new list : " + list.Count());

//Add
list.Add(0);
list.Add(1);
list.Add(2);
list.Add(3);
list.Add(4);
Console.WriteLine("Add : " + list.Count());

//Remove
list.Remove(0);
Console.WriteLine("Remove : " + list.Count());
#endregion 단방향 링크드리스트 SinglyLinkedList

#region 양방향 링크드리스트
#endregion 양방향 링크드리스트
#endregion 링크드 리스트

#region 스택 Stack
var stackByDotNet = new System.Collections.Generic.Stack<int>();
//stackByDotNet.Pop();
var stackByNorah = new Algorithm.AlgorithmClasses.Stack<int>();
stackByNorah.Push(0);
stackByNorah.Push(1);
Console.WriteLine("stackByNorah.Pop() : " + stackByNorah.Pop());
Console.WriteLine("stackByNorah.Pop() : " + stackByNorah.Pop());
//Console.WriteLine("stackByNorah.Pop() : " + stackByNorah.Pop());
#endregion 스택 Stack

#region 큐 Queue
var queueByNorah = new Algorithm.AlgorithmClasses.Queue<int>();
queueByNorah.Enqueue(0);
queueByNorah.Enqueue(1);
queueByNorah.Enqueue(2);
Console.WriteLine("queueByNorah.Dequeue() : " + queueByNorah.Dequeue());
Console.WriteLine("queueByNorah.Dequeue() : " + queueByNorah.Dequeue());
Console.WriteLine("queueByNorah.Dequeue() : " + queueByNorah.Dequeue());
#endregion 큐 Queue

#region 퀵소트 QuickSort

#endregion 퀵소트 QuickSort
