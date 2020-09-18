using net_stack.model.exceptions;
using System;
namespace net_stack
{
    public class Stack
    {

        public Object _value;
        public bool _isEmpty = true;
        // Implement code
        public bool isEmpty()
        {
            return _isEmpty;
        }

        public void push(Object v)
        {
            _value = v;
            _isEmpty = false;
        }

        public Object peek()
        {
            if (isEmpty())
            {
                return null;
            }
            else
            {
                return _value;
            }
            
        }

        public Object pop()
        {
            if (_isEmpty)
            {
                throw new EmptyStackException("is empty");
            }
            _isEmpty = true;
            return _value;
        }
    }
}
