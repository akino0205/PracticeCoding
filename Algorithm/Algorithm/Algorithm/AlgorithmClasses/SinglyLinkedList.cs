using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.AlgorithmClasses
{
    //[참고 블로그]https://smilejsu.tistory.com/1979
    
    public class SinglyLinkedList<T> where T : struct
    {
        private class Node<T> where T : struct
        {
            public T data;
            public Node<T> next;
            public Node(T data)
            {
                this.data = data;
            }
        }
        private Node<T> head;
        public SinglyLinkedList()
        {

        }
        /// <summary>
        /// 맨마지막에 추가
        /// </summary>
        /// <param name="newNode">추가할 노드</param>
        public void Add(T data)
        {
            var newNode = new Node<T>(data);
            if(head == null)
            {
                this.head = newNode;
            }
            else
            {
                var current = this.head;
                //마지막 노드로 이동
                while(current != null && current.next != null)
                {
                    current = current.next;
                }
                //새로운 노드 추가
                current.next = newNode;
            }
        }
        public void Remove(T key)
        {
            if (head == null) return;

            Node<T> current = head;
            Node<T> prev = null;

            if (current.data.Equals(key))
            {
                head = current.next;
                current = null;
            }
            else
            {
                while(current != null && !current.data.Equals(key))
                {
                    prev = current;
                    current = current.next;
                }
                if(current != null)
                {
                    prev.next = current.next;
                }
            }
        }
        public int Count()
        {
            int count = 0;
            var current = this.head;
            while(current != null)
            {
                count++;
                current = current.next;
            }
            return count;
        }
    }
}
