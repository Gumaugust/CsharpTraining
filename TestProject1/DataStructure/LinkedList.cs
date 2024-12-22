using System;
using System.Linq;
using System.Text;
using Xunit.Sdk;


namespace TestProject1.DataStructure
{
    public class LinkedLists<T> : Ilist<T>
    {
        protected Node<T> head;
        protected Node<T> tail;
        protected int currSize;

        public LinkedLists()
        {
            this.head = null;
            this.tail = null;
            this.currSize = 0;
        }
        public LinkedLists(T[] obj)
        {
            AddAll(obj);    
        }
        protected class Node<T>
        {
            public T Value { get; set; }
            public Node<T> Next { get; set; }
            public Node(T value)
            {
                this.Value = value;
                this.Next = null;
            }
        }

        public int Size()
        { return currSize; }

        public void Clear()
        {
            Node<T> currentNode = head;
            while (currentNode != null)
            {
                Node<T> nextNode = currentNode.next;
                currentNode.next = null;
                currentNode.value = default(T);
                currentNode = nextNode;
            }
            head = tail = null;
            currSize = 0;
        }
        public void Add(T value)
        {
            if (head == null)
            {
                head = new Node<T>(value);
                tail = head;
            }
            else
            {
                Node<T> newTail = new Node<T>(value);
                tail.next = newTail;
                tail = newTail;
            }
            currSize++;
        }
        public int FindPos(T value)
        {
            if (head == null)
            {
                throw new InvalidOperationException();
            }
            Node<T> findvalue = head;
            int pos = 0;
            //use loop for each element in List 
            while (findvalue != tail)
            {
                if (findvalue.Value.Equals(value))
                {
                    return pos;
                }
                findvalue = findvalue.Next;
                pos++;
            }

            return -1;
        }
        public void AddAll(T[] obj)
        {
            foreach (T item in obj)
            { Add(item); }
        }
        public bool Remove(T obj)
        {
            int num = FindPos(obj);
            if (num == -1)
            {
                throw new IndexOutOfRangeException();
            }
            RemoveAt(num);
            return true;

        }
        public T RemoveAt(int pos)
        {
            if (head == null)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (pos < 0 && pos > currSize)
            {
                throw new InvalidCastException();
            }
            Node<T> currNode = head;
            Node<T> preNode = head;
            for (int i = 0; i < pos; i++)
            {
                preNode = currNode;
                currNode = currNode.Next;
            }
            T currElement = currNode.Value;
            //skip Node at pos 
            preNode.Next = currNode.Next;
            currSize--;
            return currElement;
        }
        public T Get(int pos)
        {
            if (head == null)
            {
                throw new InvalidOperationException();
            }
            Node<T> currNode = head;
            int i = 0;
            while (i != pos)
            {
                currNode = currNode.Next;
                i++;
            }
            return currNode.Value;
        }
        public void Set(int pos, T value)
        {
            Node<T> currNode = head;
            if (pos < 0 || pos >= currSize)
            {
                throw new InvalidOperationException(" Set data invalid at pos = " + pos);
            }
            int i = 0;
            while (i != pos)
            {
                currNode = currNode.Next;
                i++;
            }
            currNode.Value = value;
        }

        public override string ToString()
        {
            if (currSize == 0)
            {
                return "[]";
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                Node<T> currNode = head;
                while (currNode != null)
                {
                    sb.Append(currNode.Value);
                    currNode = currNode.Next;

                    if (currNode != null)
                    {
                        sb.Append(", ");
                    }
                }
                return sb.ToString();
            }
        }
    }
}
