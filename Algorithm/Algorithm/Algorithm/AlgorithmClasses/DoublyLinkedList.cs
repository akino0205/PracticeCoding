using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.AlgorithmClasses
{

    //https://docs.microsoft.com/ko-kr/dotnet/api/system.collections.generic.linkedlist-1?view=net-6.0
    //https://joooootopia.tistory.com/18
    //https://geukggom.tistory.com/160
    public class DoublyLinkedList<T> where T : struct
    {
        private class Node<T> where T : struct
        {
            public T data;
            public Node<T> prev;
            public Node<T> next;
            public Node(T data)
            {
                this.data = data;
                this.prev = null;
                this.next = null;
            }
        }

        private Node<T> head;
        public DoublyLinkedList()
        {

        }
        private void SetFirstNode(Node<T> newNode)
        {
            this.head = newNode;
        }
        /// <summary>
        /// 맨마지막에 추가
        /// </summary>
        /// <param name="newNode">추가할 노드</param>
        public void AddLast(T data)
        {
            var newNode = new Node<T>(data);
            if(head == null)
                SetFirstNode(newNode);
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
                newNode.prev = current;
                newNode.next = null;
            }
        }
        
        public void AddFirst(T data)
        {
            var newNode = new Node<T>(data);
            if (head == null)
                SetFirstNode(newNode);
            else
            {
                //새로운 노드를 제일 앞에 추가
                newNode.next = head;
                head.prev = newNode;
                head = newNode;
            }
        }
        /// <summary>
        /// 맨처음 발견되는 지정된 값을 제거합니다. 
        /// </summary>
        /// <param name="key"></param>
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
