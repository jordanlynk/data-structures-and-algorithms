using System;
using System.Collections.Generic;
using System.Text;
using DataStructures;

namespace DataStructures
{
  public class Queue<T>
  {
    public Node<T> Front { get; set; }
    public Node<T> Rear { get; set; }

    // This method will take any value as an argument, adds a new node with that value to the back
    public void Enqueue(T value)
    {
      Node<T> newNode = new Node<T>(value);
      if (Front == null) { Front = newNode; Rear = newNode; }
      Rear.Next = newNode;
      Rear = newNode;
      
    }
    public Node<T> Dequeue()
    {
      Node<T> tempNode = Front.Next;
      Front = tempNode;
      return tempNode;

    }
    public Node<T> Peek()
    {
      if (Front == null) throw new NullReferenceException();
      return Front;
    }
    public bool isEmpty()
    {
      if (Front != null) return false;
      return true;
    }

  }
}
