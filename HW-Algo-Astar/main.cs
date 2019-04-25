using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
      Action<object> print = Console.WriteLine;

    int[][] image = new int[][] {
      new int[] {0, 0, 0, 0, 0, 0, 0},
      new int[] {0, 0, 0, 0, 0, 0, 0},
      new int[] {0, 0, 0, 0, 0, 0, 0},
      new int[] {0, 0, 0, 0, 0, 0, 0},
      new int[] {0, 0, 0, 0, 0, 0, 0},
      new int[] {0, 0, 0, 0, 0, 0, 0},
      new int[] {0, 0, 0, 0, 0, 0, 0}
    };

    Astar(image, 1, 3, 5, 2, 1);
    print( image[0].Stringify());
    print( image[1].Stringify());
    print( image[2].Stringify());
    print( image[3].Stringify());
    print( image[4].Stringify());
    print( image[5].Stringify());
    print( image[6].Stringify()); 
  }
// BLF 다 훝어본다.
//  1. 시작 지점과 도착 지점을 지정한다. 
//  2. 시작 지점에서 앞,뒤,좌,우를 체크하여 도착 지점까지 이동한다.
//  * 이동 시 고려사항 : (1) 맵 크기를 벗어나는 지 확인하여 맵을 벗어나지 못하게한다.
//                      (2) 장애물이 있는 지 체크한다. 만약, 장애물이 있다면 이동을 못하는 타일이다.
//                      (3) 장애물이 제외한 도착지점과 가장 가까운 타일로 이동.
//  3. 타일로 이동하면 이동 값을 1증가 시킨다.(최단 거리로 얼마나 걸리는지 체크)
//  4. 이동을 했으면, 이동한 위치에서 2.부터 다시 체크한다.
//  5. 지정한 곳에 도착 시 이동을 중지한다.(야드 사용 하면될 것 같은데))

  public static void Astar(int[][] image, int StartX, int StartY, int ExitX, int ExitY, int replacecolor) {
    int width = image[0].Length;
    int height = image.Length;

    if(!(0 <= StartX && StartX < width)) 
      return;
    if(!(0 <= StartY && StartY < height)) 
      return;  

    int StartColor = image[StartY][StartX];
    int ExitPoint = image[ExitY][ExitX];
    Queue<Pos> q = new Queue<Pos>();
    q.Enqueue(new Pos(StartY, StartX));

      while(q.Count > 0) {
      Pos pos = q.Dequeue();
      int x = pos.X;
      int y = pos.Y;

      if(image[x][y] == StartColor) {
        image[x][y] = replacecolor;

      if(x-1 >= 0 && image[x-1][y] == StartColor && image[x-1][y] == ExitPoint)
          q.Enqueue(new Pos(x-1,y));
          
      else if(y+1 < width && image[x][y+1] == StartColor && image[x][y+1] < ExitPoint)
          q.Enqueue(new Pos(x,y+1));

      else if(x+1 < height && image[x+1][y] == StartColor && image[x+1][y] != ExitPoint)
          q.Enqueue(new Pos(x+1,y));

      else if(y-1 >= 0  && image[x][y-1] == StartColor && image[x][y-1] > ExitPoint)
          q.Enqueue(new Pos(x,y-1));

      else  
            break;
      
      }
    }
  }
}

  class Pos {
    public int X { get; set; }
    public int Y { get; set; }
    public Pos(int x, int y) { X = x; Y = y;}
  }

  

  public static class ClassExtension{
  public static string Stringify<T>(this IEnumerable<T> list){
    return String.Join(" ", list);
  }
}