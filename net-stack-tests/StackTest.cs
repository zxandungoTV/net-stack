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

        //isEmpty() returns true if Stack is empty
        [TestMethod]
        public void CheckStackEmpty()
        {
            bool expected = true;
            Assert.AreEqual(expected,stack.isEmpty());
        }
        //	isEmpty() returns false after calling push(value)
        [TestMethod]
        public void CheckStackNotEmpty()
        {
            stack.push(123);
            bool expected = false;
            Assert.AreEqual(expected, stack.isEmpty());
        }
        //	peek() returns null if Stack is empty
        [TestMethod]
        public void PeekReturnNullWhenEmpty()
        {
            Assert.AreEqual(null, stack.peek());
        }
        //peek() returns most recent pushed value
        [TestMethod]
        public void PeekReturnMostRecentValue()
        {
            stack.push(123);
            Assert.AreEqual(123, stack.peek());
        }
        //	pop() throws EmptyStackException if Stack is empty
        [TestMethod]
        [ExpectedException(typeof(EmptyStackException))]
        public void PopException()
        {
            stack.pop();
        }
        //pop() returns most recent pushed value
        [TestMethod]
        public void PopReturnMostRecent()
        {
            stack.push(123);
            Assert.AreEqual(123, stack.pop());
        }
        //	peek() returns null after pop() is called
        [TestMethod]
        public void PeekReturnsNullAfterPop()
        {
            stack.push(123);
            stack.pop();
            Assert.AreEqual(null, stack.peek());
        }
        //	isEmpty() returns true after pop() is called
        [TestMethod]
        public void IsEmptyIsTrueAfterPop()
        {
            stack.push(123);
            stack.pop();
            Assert.AreEqual(true, stack.isEmpty());
        }
        //push() twice, pop() returns 2nd pushed value, 
        //then peek() returns 1st pushed value
        [TestMethod]
        public void PushTwiceReturn()
        {
            stack.push(123);
            stack.push(456);
            Assert.AreEqual(456, stack.pop());
            Assert.AreEqual(123, stack.peek());
        }
        //	contains(value) returns true if value is present
        [TestMethod]
        public void ContainsTrue()
        {
            stack.push(123);
            stack.push(456);
            stack.push(756);
            stack.push(952);
            Assert.AreEqual(true, stack.contains(123));
        }
    }
}
