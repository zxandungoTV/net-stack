using net_stack.model.exceptions;
using System;
namespace net_stack
{
    public class Stack
    {

        private bool _isEmpty = true;
        private Node _root = null;
        
        // Implement code
        public bool IsEmpty()
        {
            return _isEmpty;
        }

        public void Push(object item)
        {
            _isEmpty = false;
            if (_root == null)
            {
                _root = new Node() { data = item, next=null };
                return;
            }
            _root.next = new Node() { data = item, next = null };
        }

        public object Peek()
        {
            if (_isEmpty)
            {
                return null;
            }
            if (_root.next == null) 
            {
                return _root.data;
            }
            return _root.next.data;
        }

        public Object Pop()
        {
            if (_isEmpty)
            {
                throw new EmptyStackException("new exeption");
            }
            Object previuosValue = null;
            if(_root.next == null)
            {
                previuosValue = _root.data;
                _root = null;
                _isEmpty = true;
                return previuosValue;
            }
            previuosValue = _root.next.data;
            _root.next = null;
            return previuosValue;
        }

        public bool Contains(Object item)
        {
            if (_isEmpty)
            {
                return false;
            }
            if (_root.data.Equals(item))
            {
                return true;
            }
            if(_root.next == null)
            {
                return false;
            }
            return (_root.next.data.Equals(item));
            
        }
    }
    class Node
    {
        public Object data;
        public Node next;
    }
}
