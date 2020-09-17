using net_stack.model.exceptions;
using System;
namespace net_stack
{
    public class Stack<T>
    {
        private Node<int?> _node = new Node<int?>();
        private bool _isEmpty = true;
        // Implement code
        public bool isEmpty()
        {
            return _isEmpty;
        }

        public void push(int v)
        {
          
            if (this._node.data == null)
            {
                this._node.data = v;
            }
            else
            {
                this._node.next.data = v;
            }

            //this._val = v;
            this._isEmpty = false ;
        }

        public int? peek()
        {

            if (this._isEmpty)
            {
                return null;
            }
            else
            {
                if(this._node.next.data == null)
                {
                    return this._node.data;
                }
                else
                {
                    return this._node.next.data;
                }
            }
            
        }

        public int? pop()
        {
           
            
            if (this._isEmpty)
            {
                throw new EmptyStackException("");
            }
            else
            {
                int? returnVal = null;
                if (this._node.next.data == null)
                {
                    returnVal = this._node.data;
                }
                else
                {
                    returnVal = this._node.next.data;
                }
                this._isEmpty = true;
                return returnVal;
                
            }
            
        }
    }
    
    class Node<T>
    {
        public T data;
        public Node<T> next = new Node<T>();
    }
}
