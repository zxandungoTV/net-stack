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

        //	isEmpty() returns true if Stack is empty
        [TestMethod]
        public void isEmpty_Test(){
            bool value = stack.IsEmpty();
            Assert.IsTrue(value);
        }

        //isEmpty() returns false after calling push(value)
        [TestMethod]
        public void isEmpty_afterPush_test()
        {
            stack.Push(4);
            bool value = stack.IsEmpty();

            Assert.IsFalse(value);
        }

        //peek() returns null if Stack is empty
        [TestMethod]
        public void isEmpty_null_peek_test()
        {
            Assert.IsTrue(stack.IsEmpty());
            Assert.AreEqual(null, stack.Peek());
        }
        //	peek() returns most recent pushed value
        [TestMethod]
        public void Peek_test()
        {
            stack.Push(4);
            object value = stack.Peek();
            Assert.AreEqual(4, value);
        }
        //pop() throws EmptyStackException if Stack is empty
        [TestMethod]
        [ExpectedException(typeof(EmptyStackException))]
        public void isEmpty_pop_test()
        {
            Assert.IsTrue(stack.IsEmpty());
            stack.Pop();

        }
        //	pop() returns most recent pushed value
        [TestMethod]
        public void Pop_test()
        {
            stack.Push(4);
            object value = stack.Pop();
            Assert.AreEqual(4, value);

        }
        //	peek() returns null after pop() is called
        [TestMethod]
        public void Null_peek_after_pop()
        {
            stack.Push(4);
            stack.Pop();
            Assert.AreEqual(null, stack.Peek());

        }
        //	isEmpty() returns true after pop() is called
        [TestMethod]
        public void isEmpty_after_pop()
        {
            stack.Push(4);
            stack.Pop();
            Assert.IsTrue(stack.IsEmpty());

        }

        [TestMethod]
        public void Repeted_integration_test()
        {
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            Assert.AreEqual(6, stack.Pop());
            Assert.AreEqual(5, stack.Pop());
            Assert.AreEqual(4, stack.Peek());

        }

        //	contains(value) returns true if value is present

        [TestMethod]
        public void contains_test()
        {
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            Assert.IsTrue(stack.Contains(4));

            Assert.IsTrue(stack.Contains(5));

            Assert.IsTrue(stack.Contains(6));

        }
        //	contains(value) returns false if value is not present
        [TestMethod]
        public void DoesNotContain_test()
        {
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            Assert.IsFalse(stack.Contains(1));
        }
    }
}
