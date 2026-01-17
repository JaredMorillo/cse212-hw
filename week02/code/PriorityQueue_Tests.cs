using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Basic enqueue and dequeue with distinct priorities 
    // Expected Result: Dequeue returns the highest priority item
    // Defect(s) Found: Previous test not implemented
    public void TestPriorityQueue_1()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("Alice", 1);
        pq.Enqueue("Bob", 2);
        pq.Enqueue("Charlie", 1);

        Assert.AreEqual("Bob", pq.Dequeue()); // Bob has highest priority 2
        Assert.AreEqual("Alice", pq.Dequeue());
        Assert.AreEqual("Charlie", pq.Dequeue()); 
    }

    [TestMethod]
    // Scenario: Dequeue respects FIFO when multiple items have same highest priority
    // Expected Result: First inserted item with highest priority is dequeued
    // Defect(s) Found: Previous test not implemented
    public void TestPriorityQueue_2()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("X", 10);
        pq.Enqueue("Y", 5);

        Assert.AreEqual("X", pq.Dequeue());
        Assert.AreEqual("Y", pq.Dequeue()); // Y has priority 5
    }

    // Add more test cases as needed below.
     [TestMethod]
    // Scenario: Dequeue on empty queue
    // Expected Result: Throws InvalidOperationException with correct message
    public void TestPriorityQueue_EmptyQueue()
    {
        var pq = new PriorityQueue();
        try
        {
            pq.Dequeue();
            Assert.Fail("Expected InvalidOperationException not thrown");
        }
        catch (InvalidOperationException ex)
        {
            Assert.AreEqual("The queue is empty.", ex.Message);
        }
    }

    [TestMethod]
    // Scenario: Multiple dequeues in correct order
    // Expected Result: Items are dequeued by priority then FIFO
    public void TestPriorityQueue_MultipleDequeues()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("Alice", 2);
        pq.Enqueue("Bob", 5);
        pq.Enqueue("Charlie", 5);
        pq.Enqueue("Dave", 1);

        Assert.AreEqual("Bob", pq.Dequeue());     // highest priority, first in
        Assert.AreEqual("Charlie", pq.Dequeue()); // next highest priority
        Assert.AreEqual("Alice", pq.Dequeue());   // next priority
        Assert.AreEqual("Dave", pq.Dequeue());    // last
    }
}
