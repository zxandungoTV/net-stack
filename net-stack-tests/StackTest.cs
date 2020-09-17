using Microsoft.VisualStudio.TestTools.UnitTesting;
using net_stack;
using net_stack.model.exceptions;
using System;

namespace net_stack_tests
{
  [TestClass]
  public class StackTest
  {
    private Stack<int?> stack;

    [TestInitialize]
    public void SetUp()
    {
      stack = new Stack<int?>();
    }

    // implement tests

    [TestMethod]
    public void test_isEmpty()
    {
       Assert.AreEqual(true, stack.isEmpty());
    }

    [TestMethod]
    public void test_AfterPush_isEmpty_false()
        {
            stack.push(123);
            Assert.AreEqual(false, stack.isEmpty());
        }
   [TestMethod]
   public void test_peek_returnsNull_whenStackEmpty()
        {
            Assert.IsNull(stack.peek());
        }

    [TestMethod]
    public void test_peek_returnLastInsertedValue()
        {
            stack.push(123);
            Assert.AreEqual(123, stack.peek());
        }

    [TestMethod]
    [ExpectedException(typeof(EmptyStackException))]
    public void test_pop_throwsExceptionWhenEmpty()
        {
            stack.pop();
        }

    [TestMethod]
    public void test_pop_shouldReturnLastValue()
        {
            stack.push(123);
            Assert.AreEqual(123, stack.pop());
        }

    [TestMethod]
    public void test_peek_returnNull_afterPop()
        {
            stack.push(123);
            Assert.AreEqual(123, stack.pop());
            Assert.IsNull(stack.peek());
        }

    [TestMethod]
    public void test_isEmpty_returnsTrue_afterPop()
        {
            stack.push(123);
            Assert.AreEqual(123, stack.pop());
            Assert.IsTrue(stack.isEmpty());
        }
    /*push() twice, pop() returns 2nd pushed value, 
     * then peek() returns 1st pushed value*/

        [TestMethod]
        public void test_pushTwice_popReturnsSecondValue_peekReturnsFirstPushedValue()
        {
            stack.push(1);
            stack.push(2);

        }


    }
}
