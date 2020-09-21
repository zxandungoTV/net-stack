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
        public void isEmpty_true()
        {
            Assert.AreEqual(true,stack.IsEmpty());
        }

        //	isEmpty() returns false after calling push(value)
        [TestMethod]
        public void isEmpty_false()
        {
            stack.push(5);
            Assert.AreEqual(false, stack.IsEmpty());
        }

        //	peek() returns null if Stack is empty
        [TestMethod]
        public void peek_returnsNull()
        {
            object data = stack.Peek();
            Assert.AreEqual(null, data);
        }
        //	peek() returns most recent pushed value

        [TestMethod]
        public void peek_retunsValue()
        {
            int test = 3;
            stack.push(test);
            object data = stack.Peek();
            Assert.AreEqual(test, data);
        }
        //	pop() throws EmptyStackException if Stack is empty

        [TestMethod]
        [ExpectedException(typeof(EmptyStackException))]
        public void pop_EmptyException() 
        {
            stack.Pop();
  
        }

        //	pop() returns most recent pushed value
        [TestMethod]
        public void pop_returnValue()
        {
            object test = "testDataTest";
            stack.push(test);
            object result = stack.Pop();
            Assert.AreEqual(test, result);
            
        }

        //	peek() returns null after pop() is called

        [TestMethod]
        public void peek_returnNull()
        {

            object test = "testDataTest";
            stack.push(test);
            object pop = stack.Pop();
            object result = stack.Peek();
            Assert.AreEqual(null, result);
        }

        //isEmpty() returns true after pop() is called

        [TestMethod]
        public void isEmpty_returntrueAfterPop()
        {
            object test = "testDataTest";
            stack.push(test);
            object pop = stack.Pop();
            Assert.AreEqual(true, stack.IsEmpty());
        }
        //push() twice, pop() returns 2nd pushed value, then peek() returns 1st pushed value
        [TestMethod]
        public void push_Pop_peek_test()
        {
            object test_1 = "testDataOne";
            stack.push(test_1);
            object test_2 = "testDataTwo";
            stack.push(test_2);
            object test_3 = "testDataThree";
            stack.push(test_3);

            object pop = stack.Pop();
            Assert.AreEqual(test_3, pop);

            pop = stack.Pop();
            Assert.AreEqual(test_2, pop);

            pop = stack.Peek();
            Assert.AreEqual(test_1, pop);

        }

        //	contains(value) returns true if value is present
        [TestMethod]
        public void contains_test()
        {
            object test_1 = "testDataOne";
            stack.push(test_1);
            object test_2 = "testDataTwo";
            stack.push(test_2);
            object test_3 = "testDataThree";
            stack.push(test_3);

            object contains = "testDataTwo";

            Assert.AreEqual(true, stack.Contains(contains));
            Assert.AreEqual(true, stack.Contains(test_1));
            Assert.AreEqual(true, stack.Contains(test_3));

        }

        //contains(value) returns false if value is not present
        [TestMethod]
        public void contains_test_false()
        {
            object test_1 = "testDataOne";
            stack.push(test_1);
            object test_2 = "testDataTwo";
            stack.push(test_2);
            object test_3 = "testDataThree";
            stack.push(test_3);

            object contains = "data";

            Assert.AreEqual(false, stack.Contains(contains));
            Assert.AreEqual(false, stack.Contains("dfasdf"));
            Assert.AreEqual(false, stack.Contains("dfsdf"));

        }

        //size() returns number of elements in Stack (tracked by variable)
       /* [TestMethod]
        public void size_Test()
        {
            object test_1 = "testDataOne";
            stack.push(test_1);
            object test_2 = "testDataTwo";
            stack.push(test_2);
            object test_3 = "testDataThree";
            stack.push(test_3);

            Assert.AreEqual(3, stack.Size());

        }*/
    }
}
