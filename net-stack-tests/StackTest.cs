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
        public void IsEmpty_True()
        {
            Assert.IsTrue(stack.IsEmpty());
        }
        //	isEmpty() returns false after calling push(value)
        [TestMethod]
        public void IsEmpty_False()
        {
            stack.Push(1);
            Assert.IsFalse(stack.IsEmpty());
        }

        //peek() returns null if Stack is empty

        [TestMethod]
        public void Peek_empty()
        {
            Assert.AreEqual(null, stack.Peek());
        }
        //	peek() returns most recent pushed value

        [TestMethod]
        public void Peek_recent()
        {
            stack.Push(1);

            Assert.AreEqual(1, stack.Peek());
        }
        //pop() throws EmptyStackException if Stack is empty
        [TestMethod]
        [ExpectedException(typeof(EmptyStackException))]
        public void Pop_empty()
        {
            stack.Pop(); 
        }
        //pop() returns most recent pushed value	
        [TestMethod]
        public void Pop_recent()
        {
            stack.Push(1);
            Assert.AreEqual(1, stack.Pop());
        }
        //peek() returns null after pop() is called	
        [TestMethod]
        public void Peek_Pop_null()
        {
            stack.Push(1);
            stack.Pop();
            Assert.AreEqual(null, stack.Peek());
        }
        //	isEmpty() returns true after pop() is called

        [TestMethod]
        public void Pop_isEmpty_true()
        {
            stack.Push(1);
            stack.Pop();
            Assert.IsTrue(stack.IsEmpty());
        }

        //push() twice, pop() returns 2nd pushed value, 
        //then peek() returns 1st pushed value

        [TestMethod]
        public void pop_peek_multiple()
        {
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Assert.AreEqual(3, stack.Pop());
            Assert.AreEqual(2, stack.Pop());
            Assert.AreEqual(1, stack.Peek());

        }

        //contains(value) returns true if value is present
        [TestMethod]
        public void Contains_true()
        {
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Assert.IsTrue(stack.Contains(1));
            Assert.IsTrue(stack.Contains(2));
            Assert.IsTrue(stack.Contains(3));

        }

        //contains(value) returns false if value is not present	
        [TestMethod]
        public void Contains_false()
        {
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Assert.IsFalse(stack.Contains(7));
            Assert.IsFalse(stack.Contains(782));
            Assert.IsFalse(stack.Contains(3856));

        }

        //size() returns number of elements in Stack (tracked by variable)
        [TestMethod]
        public void Size_valid()
        {
            Assert.AreEqual(0, stack.Size());
            stack.Push(1);
            Assert.AreEqual(1, stack.Size());
            stack.Pop();
            Assert.AreEqual(0, stack.Size());
        }
        // peekN(index) returns nth value of Linked List at specified index	
        [TestMethod]
        public void PeekN_valid()
        {

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);


            Assert.AreEqual(1, stack.PeekN(0));
            Assert.AreEqual(2, stack.PeekN(1));
            Assert.AreEqual(3, stack.PeekN(2));
        }
        //peekN(index) returns null if no value exists at specified index
        [TestMethod]
        public void PeekN_Null()
        {

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Assert.AreEqual(null, stack.PeekN(3));
            Assert.AreEqual(null, stack.PeekN(100));
        }
    }
}
