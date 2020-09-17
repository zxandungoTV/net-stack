using net_stack.model.exceptions;
using System;
namespace net_stack
{
    public class Stack
    {
        Node top = null;
        // Implement code
        public bool IsEmpty()
        {
            if( top == null)
            {
                return true;
            }
            return false;
        }

        public void push(Object v)
        {
            Node newNode = new Node(v);
            if(top == null)
            {
                top = newNode;
            }
            else
            {
                newNode.next = top;
                top = newNode;
            }
            
        }

        public Object Peek()
        {
            if(top == null)
            {
                return null;
            }
            return top.data;
        }

        public Object Pop()
        {
            if (top==null)
            {
                throw new EmptyStackException("exception");

            }
            Node remove = top;
            top = top.next;
            return remove.data;
        }

        public bool Contains(Object v)
        {
            Node current = top;
            while (current.next != null) {
                if (v.Equals(current.data))
                {
                    return true;
                }
    
              current = current.next;
                
            }
            return v.Equals(current.data);
        }
    }

    class Node
    {
       public  Object data;
        public Node next;

        public Node(Object data)
        {
            this.data = data;
            this.next = null;
        }
    }
}
