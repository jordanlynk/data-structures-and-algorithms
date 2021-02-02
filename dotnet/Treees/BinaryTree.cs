using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treees
{
  public class BinaryTree<T>
  {
    public Node<T> Root { get; set; }
    public BinaryTree() { }
    public BinaryTree(T value)
    {
      Root = new Node<T>(value);
    }
    /// <summary>
    /// this is my method for preorder a tree by traversal
    /// </summary>
    /// <param name="currentNode"></param>
    /// <param name="nodeValues"></param>
    /// <returns></returns>
    public T[] PreOrder(Node<T> currentNode, List<T> nodeValues)
    {
      if(currentNode == null)
      {
        return nodeValues.ToArray();
      }
      nodeValues.Add(currentNode.Value);
      if (currentNode.Left != null) { PreOrder(currentNode.Left, nodeValues); }
      if (currentNode.Right != null) { PreOrder(currentNode.Right, nodeValues); }

      return nodeValues.ToArray();
    }

    public T[] InOrder(Node<T> currentNode, List<T> nodeValues)
    {
      if (currentNode == null) return nodeValues.ToArray();

      if (currentNode.Left != null) InOrder(currentNode.Left, nodeValues);
      nodeValues.Add(currentNode.Value);
      if (currentNode.Right != null) InOrder(currentNode.Right, nodeValues);

      return nodeValues.ToArray();
    }
  }
}
