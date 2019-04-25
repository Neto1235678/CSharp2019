using System;

class MainClass {
  static double divide(int x, int y) {
    return (int)(x/y);
  }
  public static void Main (string[] args) {
    Action<object> print = Console.WriteLine;

    Action act1 = () => print("Action"); // () void형태의 파라미터가 없는 함수 , Func의 마지막 값은 out 값(리턴)
    act1();

    Action<int> act2 = x => print(2 * x);
    act2(2);
    Action<double, double> act3 = (x, y) => print(x/y);
    act3(10, 20);

    Func<int> fn1 = () => 10; //Func 한개면 리턴 값을 따로 주지 않아도 된다. 한개가 리턴이다.
    print(fn1() == 10);

    Func<int, int, double> fn3 = divide;
    print( fn3(40, 20) == 2);

    Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int> fn13;
    fn13 = (a, b, c, d, e, f, g, h, i, j, k, l, m ) => a+b+c+d+e+f+g+h+i+j+k+l+m;
    print(fn13(1,1,1,1,1,1,1,1,1,1,1,1,1) == 13);
  }
}