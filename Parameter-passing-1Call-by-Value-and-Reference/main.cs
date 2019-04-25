using System;

class MainClass {
  public static void Main (string[] args) {
    Action<object> print = Console.WriteLine; // 파라미터 = 퍼레미 라고도 한다.

    int a = 10;
    int b = 20;
    Swap(ref a, ref b);
    print(a == 20 && b == 10);

    Point pointA = new Point(10, 20);
    Point pointB = new Point(30, 40);
    Swap(pointA, pointB); // 함수 오버로딩 해당하는 함수가 없을 경우 나옴
    print(pointA.x == 30);

    //int sum = 0;
    //Sum(10, 20, ref sum); // 
    //print(sum == 30);

    int sum;
    Sum(10, 20, out sum); // out == ref 같지만, 차이점 out은 말 그대로 out의 용도로만 값을 담아서 보내야되는데 안 보내면 안된다, ref은 input 용으로 넘기는 데이터가 필요.
    print(sum == 30);
  }

 // public static void Sum(int a, int b, ref int sum){ // must be assigned //무조건 해야된다.
 //   sum = a + b;
 // }

  public static void Sum(int a, int b, out int sum){
    sum = a + b;
  }
  //The out parameter `sum' must be assigned to before control leaves the current method

  public static void Swap(ref int a, ref int b){ // main 함수와 다른 세상 컴파일 하고 나면 날라간다. 그런데 이 안에 내용은 변경되었지만, 메인은 변경되지 않았다. ref 주소를 넘겨 주는 것! 
    int temp = a;
    a = b;
    b = temp;
  }

    public static void Swap(Point a, Point b){ // 래퍼런스 타입이라 주소값을 받아온다.
    int x = a.x;
    int y = a.y;
    a.x = b.x;
    a.y = b.y;
    b.x = x;
    b.y = y;
  }

  public class Point{
    public int x, y;
    public Point(int _x, int _y){
      x = _x;
      y = _y;

  }

   public override bool Equals(object obj) // override 위에 있는 정의를 무시하고 내 것으로 바꾼다.
    {
      Console.WriteLine("Equals");
       if(obj.GetType() != this.GetType())
       return false;
       Point other = (Point) obj;
       return (this.x == other.x) && (this.y == other.y); 
    }
    public override int GetHashCode() // 지문 해쉬코드를 쓰는 이유 : 헤쉬 테이블 만들 때 주소를 정하기 위함?
    {
        return x ^ y;

    } 
  }
}




// Swap
// 1. double형 Swap(double a, double b)를 작성하세요.
// 2. int[]형 Swap(int[] arrayA, int[] arrayB)를 작성하세요, 배열 사이즈가 서로 다른 경우 호출자에게 알려주세요.
// 3. Book(멤버가 Title, Price)형 Swap(Book a, Book b)를 작성하세요.
// 4. 하나의 int[]를 주어졌을 때 min, max 값을 서로 SwapMinMax(int[] array)를 작성하세요.