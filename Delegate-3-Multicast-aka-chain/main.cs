using System;

delegate int Callback(int a, int b);

class MainClass {
  static int Sum(int i, int j) {
    Console.WriteLine("Sum");
    return i+j;
  }
    static int Multiply(int i, int j) {
    Console.WriteLine("Multiply");
    return i+j;
  }
    static int Power(int i, int j) {
    Console.WriteLine("Power");
    return (int) Math.Pow((double)i,(double)j); // i ** j
  }
  public static void Main (string[] args) {
    Action<object> print = Console.WriteLine;

    Callback cb;
    cb = Sum;
    //print(cb(1,2) == 3);

    cb += Multiply;
   // print(cb(3,2) == 6);
    cb += Power; // ++ 으로 연산되는 것들 다 소환.
   // print(cb(3,2) == 9);// 이렇게 쓰면 가장 마지막 값이 호출된다.

    cb -= Multiply; 
    print(cb(3,2) == 9);
  }
}

//Event 특별한 델리게이터