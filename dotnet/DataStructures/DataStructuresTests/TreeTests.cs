using System;
using System.Collections.Generic;
using System.Text;
using Treees;
using Xunit;

namespace DataStructuresTests
{
  public class TreeTests
  {
    [Fact]
    public static void Finds_Values_In_Tree()
    {
      BinaryTree<int> bt = new BinaryTree<int>(3);

      bt.Root.Left = new Node<int>(7);
      bt.Root.Left.Left = new Node<int>(2);
      bt.Root.Left.Right = new Node<int>(6);
      bt.Root.Left.Right.Left = new Node<int>(5);
      bt.Root.Left.Right.Right = new Node<int>(11);

      bt.Root.Right = new Node<int>(5);
      bt.Root.Right.Right = new Node<int>(9);
      bt.Root.Right.Right.Left = new Node<int>(4);

      List<int> expectedList = new List<int> { 2, 7, 5, 2, 6, 9, 5, 11, 4 };

      Assert.Equal(expectedList, BinaryTree<int>.LevelOrderTraversal(bt));
    }
  }
}
