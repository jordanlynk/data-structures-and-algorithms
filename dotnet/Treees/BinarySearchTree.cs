using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treees
{
    public class BinarySearchTree
    {
      public Node<int> Root { get; set; }
      public BinarySearchTree() { }
      public BinarySearchTree(int value)
    {
      Root = new Node<int>(value);

    }
    public void Add(int value)
    {
      Node<int> newNode = new Node<int>(value);
      Node<int> currentNode = Root;

      if (currentNode.Value < newNode.Value && currentNode.Right == null) currentNode.Right = newNode;
      else if (currentNode.Value > newNode.Value && currentNode.Left == null) currentNode.Left = newNode;
      else
      {
        while (currentNode != null)
        {
          if (newNode.Value > currentNode.Value)
          {
            if (currentNode.Right == null) currentNode.Right = newNode;
            currentNode = currentNode.Right;
          }
          else if (newNode.Value < currentNode.Value)
          {
            if (currentNode.Left == null) currentNode.Left = newNode;
            currentNode = currentNode.Left;
          }
          else
          {
            currentNode = currentNode.Left;
          }
        }
      }
    }
    public bool Contains(int value)
    {
      bool doesContain = false;
      Node<int> currentNode = Root;
      while (currentNode != null)
      {
        if (value < currentNode.Value) currentNode = currentNode.Left;
        else if (value > currentNode.Value) currentNode = currentNode.Right;
        else
        {
          doesContain = true;
          break;
        }
      }
      return doesContain;
    }
  }
}
