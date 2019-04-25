  using System;

class MainClass {
  public static void Main (string[] args) {
    Action<object> print = Console.WriteLine;

    print(Plus(10,10) == 20);

    MainClass mc = new MainClass();
    print(mc.Plus2(10,10) == 20);

    int[] scores = new int[] { 2, 4, 5, 3, 6, 8, 1, 7};
    print(Sum(scores) == 36);
    print(Avg(scores) == 4.5);
    //print(Min(scores) == 1);
    //print(Max(scores) == 8);

    // Array 2D
    int[,] list2d = {
        {10, 20},
        {30, 40},
        {50, 60}
        
    };
    print(list2d[2,0] == 50);

    // Array 3D
    int[,,] list3d = { // 3차원은 2차원이 여러개가 있는 것?
      {
      {10, 20},
      {30, 40},
      {50, 60}
      },
      {
      {70, 80},
      {90, 100},
      {110, 120}
      }
    };
    int sum = 0;
    for (int i =0; i < list3d.GetLength(0); i++){
      for (int j = 0; j < list3d.GetLength(1); j++){
        for(int k = 0; k < list3d.GetLength(2); k++){
          sum += list3d[i,j,k];
        }
      }
    }
    print(sum == 10+20+30+40+50+60+70+80+90+100+110+120);

    // Jagged Array(aka 가변배열) // 이렇게 알려진 jagged 들쑥 날쑥한
    int[][] image = new int[][]{
      new int[] {0, 0, 0, 0, 0, 0, 0},
      new int[] {0, 0, 1, 1, 1, 0, 0},
      new int[] {0, 0, 1, 0, 1, 0, 0},
      new int[] {0, 0, 1, 0, 1, 0, 0},
      new int[] {0, 0, 1, 0, 1, 0, 0},
      new int[] {0, 0, 1, 1, 1, 0, 0},
      new int[] {0, 0, 0, 0, 0, 0, 0}
    };
    print(image[1][2] == 1);
  }

 // public static int Max(int[] list)


 // public static int Min(int[] list)


  public static double Avg(int[] list)
  {
    return Sum(list) / (double)list.Length; // Length 개수 int / int 나누면 부동 소수점이 날리간다.ㅂ
  }

  public static int Sum(int[] list) // 어레이는 레퍼런스 타입. 래퍼런스 카운터가 2개다.
  {
    int s = 0; // 합을 담을 변수 0으로 초기화
    //for(int i = 0; i < list.Length; i++)
    //s += list[i]
    foreach(int n in list)
      s += n;
    return s;
  }

  public static int Plus(int a, int b) 
  {
    return a+b;
  }
  public int Plus2(int a, int b) // static이 존재해야지 메인 함수에서 따로 안 만들어도 된다.
  {
    return a+b;
  }
} // 열거형으로 만들어 보기. 익스텐션으로