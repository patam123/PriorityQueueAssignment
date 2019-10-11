using PriorityQueue;
using System;
using System.Collections.Generic;

namespace PriorityQueueAssignment
{
    public class PriorityQueue<T> : IPriorityQueue<T> where T : IComparable, IComparable<T>
    {
        private List<T> backingList;
        public PriorityQueue()
        {
            backingList = new List<T>();
        }
        public void Add(T value)
        {
            backingList.Add(value);
            int parent = 0;
            int child = backingList.Count - 1;
            if (backingList.Count > 0)
            {
                parent = (child - 1) / 2;
            }
            while (backingList[child].CompareTo(backingList[parent]) < 0)
            {
                var temp = backingList[parent];
                backingList[parent] = backingList[child];
                backingList[child] = temp;
                child = parent;
                parent = (child - 1) / 2;
            }
        }
        public int Count()
        {
            return backingList.Count;
        }

        public T Peek()
        {
            if (backingList.Count == 0)
            {
                throw new InvalidOperationException();
            }
            return backingList[0];
        }
        public T Pop()
        {
            if (backingList.Count == 0)
            {
                throw new InvalidOperationException();
            }
            var result = backingList[0];
            backingList[0] = backingList[backingList.Count - 1];
            backingList.RemoveAt(backingList.Count - 1);
            int parent = 0;
            int leftIndex = parent * 2 + 1;
            int rightIndex = parent * 2 + 2;
            while (leftIndex < backingList.Count)
            {
                var smallestIndex = leftIndex;

                if (rightIndex < backingList.Count && backingList[rightIndex].CompareTo(backingList[leftIndex]) < 0)
                {
                    smallestIndex = rightIndex;
                }
                if (backingList[parent].CompareTo(backingList[smallestIndex]) <= 0)
                {
                    break;
                }
                var temp = backingList[parent];
                backingList[parent] = backingList[smallestIndex];
                backingList[smallestIndex] = temp;
                parent = smallestIndex;
                leftIndex = parent * 2 + 1;
                rightIndex = parent * 2 + 2;
            }
            return result;
        }
    }
}
