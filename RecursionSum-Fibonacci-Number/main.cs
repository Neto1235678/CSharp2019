using System;

class MainClass {
  public static void Main (string[] args) {
    Action<object> print = Console.WriteLine;

    print( SumIecursive(10) == 55);
    print( SumRecursive(10) == 55);

    // 0 1 2 3 4 5 6  7  8
    // 0 1 1 2 3 5 8 13 21 ... 피보나치의 수  
    print( FiboRecursive(7) == 13);
    print( FiboIterative(7) == 13);
  }


  public static int FiboRecursive(int n) // 극악의 알고리즘, 문제 해결 알고리즘 static을 쓰니 좋지는 않는 함수. 라이브 하게 사용 x
  {
    if (n < 2)
      return n;
    return FiboRecursive(n - 1) + FiboRecursive(n - 2);
  }

  public static int FiboIterative(int n){
    if(n < 2)
      return n;
    int fibo = 0, fibo1=0, fibo2=1;
    for(int i = 2; i <=n; i++){
      fibo = fibo1 + fibo2;
      fibo1 = fibo2;
      fibo2 = fibo;
    }
  }

  public static int SumIecursive(int n) // 보통 쓰는 방식
  {
    int sum = 0;
    for(int i = 0; i <= n; i++)
      sum += i;
    return sum;
  }

  public static int SumRecursive(int n) // Recursive 방식 특정 알고리즘에는 좋다. 바이럴 서치 등등에 
  {
    if (n < 2)
    {
      return n; 
    }
    return SumRecursive(n-1) + n; // 재기 호출, 방향 서치, 퀵 서치
  }


  // Recursive를 이용하여 문자열의 길이를 구하기, 최대값 구하기
  // 10
  //SumRecursive(10 -1) + 10
  //
}