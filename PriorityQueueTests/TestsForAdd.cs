using NUnit.Framework;
using PriorityQueueAssignment;
using System.Collections.Generic;

namespace PriorityQueueTests
{
    public partial class PriorityQueueTests
    {
        public class TestsForAdd
        {
            [Test]
            public void TestAddSortsIntCorrectly()
            {
                List<int> expected = new List<int> { 1, 2, 4, 5, 8, 9 };
                PriorityQueue<int> actual = new PriorityQueue<int>();
                actual.Add(2);
                actual.Add(8);
                actual.Add(9);
                actual.Add(4);
                actual.Add(5);
                actual.Add(1);
                Assert.AreEqual(actual.Peek(), expected[0]);
            }
            [Test]
            public void TestAddSortsStringCorrectly()
            {
                List<string> expected = new List<string> { "god kväll", "god natt", "hej", "hejsan", "katt i en hatt" };
                PriorityQueue<string> actual = new PriorityQueue<string>();
                actual.Add("hej");
                actual.Add("god natt");
                actual.Add("hejsan");
                actual.Add("katt i en hatt");
                actual.Add("god kväll");
                Assert.AreEqual(actual.Peek(), expected[0]);
            }
            [Test]
            public void TestAddSortsIntCorrectlyAfterAddingAndPopping()
            {
                List<int> expected = new List<int> { 1, 2, 4, 5, 8, 9 };
                PriorityQueue<int> actual = new PriorityQueue<int>();
                actual.Add(2);
                actual.Add(8);
                actual.Add(9);
                actual.Pop();
                expected.RemoveAt(0);
                actual.Add(4);
                actual.Add(5);
                actual.Add(1);
                actual.Add(6);
                expected.Add(6);
                expected.Sort();
                actual.Add(3);
                expected.Add(3);
                expected.Sort();
                actual.Pop();
                expected.RemoveAt(0);

                Assert.AreEqual(actual.Peek(), expected[0]);
            }
        }
    }
}