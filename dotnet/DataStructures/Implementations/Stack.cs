using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
  public class Stack<T>
  {
    public Node<T> top { get; set; }

    public bool Peek()
    {
      return top != null;
    }

    public void Push(T value)
    {
      Node<T> node = new Node<T>(value);
      node.Next = top;
      top = node;
    }

    public Node<T> Pop()
    {
      // find the top of the stack
      Node<T> currentTop = top;
      // set the next node down to be the new top one
      top = currentTop.Next;
      // return what used to be on the top
      return currentTop;
    }

    public bool isEmpty()
    {

    }
  }
}
