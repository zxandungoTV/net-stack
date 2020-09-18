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
        public void test_isEmpty()
        {
            var expected = true;
            var actual = stack.isEmpty();
            Assert.AreEqual(expected,actual);
        }
        //	isEmpty() returns false after calling push(value)
        [TestMethod]
        public void test_isEmpty_afterPush()
        {
            stack.push("one");
            var expected = false;
            var actual = stack.isEmpty();
            Assert.AreEqual(expected, actual);
        }
        //peek() returns null if Stack is empty
        [TestMethod]
        public void test_peek_retrunNull_whenEmpty()
        {
            object expected = null;
            var actual = stack.peek();
            Assert.AreEqual(expected, actual);
        }
        //	peek() returns most recent pushed value
        [TestMethod]
        public void test_peek_retrunRecentValue()
        {
            stack.push("one");
            object expected = "one";
            var actual = stack.peek();
            Assert.AreEqual(expected, actual);
        }
        //	pop() throws EmptyStackException if Stack is empty
        [TestMethod]
        [ExpectedException(typeof(EmptyStackException))]
        public void test_pop_emptyException()
        {
            stack.pop();
        }

        [TestMethod]
        public void test_pop_recentPush()
        {
            stack.push("one");
            object expected = "one";
            var actual = stack.pop();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void test_peek_returnsNullAfterPoph()
        {
            stack.push("one");
            stack.pop();
            object expected = null;
            var actual = stack.peek();
            Assert.AreEqual(expected, actual);
        }

        //	isEmpty() returns true after pop() is called
        [TestMethod]
        public void test_isEmpty_afterPop()
        {
            stack.push("one");
            stack.pop();
            var expected = true;
            var actual = stack.isEmpty();
            Assert.AreEqual(expected, actual);
        }

        /*push() twice, 
         * pop() returns 2nd pushed value, 
         * then peek() returns 1st pushed value*/
        [TestMethod]
        public void test_three_pop_then_peek()
        {
            stack.push("one");
            stack.push("two");
            stack.push("three");

            var actualPop1 =stack.pop();
            var expectedPop1 = "three";
            Assert.AreEqual(expectedPop1, actualPop1);

            var actualPop2 = stack.pop();
            var expectedPop2 = "two";
            Assert.AreEqual(expectedPop2, actualPop2);

            var actualPeek = stack.peek();
            var expectedPeek = "one";
            Assert.AreEqual(expectedPeek, actualPeek);
        }

        //contains(value) returns true if value is present
        [TestMethod]
        public void test_contains_true_ifValue()
        {
            stack.push("one");
            stack.push("two");
            stack.push("three");
            var actual = stack.contains("two");
            var expected = true;
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected, stack.contains("one"));
            Assert.AreEqual(expected, stack.contains("three"));

        }
        //	contains(value) returns false if value is not present
        [TestMethod]
        public void test_contains_false_ifNoValue()
        {
            stack.push("one");
            stack.push("two");
            stack.push("three");
            var actual = stack.contains("four");
            var expected = false;
            Assert.AreEqual(expected, actual);

            Assert.AreEqual(expected, stack.contains("sdgsdgs"));

            Assert.AreEqual(expected, stack.contains("sdgsdgs"));

            Assert.AreEqual(expected, stack.contains("sdgsdgs"));


        }
    }
}
