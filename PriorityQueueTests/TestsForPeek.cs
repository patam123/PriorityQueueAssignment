using NUnit.Framework;
using PriorityQueueAssignment;
using System.Collections.Generic;
using System;

namespace PriorityQueueTests
{
    public partial class PriorityQueueTests
    {
        public class TestsForPeek
        {

            [Test]
            public void TestPeekReturnsHighestPriority()
            {
                List<int> expected = new List<int> { 1, 2, 4, 5, 8, 9 };
                PriorityQueue<int> actual = new PriorityQueue<int>();
                actual.Add(2);
                actual.Add(8);
                actual.Add(9);
                actual.Add(4);
                actual.Add(5);
                actual.Add(1);
                Assert.AreEqual(expected[0], actual.Peek());
            }
            [Test]
            public void TestPeekCanNotPeekNewEmptyList()
            {
                Exception e = null;
                var actual = new PriorityQueue<int>();
                try
                {
                    actual.Peek();
                }
                catch (InvalidOperationException exception)
                {
                    e = exception;
                }
                if (e == null)
                {
                    Assert.Fail();
                }
            }
            [Test]
            public void TestPeekCanNotPeekEmptyListAfterAddingAndPoppingAll()
            {
                Exception e = null;
                var actual = new PriorityQueue<int>();
                actual.Add(1);
                actual.Add(2);
                actual.Add(1);
                actual.Pop();
                actual.Add(2);
                actual.Pop();
                actual.Add(1);
                actual.Add(2);
                actual.Pop();
                actual.Pop();
                actual.Pop();
                actual.Pop();
                try
                {
                    actual.Peek();
                }
                catch (InvalidOperationException exception)
                {
                    e = exception;
                }
                if (e == null)
                {
                    Assert.Fail();
                }
            }
        }
    }
}