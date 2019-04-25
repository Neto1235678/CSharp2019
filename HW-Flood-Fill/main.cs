using System;

class MainClass {
  public static void Main (string[] args) {

    Action<object> print = Console.WriteLine;

    int[][] image = new int[][]
    {
      new int[] {0, 0, 0, 0, 0, 0, 0, 0},
      new int[] {0, 0, 0, 0, 0, 0, 0, 0},
      new int[] {0, 0, 1, 1, 1, 0, 0, 0},
      new int[] {0, 0, 1, 0, 1, 0, 0, 0},
      new int[] {0, 0, 1, 0, 1, 0, 0, 0},
      new int[] {0, 0, 1, 1, 1, 0, 0, 0},
      new int[] {0, 0, 0, 0, 0, 0, 0, 0},
      new int[] {0, 0, 0, 0, 0, 0, 0, 0},

      new int[] {0, 0, 0, 0, 0, 0, 0, 0},
      new int[] {0, 0, 0, 0, 0, 0, 0, 0},
      new int[] {0, 0, 7, 7, 7, 0, 0, 0},
      new int[] {0, 0, 7, 0, 7, 0, 0, 0},
      new int[] {0, 0, 7, 0, 7, 0, 0, 0},
      new int[] {0, 0, 7, 7, 7, 0, 0, 0},
      new int[] {0, 0, 0, 0, 0, 0, 0, 0},
      new int[] {0, 0, 0, 0, 0, 0, 0, 0},

      new int[] {0, 0, 0, 0, 0, 0, 0, 0},
      new int[] {0, 0, 0, 0, 0, 0, 0, 0},
      new int[] {0, 0, 7, 7, 7, 0, 0, 0},
      new int[] {0, 0, 7, 7, 7, 0, 0, 0},
      new int[] {0, 0, 7, 7, 7, 0, 0, 0},
      new int[] {0, 0, 7, 7, 7, 0, 0, 0},
      new int[] {0, 0, 0, 0, 0, 0, 0, 0},
      new int[] {0, 0, 0, 0, 0, 0, 0, 0}
    };

    print(image)    
  }
}

// i의 네 방향만 보기 i가 초기 값이라면 Q만들기, 실제 동작은 BLF로 동작.
// 