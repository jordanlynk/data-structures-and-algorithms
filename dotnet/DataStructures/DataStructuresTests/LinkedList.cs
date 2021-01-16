using System;
using Xunit;

using DataStructures;

namespace DataStructureTests
{
  public class LinkListTests
  {
    [Fact]
    public void Linked_List_Created_With_A_Value_Has_Correct_Head()
    {
      int value = 2;

      LinkedList testList = new LinkedList(value);

      Assert.Equal(testList.Head.Value, value);

    }

    [Fact]
    public void After_Insert_New_Node_Is_Head()
    {
      LinkedList testList = new LinkedList(1);
      // H(2) -> (1)
      testList.Insert(2);

      Assert.Equal(2, testList.Head.Value);
    }

    [Fact]
    public void After_Insert_New_Head_Next_is_Old_Head()
    {
      // H(1)
      LinkedList testList = new LinkedList(1);
      Node oldHead = testList.Head;

      // H(2) -> (1)
      testList.Insert(2);

      Assert.Equal(oldHead, testList.Head.Next);

    }

    [Fact]
    // this test will check if include method works in finding a value
    public void Confirm_Include_Works_Value_Is_In_List()
    {
      LinkedList testList = new LinkedList();
      testList.Insert(2);
      testList.Insert(3);
      testList.Insert(4);
      testList.Insert(5);

      int testValue = 4;
      bool result = LinkedList.Includes(testValue, testList);
      Assert.True(result);
    }
    [Fact]
    public void Confirm_Include_Works_Value_Is_Not_In_List()
    {
      LinkedList testList = new LinkedList();
      testList.Insert(2);
      testList.Insert(3);
      testList.Insert(4);
      testList.Insert(5);

      int testValue = 20;
      bool result = LinkedList.Includes(testValue, testList);
      Assert.False(result);
    }

    [Fact] 

  }
}
