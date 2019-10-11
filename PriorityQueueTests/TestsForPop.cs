using NUnit.Framework;
using PriorityQueueAssignment;
using System.Collections.Generic;
using System;

namespace PriorityQueueTests
{
    public partial class PriorityQueueTests
    {
        public class TestsForPop
        {

            [Test]
            public void TestPop_PopsHighestIntPriority()
            {
                List<int> expected = new List<int> { 1, 2, 4, 5, 8, 9 };
                PriorityQueue<int> actual = new PriorityQueue<int>();
                actual.Add(2);
                actual.Add(8);
                actual.Add(9);
                actual.Add(4);
                actual.Add(5);
                actual.Add(1);
                for (int i = 0; i < actual.Count(); i++)
                {
                    Assert.AreEqual(expected[i], actual.Pop());
                }
            }
            [Test]
            public void TestPop_PopsHighestStringPriority()
            {
                List<string> expected = new List<string> { "god kväll", "god natt", "hej", "hejsan", "katt i en hatt" };
                PriorityQueue<string> actual = new PriorityQueue<string>();
                actual.Add("hej");
                actual.Add("god natt");
                actual.Add("hejsan");
                actual.Add("katt i en hatt");
                actual.Add("god kväll");
                for (int i = 0; i < actual.Count(); i++)
                {
                    Assert.AreEqual(expected[i], actual.Pop());
                }
            }
            [Test]
            public void TestPopDoesNotPopEmptyList()
            {
                var actual = new PriorityQueue<int>();
                Exception e = null;
                try
                {
                    actual.Pop();
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
            public void TestPeekCanNotPopEmptyListAfterAddingElementsAndPoppingAllElements()
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
                    actual.Pop();
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
            public void TestPopPopsCorrectlyWhenMixingPopAndAdd()
            {
                var actual = new PriorityQueue<int>();
                actual.Add(1);
                actual.Add(2);
                actual.Add(3);
                actual.Pop();
                actual.Add(2);
                actual.Pop();
                actual.Add(1);
                actual.Add(3);
                actual.Pop();
                Assert.AreEqual(2, actual.Pop());
            }
            [Test]
            public void TestPopSortsCorrectlyAfterPopping()
            {
                var rnd = new Random();
                var actual = new PriorityQueue<int>();
                for (int i = 0; i < 99999; i++)
                {
                    actual.Add(rnd.Next());
                }
                var prev = 0;
                while (actual.Count() > 0)
                {
                    var min = actual.Pop();
                    if (!(min >= prev))
                    {
                        Assert.Fail();
                        break;
                    }
                    prev = min;
                }
            }
        }
    }
}