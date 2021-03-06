using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
  public class LinkedList<T>
  {
    public Node<T> Head { get; set; }

    /// <summary>
    /// Plain, Empty Linked List
    /// Usage: LinkedLIst myLIst = new LinkedList();
    /// </summary>
    public LinkedList() { }

    /// <summary>
    /// Creates a linked list with a node, assigning Head
    /// Usage: LinkedList myList = new LinkedList(4);
    /// </summary>
    /// <param name="value"></param>
    public LinkedList(T value)
    {
      Node<T> node = new Node<T>(value);
      Head = node;
      
    }

    // METHODS

    public string toString()
    {
      string output = "";
      Node<T> current = Head;
      while (current != null)
      {
        Console.Write($"[{current.Value}] => ");
        output += $"[{current.Value}] => ";
        current = current.Next;
      }
      Console.WriteLine("NULL");
      output += "NULL";
      return output;
    }

    public string RecursiveToString(Node<T> node)
    {
      if (node == null)
      {
        Console.WriteLine("NULL");
        return "NULL";
      }

      Console.Write($"[{node.Value}] => ");
      RecursiveToString(node.Next);
      return node.Value.ToString();

    }

    public void Insert(T value)
    {
      // If we have a head ... do this
      // If not, make the node, and make it the head.
      Node<T> node = new Node<T>( value);
      node.Next = Head; // might be unnecessary if we don't have a head
      Head = node;
    }

    // We need to traverse the linked list and compare each value to each argument.
    // If node value = argument, return true. Otherwise, continue traverse until reaching null and return false.
   public static bool Includes(T value, LinkedList<T> myList)
    {
      Node<T> current = myList.Head;
      while (current != null)
      {
        if (current.Value.Equals(value))
        {
          return true;
        }
        current = current.Next;

      }
      return false;

    }
    // public void Append(int val)
    // {
      // Node Current = Head;
      // if (Current == null)
      // {
        // Node node = new Node(val);
        // node.Next = Head;
        // Head = node;
        // Current = Head;
      //}
        
    // }
  }
}
