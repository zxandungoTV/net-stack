using System;
namespace net_stack.model.exceptions
{
  public class EmptyStackException : Exception
  {

        public EmptyStackException(string message) : base(message)
    {
    }
  }
}
