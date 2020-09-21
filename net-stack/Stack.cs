using net_stack.model.exceptions;
using System;
namespace net_stack
{
    public class Stack
    {
        Node top=null;
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

        public void Push(int v)
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
            return top.data;
        }

        public object Pop()
        {
            if (top == null)
            {
                throw new EmptyStackException("");
            }
            object value = top.data;
            top = top.next;
            return value;
        }

        public bool Contains(int v)
        {
            Node value = top;
            while (value != null)
            {
                if (value.data.Equals(v))
                {
                    return true;
                }
                value = value.next;
            }
            return false;
            /*if (Peek().Equals(v))
            {
                return true;
            }else if(Peek().Equals(null))
            {
                return false;
            }
            else 
            {
                top = top.next;
                return Contains(v);
                
            }*/
        }
    }

    public class Node
    {
        public int data;
        public Node next;

        public Node(int d)
        {
            this.data = d;
            this.next = null;
        }
    }
}
