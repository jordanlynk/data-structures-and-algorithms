using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treees
{
  public class BinaryTree<T> where T : IComparable
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
    public static List<int> PostOrderTraversal(Node<int> node, List<int> values)
    {
      if (node.Left != null) { PostOrderTraversal(node.Left, values); }
      if (node.Right != null) { PostOrderTraversal(node.Right, values); }
      values.Add(node.Value);
      return values;
    }

    public static List<T> BreadthTraversal(BinaryTree<T> tree)
    {
      
      List<T> values = new List<T>();

      Queue<Node<T>> nodes = new Queue<Node<T>>();

      nodes.Enqueue(tree.Root);

      while (nodes.Peek() != null)
      {
        Node<T> currentNode = nodes.Dequeue();
        

        values.Add(currentNode.Value);

        if ( currentNode.Left != null ) { nodes.Enqueue(currentNode.Left);  }
        if (currentNode.Right != null) { nodes.Enqueue(currentNode.Right); }
      }
      return values;
    }
  }
}
