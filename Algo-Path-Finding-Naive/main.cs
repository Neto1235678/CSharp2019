using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    Action<object> print = Console.WriteLine;

    int[] array = { 1, 12 };
    print(array.Stringify() == " 1 12");

    byte[][] grid = new byte[][] { // 1, 벽
      new byte[] {0, 0, 0, 0, 0, 0, 0},
      new byte[] {0, 0, 0, 0, 0, 0, 0},
      new byte[] {0, 0, 0, 0, 0, 0, 0},
      new byte[] {0, 0, 0, 0, 0, 0, 0},
      new byte[] {0, 0, 0, 0, 0, 0, 0},
      new byte[] {0, 0, 0, 0, 0, 0, 0},
      new byte[] {0, 0, 0, 0, 0, 0, 0},
      new byte[] {0, 0, 0, 0, 0, 0, 0}
    };

    NaiveSearch naive = new NaiveSearch(grid);
    naive.FindPath(new Node(3,3), new Node(6,6));
    print(naive.pathGrid[0].Stringify());
    print(naive.pathGrid[1].Stringify());
    print(naive.pathGrid[2].Stringify());
    print(naive.pathGrid[3].Stringify());
    print(naive.pathGrid[4].Stringify());
    print(naive.pathGrid[5].Stringify());
    print(naive.pathGrid[6].Stringify());
    
    print("\n");

    print(naive.costGrid[0].Stringify());
    print(naive.costGrid[1].Stringify());
    print(naive.costGrid[2].Stringify());
    print(naive.costGrid[3].Stringify());
    print(naive.costGrid[4].Stringify());
    print(naive.costGrid[5].Stringify());
    print(naive.costGrid[6].Stringify());

		
  }
}

public class NaiveSearch {
  byte[][] grid;
  public byte[][] pathGrid;
  public byte[][] costGrid;

  public NaiveSearch(byte[][] grid) {
    this.grid = grid;
    this.pathGrid = new byte[grid.Length][];
    for(int i = 0; i < grid.Length; i++)
      this.pathGrid[i] = new byte[grid[0].Length];

    this.costGrid = new byte[grid.Length][];
    for(int i = 0; i < grid.Length; i++)
      this.costGrid[i] = new byte[grid[0].Length];
  }

  public bool FindPath(Node start, Node goal) {
    Action<object> print = Console.WriteLine;
    // int count = 0;
    int width = grid[0].Length;
    int height = grid.Length;
    var openList = new Queue<Node>();
    var closeList = new List<Node>();

    openList.Enqueue(start);
    while(openList.Count > 0) {
      
      Node current = openList.Dequeue();
      closeList.Add(current);
      if (current.Equals(goal)) {
        print("Goal!!!");
        Node c = current;

        while(c.parent != null) {       
          pathGrid[c.X][c.Y] = 7;
          c = c.parent;
        }
        return true;
      } else {
        foreach(var n in Neighbors(current)) { // Neighbors: 이웃 돌면서 이웃을 알려달라 
          if(n.X < 0 || n.X >= height || n.Y < 0 || n.Y >= width ) 
            continue;
          if(closeList.Contains(n))                                 
            continue;
          if(openList.Contains(n))
            continue;
          if(grid[n.X][n.Y] == 1)     // Wall
            continue;

          costGrid[n.X][n.Y] = (byte)(costGrid[current.X][current.Y] + 1);  // cost(c, n) = 1;
          n.parent = current;
          openList.Enqueue(n);
        }
      }
    }
    
    return false;
  }

  public static IEnumerable<Node> Neighbors(Node c) { // 노드를 만드는 부분, 노드 안에 방문 했는 지 체크 가능.  이웃이 2번이 체크되니, 1번만 체크 되게 하기
    int x = c.X;
    int y = c.Y;
    
    yield return new Node(x-1, y); // 12시
    yield return new Node(x, y+1); // 3시
    yield return new Node(x+1, y); // 6시
    yield return new Node(x, y-1); // 9시
  }
}

public class Node : IEquatable<Node>{
  public int X { get; set; }
  public int Y { get; set; }
  // public int G { get; set; }
  public Node parent;
  public Node(int x, int y) {
    X = x; Y = y;
    parent = null;   
  }
  public bool Equals(Node other) {
    return X == other.X && Y == other.Y;
  }
}

public static class ClassExtension {
  public static string Stringify<T>(this IEnumerable<T> list) {
    string s = "";
    foreach(var v in list) {
      s += string.Format("{0,2}", v) + " ";
    }
    if(s.Length > 0) 
      s = s.Substring(0, s.Length-1); // 끝자리 한 개를 없애는 것.
    return s;
  }
}