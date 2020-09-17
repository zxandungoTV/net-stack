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
    public void IsEmpty()
        {
            Assert.IsTrue(stack.IsEmpty());
        }

        [TestMethod]
        public void Is_non_empty_after_push()
        {
            stack.Push(new object());
            Assert.IsFalse(stack.IsEmpty());
        }

        [TestMethod]
        public void Peek_is_null_when_stack_Isempty()
        {
            Assert.IsNull(stack.Peek());
        }
 
        [TestMethod]
        public void Peek_returns_most_recent_pushed_value()
        {
            stack.Push("one");
            Assert.AreEqual("one", stack.Peek());
        }
  
        [TestMethod]
        [ExpectedException(typeof(EmptyStackException))]
        public void Pop_throws_exception_when_stack_empty()
        {
            stack.Pop();
        }
  
        [TestMethod]
        public void Pop_return_most_recent_pushed_value()
        {
            stack.Push("one");
            Assert.AreEqual("one", stack.Pop() as string);
        }
        //	come back to this
        [TestMethod]
        public void Peek_returns_null_after_Pop()
        {
            stack.Push("one");
            stack.Pop();
            Assert.IsNull(stack.Peek());
        }
        [TestMethod]
        public void IsEmpty_return_true_after_pop_is_called()
        {
            stack.Push("one");
            stack.Pop();
            Assert.IsTrue(stack.IsEmpty());
        }
        //	push() twice, pop() returns 2nd pushed value, 
        //then peek() returns 1st pushed value
        [TestMethod]
        public void Pushed_two_elements_read_inReverse_order()
        {
            stack.Push("one");
            stack.Push("two");
            Assert.AreEqual("two",stack.Pop());
            Assert.AreEqual("one", stack.Peek());
        }

        //contains(value) returns true if value is present
        [TestMethod]
        public void Returns_true_is_same_value_is_present()
        {
            stack.Push("one");
            Assert.IsTrue(stack.Contains("one"));
        }
        //contains(value) returns false if value is not present
        [TestMethod]
        public void Returns_false_is_same_value_is_not_present()
        {
            stack.Push("one");
            Assert.IsFalse(stack.Contains("two"));
        }
    }
}
