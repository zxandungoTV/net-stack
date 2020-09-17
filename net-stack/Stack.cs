using net_stack.model.exceptions;
using System;
namespace net_stack
{
    public class Stack
    {
        public bool _isEmpty = true;

        public Object obj = null;
        // Implement code
        public bool isEmpty()
        {
            return _isEmpty;
        }

        public void push(Object v)
        {
            _isEmpty = false;
            obj = v;
        }

        public object peek()
        {
            if(_isEmpty)
            {
                return null;
            }
            else
            {
                return obj;
            }
            
        }
        public Object pop()
        {
            if (_isEmpty)
            {
                throw new EmptyStackException("new exception");

            }
            else
            {
                Object temp = obj;
                obj = null;
                return temp;


                /*_isEmpty = true;
                return obj;*/
            }
        }
    }
}
