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
    public void isEpmpty()
        {
            Assert.AreEqual(true, stack.IsEmpty());
        }

        [TestMethod]
        public void isEpmpty_false_after_push()
        {
            stack.push(1);
            Assert.AreEqual(false, stack.IsEmpty());
        }
        //	peek() returns null if Stack is empty

        [TestMethod]
        public void peek_returns_null_ifStackEmpty()
        {
            Assert.AreEqual(null, stack.Peek());
        }
        //	peek() returns most recent pushed value
        [TestMethod]
        public void peek_returns_most_recent_pushedValue()
        {
            stack.push(1);
            Assert.AreEqual(1, stack.Peek());
        }

        //pop() throws EmptyStackException if Stack is empty

        [TestMethod]
        [ExpectedException(typeof(EmptyStackException))]
        public void pop_throws_exception_whe_stack_empty()
        {
            stack.Pop();
        }
        //pop() returns most recent pushed value
        [TestMethod]
        public void pop_returns_most_recent_value()
        {
            stack.push(1);
            Assert.AreEqual(1, stack.Pop());
        }

        //peek() returns null after pop() is called

        [TestMethod]
        public void pop_returns_null_when_pop_is_called()
        {
            stack.push(1);
            Assert.AreEqual(1, stack.Pop());
            Assert.AreEqual(null, stack.Peek());
        }
        //isEmpty() returns true after pop() is called
        [TestMethod]
        public void isEmpty_returns_true_when_pop_is_called()
        {
            stack.push(1);
            Assert.AreEqual(1, stack.Pop());
            Assert.IsTrue(stack.IsEmpty());
        }

        //	push() twice, pop() 
        //returns 2nd pushed value, then peek() returns 1st pushed value
        [TestMethod]
        public void push_three_values_pop_two_peek_last()
        {
            stack.push(1);

            stack.push(2);

            stack.push(3);

            Assert.AreEqual(3, stack.Pop());
            Assert.AreEqual(2, stack.Pop());
            Assert.AreEqual(1, stack.Peek());
        }

        [TestMethod]
        public void contains_returns_true_if_value_is_present()
        {
            stack.push(1);
            Assert.IsTrue(stack.Contains(1));
        }
        //contains(value) returns false if value is not present
        [TestMethod]
        public void contains_returns_false_if_value_is_NOT_present()
        {
            stack.push(1);
            Assert.IsFalse(stack.Contains(2));
        }

        [TestMethod]
        public void contains_returns_true_if_multiple_value_is_present()
        {
            stack.push(1);
            stack.push(2);
            stack.push(3);
            Assert.IsTrue(stack.Contains(1));
            Assert.IsTrue(stack.Contains(2));
            Assert.IsTrue(stack.Contains(3));
        }

        [TestMethod]
        public void contains_returns_false_if_multiple_value_is_present()
        {
            stack.push(1);
            stack.push(2);
            stack.push(3);
            Assert.IsFalse(stack.Contains(5));
            Assert.IsFalse(stack.Contains(4));
            Assert.IsFalse(stack.Contains(6));
        }
    }
}
