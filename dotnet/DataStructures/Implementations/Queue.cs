using System;
using System.Collections.Generic;
using System.Text;
using DataStructures;

namespace DataStructures
{
  public class Queue<T>
  {
    public Node<T> front { get; set; }
    public Node<T> rear { get; set; }

    // This method will take any value as an argument, adds a new node with that value to the back
    public void Enqueue(T value)
    {
      Node<T> node = new Node<T>(value);
      Node<T> currentCounter = front;

      while (currentCounter.Next != null)
      {
        if (currentCounter.Next == null)
        {
          currentCounter.Next = node;
          node.Next = null;
        }
        currentCounter = currentCounter.Next;
      }
    }
    public T Dequeue()
    {
      try
      {
        front.Next = null;
        return front.Value;
      }
      catch (NullReferenceException nre)
      {
        throw nre;
      }

    }
    public T Peek()
    {
      try
      {
        return front.Value;
      }
      catch (NullReferenceException nre)
      {
        throw nre;
      }
    }
    public bool isEmpty()
    {
      return front != null;
    }

  }
}
