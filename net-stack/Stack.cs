using net_stack.model.exceptions;
using System;
namespace net_stack
{
    public class Stack
    {
        Node head = null;
        bool _isEmpty = true;
        // Implement code
        public bool isEmpty()
        {
            if (head == null)
            {
                return true;
            }
            else return false;
        }

        public void push(Object v)
        {
            
            Node obj = new Node(v);
            obj.next = head;
            head = obj;

            _isEmpty = false;
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
            if(head == null)
            {
                throw new EmptyStackException("");
            }
            else
            {
                //head last node == node3
                // node3 -> node2 -> node1
                //return node3.data -> back to the user
                //node2 -> node1 -> null
                Object obj = head.data;
                head = head.next;
                return obj;
            }
        }
        class Node
        {
            public Object data;
            public Node next;

            public Node(Object ent)
            {
                this.data = ent;
                this.next = null;
            }

        }

        public bool contains(Object v)
        {
            Node current = head;
            while (current.data != null)
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
}
