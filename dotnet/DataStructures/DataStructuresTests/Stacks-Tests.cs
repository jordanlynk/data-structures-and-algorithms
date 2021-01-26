using System;
using System.Text;
using Xunit;
using DataStructures;


namespace DataStructuresTests
{
  public class Stacks_Tests
  {

    [Fact]
    // This will test that we can succesfully push something into the stack 
    public void Test_That_Push_Happens_To_Stack()
    {
      Stack<int> testStack = new Stack<int>();
      testStack.Push(1);

      Assert.True(testStack.isEmpty());
    }
    // This will test that we can pass multiple values into the stack
    [Fact]
    public void Test_That_Pushes_Multiple_Values()
    {
      Stack<int> testStack = new Stack<int>();
      testStack.Push(1);
      testStack.Push(2);
      testStack.Push(3);

      Assert.NotNull(testStack.top.Next);

    }
    // This will test if something can pop off the stack
    [Fact]
    public void Can_Pop_Off_The_Stack()
    {
      Stack<int> testStack = new Stack<int>();
      testStack.Push(1);
      testStack.Pop();

      Assert.Null(testStack.top);

    }
    // This will test if we can successfully empty a stack after multiple pops
    [Fact]
    public void Successfully_Empty_After_Multiple_Pops()
    {
      Stack<int> testStack = new Stack<int>();
      testStack.Push(1);
      testStack.Push(2);
      testStack.Push(3);
      testStack.Pop();
      testStack.Pop();
      testStack.Pop();

      Assert.Null(testStack.top);
    }
    // this will test if we can successfully peek the next item on the stack
    [Fact]
    public void Successfully_Peek_Next_Item_On_Stack()
    {
      Stack<int> testStack = new Stack<int>();
      testStack.Push(1);
      testStack.Push(2);
      Node<int> result = testStack.Peek().Next;

      Assert.Equal(1, result.Value);
      
    }
    // this will test if we can successfully instantiate an empty stack
    [Fact]
    public void Successfully_Instantiate_An_Empty_Stack()
    {
      Stack<int> testStack = new Stack<int>();

      Assert.Null(testStack.top);
    }
    // this will test if calling pop or peek on empty stack raises exception
    [Fact]
    public void If_Pop_Or_Peek_Raises_Exception_On_Empty_Stack()
    {
      Stack<int> testStack = new Stack<int>();

      Assert.Null(testStack.Pop());
    }

  }
}
