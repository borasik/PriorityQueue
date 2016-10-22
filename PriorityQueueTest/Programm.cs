using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PriorityQueue;

namespace PriorityQueueTest
{
    [TestClass] 
    public class Programm
    {
        [TestMethod]
        public void TestHeapify()
        {
            var list = new List<int>() {300, 200};
            
            Heap.Heapfy(list);

            Assert.AreEqual(list.Count, 2);
            CollectionAssert.AreEqual(list, new List<int>() {200, 300});
        }

        [TestMethod]
        public void TestHeapifyIfListIsEmpty()
        {
            var list = new List<int>();

            Heap.Heapfy(list);

            Assert.AreEqual(list.Count, 0);
         
        }
        [TestMethod]
        public void TestHeapifyWithBounderyConditions()
        {
            var list = new List<int>() { 300, 200, -1, 5, -1 };

            Heap.Heapfy(list);

            Assert.AreEqual(list.Count, 5);
            CollectionAssert.AreEqual(list, new List<int>() { -1, -1, 5, 300, 200 });
        }
    }
}
