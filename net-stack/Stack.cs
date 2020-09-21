using net_stack.model.exceptions;
using System;
namespace net_stack
{
    public class Stack
    {
        Node top = null;
        public int size = 0;
        // Implement code
        public bool IsEmpty()
        {
            if(top == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void push(Object v)
        {
            Node newNode = new Node(v);

            if(top == null)
            {
                newNode.next = null;
            }
            else
            {
                newNode.next = top;
            }
            top = newNode;
        }

        public object Peek()
        {
            if(top == null)
            {
                return null;
            }
            else
            {
                return top.data;

            }
        }

        public Object Pop()
        {
            Node temp = top;
            if (IsEmpty())
            {
                throw new EmptyStackException("");

            }
            else
            {
                top = top.next;
                return temp.data;
            }
        }

        public bool Contains(object contains)
        {
            Node current = top;
            
            while (current.next != null)
            {
                if (current.data.Equals(contains))
                {
                    return true;
                }
                else
                {
                    current = current.next;
                }
            }
            return current.data.Equals(contains);
        }

        public int Size()
        {
            return this.size;
        }
    }

    class Node
    {
        public Object data;
        public Node next;

        public Node (Object data)
        {
            this.data = data;
            this.next = null;
        }
    }
}
