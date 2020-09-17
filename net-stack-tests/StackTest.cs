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
        public void isEmpty_returnsTrue()
        {
            //Assert.IsTrue(stack.isEmpty());
            Assert.AreEqual(true, stack.isEmpty());
        }
        [TestMethod]
        public void isEmpty_whenPushAnObject_shouldReturnTrue()
        {
            stack.push("new thisng");
            Assert.AreEqual(false, stack.isEmpty());
        }

        [TestMethod]
        public void peek_whenItsEmpty_showReturnNull()
        { 
            Assert.AreEqual(null, stack.peek());
            //Assert.IsNull(stack.peek());
        }
        [TestMethod]
        public void peek_whenItHasObject_ReturnNotNull()
        {
            object expected = new object();
            stack.push(expected);
            Assert.AreEqual(expected, stack.peek());
        }

        [TestMethod]
        public void pop_whenYouPushOneElem()
        {
            stack.push(123);
            Assert.AreEqual(123, stack.pop());
            Assert.AreEqual(true, stack.isEmpty());
            Assert.AreEqual(null, stack.peek());
        }
        [TestMethod]
        public void pop_WhenTouPushThreeElements_returnInReverseOrder()
        {
            stack.push(1);
            stack.push(2);
            stack.push(3);
            Assert.AreEqual(3, stack.pop());
            Assert.AreEqual(2, stack.pop());
            Assert.AreEqual(1, stack.pop());
        }
        [TestMethod]
        public void return_true_isItContains()
        {
            stack.push(1);
            stack.push(2);
            stack.push(3);
            Assert.AreEqual(true, stack.contains(1));
            Assert.AreEqual(true, stack.contains(2));
            Assert.AreEqual(true, stack.contains(3));
        }
        // 1
        // 2 -> 1
        // 3 -> 2 -> 1
        [TestMethod]
        public void return_false_isItContains()
        {
            stack.push(1);
            stack.push(2);
            stack.push(3);
            Assert.AreEqual(false, stack.contains(4));
        }
        /* [TestMethod]
         [ExpectedException(typeof(EmptyStackException))]
         public void pop_shouldTrhowException()
         {
             stack.push(123);
             Assert.AreEqual(123, stack.pop());
             Assert.AreEqual(true, stack.isEmpty());
             Assert.AreEqual(null, stack.peek());
         }*/


    }
}
