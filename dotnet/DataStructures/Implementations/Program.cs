using System;
using System.Collections.Generic;

namespace DataStructures
{
  public class Program
  {
    static void Main(string[] args)
    {
      LinkedList<int> myList = new LinkedList<int>(5);
      myList.Insert(3);
      myList.Insert(6);
      myList.Insert(9);
      myList.Insert(12);
      myList.Insert(18);
      myList.Insert(22);

      myList.toString();
      myList.RecursiveToString(myList.Head);
      LordRings();
    }

    static void LordRings()
    {
      Stack<string> myCharacters = new Stack<string>();
      myCharacters.Push("Galadriel");
      myCharacters.Push("Frodo");
      myCharacters.Push("Shadowfax");
      myCharacters.Push("Gandalf");

      while (myCharacters.Peek())
      {
        Node<String> character = myCharacters.Pop();
        Console.WriteLine(character.Value);
      }
    }
  }
}
