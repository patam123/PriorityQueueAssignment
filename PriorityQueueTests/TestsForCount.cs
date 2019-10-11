using NUnit.Framework;
using PriorityQueueAssignment;

namespace PriorityQueueTests
{
    public partial class PriorityQueueTests
    {
        public class TestsForCount
        {
            [Test]
            public void TestCountReturnCorrectCount()
            {
                var actual = new PriorityQueue<int>();
                Assert.AreEqual(0, actual.Count());
                actual.Add(1);
                actual.Add(2);
                Assert.AreEqual(2, actual.Count());
            }
            [Test]
            public void TestCountDoesNotReturnWrongCount()
            {
                var actual = new PriorityQueue<int>();
                Assert.AreEqual(0, actual.Count());
                actual.Add(1);
                actual.Add(1);
                actual.Add(1);
                Assert.AreNotEqual(2, actual.Count());
            }
            [Test]
            public void TestCountReturnsCorrectCountAfterPeeking()
            {
                var actual = new PriorityQueue<int>();
                actual.Add(1);
                actual.Add(1);
                actual.Peek();
                Assert.AreEqual(2, actual.Count());
            }
            [Test]
            public void TestCountReturnsCorrectCountAfterPopping()
            {
                var actual = new PriorityQueue<int>();
                actual.Add(1);
                actual.Add(1);
                actual.Pop();
                Assert.AreEqual(1, actual.Count());
            }
            [Test]
            public void TestCountIsZeroForNewQueue()
            {
                var actual = new PriorityQueue<int>();
                Assert.AreEqual(0, actual.Count());
            }

        }
    }
}