using net_stack.model.exceptions;
using System;
namespace net_stack
{
    public class Stack
    {
        public Node head = null;
        int size = 0;
        // Implement code
        public bool IsEmpty()
        {

            return head == null;
        }

        public void Push(Object v)
        {
            Node newNode = new Node(v);
            if(head == null)
            {
                head = new Node(v);
            }
            else
            {
                Node temp = head;
                head = newNode;
                head.next = temp;
            }

            size++;
        }

        public object Peek()
        {
            if(head != null)
            {
                return head.data;

            }
            return null;
        }

        public object Pop()
        {
            if(head != null)
            {
                var value = head.data;
                head = head.next;
                size--;
                return value;
            }
            else
            {
                throw new EmptyStackException("");

            }

        }

        public bool Contains(Object v)
        {
            Node temp = head;
            while(temp != null)
            {
                if (temp.data.Equals(v))
                {
                    return true;
                }
                temp = temp.next;
            }
            return false;
        }

        public int Size()
        {
            return size;
        }

        public Object PeekN(int v)
        {
            if (v >= size)
            {
                return null;
            }
            Node temp = head;
            for (int i = 0; i < size-v-1; i++)
            {
                temp = temp.next;
            }
            return temp.data;
        }
    }

    public class Node
    {
        public Object data;
        public Node next;

        public Node(Object data)
        {
            this.data = data;
            this.next = null;
        }
    }
}
