using net_stack.model.exceptions;
using System;
namespace net_stack
{
    public class Stack
    {
        Node head;
        public bool _isEmpty = true;
        Object element = null;
        // Implement code
        public bool isEmpty()
        {
            //return true/false for first test
            return head == null;
        }

        public void push(Object obj)
        {
             element = obj;
            //_isEmpty = false;

            Node node = new Node();
            node.data = obj;
            node.next = head;
            head = node;
            
        }

        public Object peek()
        {
            if(head == null)
            {
                return null;
            }
            return head.data;
        }

        public Object pop()
        {
            /*Object temp = element;
            element = null;
            return temp;*/


            Object temp = head.data;
            head =head.next;
            return temp;

        }

        public bool contains(Object obj)
        {
            Node current = head;
            while (current.next != null)
            {
                if (obj.Equals(current.data))
                {
                    return true;
                }
                current = current.next;
            }
            return obj.Equals(current.data);
        }
    }

    class Node
    {
        public Object data;
        public Node next;
    }
}
