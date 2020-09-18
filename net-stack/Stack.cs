using net_stack.model.exceptions;
using System;
namespace net_stack
{
    public class Stack
    {
        Node head = null;
        // Implement code
        public bool isEmpty()
        {
            if(head == null)
            {
                return true;
            }
            return false;
        }

        public void push(Object v)
        {
            Node newNode = new Node() {data=v };
            newNode.next = head;
            head = newNode;
        }

        public object peek()
        {
            if(head == null)
            {
                return null;
            }
            else
            {
                return head.data;
            }
        }

        public Object pop()
        {
            if(head == null)
            {
                throw new EmptyStackException("");

            }
            else
            {
                Object result = head.data;
                head = head.next;
                return result;
            }
        }

        public bool contains(Object v)
        {
            Node current = head;
            while(current != null)
            {
                if (current.data.Equals(v)) 
                {
                    return true;
                }
                current = current.next;

            }
            return false;
        }
    }

    class Node
    {
        public Object data;
        public Node next; 

    }
}
