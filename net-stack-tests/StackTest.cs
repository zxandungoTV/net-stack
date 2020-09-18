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

    [TestMethod]
    public void isEmpty_true_when_stackIsEmpty()
        {
            Assert.AreEqual(true, stack.isEmpty());
        }

        [TestMethod]
        public void isEmpty_false_after_calling_push()
        {

            stack.push("any");
            Assert.AreEqual(false, stack.isEmpty());
        }


        [TestMethod]
        public void peek_returns_null_if_stack_isEmpty()
        {
            Assert.AreEqual(null, stack.peek());
        }
        [TestMethod]
        public void peek_returns_most_recent()
        {
            stack.push("anything");
            Assert.AreEqual("anything", stack.peek());
        }

        [TestMethod]
        [ExpectedException(typeof(EmptyStackException))]
        public void pop_exception()
        {
            stack.pop();
        }

        [TestMethod]
        public void pop_returns_most_recent()
        {
            stack.push(123);
            Assert.AreEqual(123,stack.pop());
        }

        [TestMethod]
        public void peek_returns_null_after_pop()
        {
            stack.push("one");
            stack.pop();
            Assert.AreEqual(null, stack.peek());
        }
 
        [TestMethod]
        public void isEmpty_returns_true_after_pop()
        {
            stack.push("something");
            stack.pop();
            Assert.AreEqual(true, stack.isEmpty());
        }

        //	push() 3 times, pop() 
        // returns 3rd pushed value, 
        // pop() returns 2nd pushed value
        // then peek() returns 1st pushed value

        //push obj1
        //push ob2 
        //push obj3
        //obj3 -> ob2 -> ob1

        [TestMethod]
        public void push_e_elements_read_them_backwards()
        {
            stack.push("one");
            stack.push("two");
            stack.push("three");
            Assert.AreEqual("three", stack.pop());
            Assert.AreEqual("two", stack.pop());
            Assert.AreEqual("one", stack.peek());

        }
    }
}
