using Microsoft.VisualStudio.TestTools.UnitTesting;
using net_stack;
using net_stack.model.exceptions;

namespace net_stack_tests
{
  [TestClass]
  public class StackTest
  {
    private Stack stack;

    [TestInitialize]
    public void SetUp()
    {
      stack = new Stack();
    }

    // implement tests
    //		isEmpty() returns true if Stack is empty	
    [TestMethod]
    public void isStackEmpty()
        {
            Assert.AreEqual(true, stack.isEmpty());
        }

   //isEmpty() returns false after calling push(value)
   [TestMethod]
   public void isEmpty_false_whenPushedIsCalled()
        {
            stack.push(10);
            Assert.AreEqual(false, stack.isEmpty());
        }

   // peek() returns null if Stack is empty
  [TestMethod]
  public void peek_returns_null_when_stack_is_Empty()
      {
            //Assert.AreEqual(true, stack.isEmpty());
            Assert.AreEqual(null, stack.peek());
      }
        //peek() returns most recent pushed value
  [TestMethod]
   public void peek_returns_most_recent_value_whenNotEmpty()
    {
            stack.push(345);
            Assert.AreEqual(345, stack.peek());
    }

        //pop() throws EmptyStackException if Stack is empty
  [TestMethod]
  [ExpectedException(typeof(EmptyStackException))]
  public void pop_returns_exception_when_stack_empty()
   {
            stack.pop(); 
   }
        // pop() returns most recent pushed value
   [TestMethod]
   public void pop_returns_most_recent_value()
   {
            stack.push(325);
            Assert.AreEqual(325, stack.pop());
   }
        //peek() returns null after pop() is called
        [TestMethod]
        public void peek_return_null_after_pop()
        {
            stack.push(325);
            stack.pop();
            Assert.AreEqual(null,stack.peek());
        }
    }
}
