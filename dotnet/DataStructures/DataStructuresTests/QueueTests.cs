using System;
using System.Text;
using Xunit;
using DataStructures;


namespace DataStructuresTests
{
  public class QueueTests
  {
    // this will test if we can successfully enqueue into a queue
    [Fact]
    public void Can_Test_Successfully_Enqueue_Into_Queue()
    {
      Queue<int> testQueue = new Queue<int>();
      testQueue.Enqueue(3);

      Assert.Equal(3, testQueue.Peek());
    }
  }
}
