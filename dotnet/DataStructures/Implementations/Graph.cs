using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
  public class Vertex<T>
  {
    public T Value { get; set; }
    public Vertex(T value)
    {
      Value = value;
    }
  }
  class Edge<T>
  {
    public int Weight { get; set; }
    public Vertex<T> Vertex { get; set; }
  }
  class Graph<T>
  {
    public Dictionary<Vertex<T>, List<Edge<T>>> AdjacencyList { get; set; }
    private int _size = 0;

    public Graph()
    {
      AdjacencyList = new Dictionary<Vertex<T>, List<Edge<T>>>();
    }

    public Vertex<T> AddVertex(T value)
    {
      Vertex<T> node = new Vertex<T>(value);
      AdjacencyList.Add(node, new List<Edge<T>>());
      _size++;
      return node;
    }
    public void AddDirectedEdge(Vertex<T> a, Vertex<T> b)
    {
      AdjacencyList[a].Add(
        new Edge<T>
        {
          Weight = 0,
          Vertex = b,
        }
      );
    }

    public void AddUndirectedEdge(Vertex<T> a, Vertex<T> b)
    {
      AddDirectedEdge(a, b);
      AddDirectedEdge(b, a);
    }

    public List<Edge<T>> GetNeighbors(Vertex<T> node)
    {
      return AdjacencyList[node];
    }

    public void Print()
    {
      foreach (var item in AdjacencyList)
      {
        Console.WriteLine($"Vertex {item.Key.Value} => ");

        foreach (var edge in item.Value)
        {
          Console.WriteLine($"{edge.Vertex.Value} -> ");
        }
        Console.WriteLine("");
      }
    }
  }
}
