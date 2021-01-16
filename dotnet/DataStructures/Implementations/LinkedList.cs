using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
  public class LinkedList
  {
    public Node Head { get; set; }

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
    public LinkedList(int value)
    {
      Node node = new Node(value);
      Head = node;
    }

    // METHODS

    public void Print()
    {
      Node current = Head;
      while (current != null)
      {
        Console.Write($"[{current.Value}] => ");
        current = current.Next;
      }

      Console.WriteLine("NULL");
    }

    public void PrintR(Node node)
    {
      if (node == null)
      {
        Console.WriteLine("NULL");
        return;
      }

      Console.Write($"[{node.Value}] => ");

      PrintR(node.Next);

    }

    public void Insert(int value)
    {
      // If we have a head ... do this
      // If not, make the node, and make it the head.
      Node node = new Node(value);
      node.Next = Head; // might be unnecessary if we don't have a head
      Head = node;
    }

    // We need to traverse the linked list and compare each value to each argument.
    // If node value = argument, return true. Otherwise, continue traverse until reaching null and return false.
    public bool Includes(int value, LinkedList myList)
    {
      Node current = myList.Head;
      while (current != null)
      {
        if (current.Value == value)
        {
          return true;
        }

      }
      return false;

    }
  }
}
