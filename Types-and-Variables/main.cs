 using System;

class MainClass { 
  enum Animal{ MOUSE = -100, CAT, BIRD, DOG = 10, LION }; // 값이 있는 경우 그 값 부터 시작. 그 값에서 부터 값을 증가.
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
    // Value types:
    Console.WriteLine("\t\tValue typse:");
    int intA = 100;
    Console.WriteLine(intA == 100);
    Console.WriteLine(sizeof(int) == 4);
    byte byteA = 255;
    // byte byteA = 256; // error ! , 0 ~ 255
    Console.WriteLine(byteA == 255); // 
    Console.WriteLine(sizeof(byte) == 1);
    sbyte sbyteA = 127;
    //sbyte sbyteA = 128; // error ! , -127 ~ 127
    Console.WriteLine(byteA == 127); //
    Console.WriteLine(sizeof(sbyte) == 1);
    char charA = 'A';
    // 아스키코드 대문자 A  = 65 , \t  = 9
    Console.WriteLine(sizeof(char) == 2);
    Console.WriteLine(charA == 'A' && charA == 65);
    Console.WriteLine('\t' == 9);
    float floatA = 0.1f;
    Console.WriteLine(floatA != 0.1);
    Console.WriteLine(floatA == 0.1f);
    Console.WriteLine(sizeof(float) == 4);
    double doubleA = 0.1;
    Console.WriteLine(doubleA == 0.1);
    Console.WriteLine(0.1f > 0.1);
    Console.WriteLine((double)0.1f > 0.1); // 작은 녀석을 큰 녀석으로 바꾸는 건 가능, 반대는 X
    var someA = 0.1; // == double someA = 0.1 , 컴파일 하기 전에 실행
    Console.WriteLine(someA.GetType().ToString() ==  "System.Double"); // 배정도, double precision
    Console.WriteLine(floatA.GetType().ToString() ==  "System.Single"); // single precision
    Console.WriteLine(intA.GetType().ToString() == "System.Int32");
    Int32 int32 = 100;
    Console.WriteLine(byteA.GetType().ToString() == "System.Byte");
    Console.WriteLine(sbyteA.GetType().ToString() == "System.SByte");
    decimal decimalA = 1000000000000000000000.123m; // 변할 수 있는 것 m 
    Console.WriteLine(decimalA == 1000000000000000000000.123m);
    Console.WriteLine(sizeof(decimal) == 16);
    bool boolA = true;
    Console.WriteLine(boolA == true);
    Console.WriteLine(boolA != false);
    Console.WriteLine(sizeof(bool) == 1);

    //enum Animal{ MOUSE = -100, CAT, BIRD, DOG = 10, LION };
    Animal enumA = Animal.DOG; // enum은 특별한 인터져 , enum 안에 string 함수가 존재, 정한 값만 할당 받는다!
    Console.WriteLine(enumA); // DOG
    Console.WriteLine(enumA == Animal.DOG);
    Console.WriteLine((int)enumA == 10);
    Console.WriteLine((int)Animal.CAT == -99);
    Console.WriteLine((int)Animal.LION == 11);
    Console.WriteLine(enumA.GetType().ToString() == "MainClassAnimal");
    Console.WriteLine(sizeof(Animal) == 4);
    Console.WriteLine(enumA.GetType().IsValueType == true);

    // Reference types:
    // object
    // string
    // class C {...}
    // interface I {...}
    // int[] and int[,]
    // delegate int D(...)
    object obj1 = 10; // object 타입은 제일 위에 있어서 타입을 변환해서 넣는다. , boxing
    object obj2 = 10;
    int int3 = (int)obj1; // unboxing ! 장점 임의의 타입을 저장하는 변수가 생성 , 템플릿 형태로 사용 하는게 가장 좋다. 제넥터, 콜렉션 알고리즘 두 가지로 쓰인다.
    Console.WriteLine(int3 == 10);
    Console.WriteLine((obj1 == obj2) == false); // 포인터 방식이라서 다른 곳을 가르키고 있다. , 벨류 타입은 값 비교, 레퍼런스는 주소 비교
    Console.WriteLine(Object.ReferenceEquals(obj1, obj2) == false);
    Console.WriteLine(Object.Equals(obj1, obj2) == true); // 스테틱한 것
    Console.WriteLine(obj1.Equals(obj2) == true); // 스테틱하지 않은 것
    Console.WriteLine(obj1.GetType().IsValueType == true); // Why?

    string str1 = "Game";
    string str2 = "Game";
    string str3 = "Arademy";
    Console.WriteLine(str1 == str2); // C#은 끝에 C#붙이기
    Console.WriteLine(str1.GetType().IsValueType == false);
    object objStr = "Daegu";
    Console.WriteLine(objStr.GetType().IsValueType == false);

    Point pointA = new Point(10, 20);
    Point pointB = new Point(30, 40);
    Console.WriteLine( (pointA == pointB) == false);
    Point pointC;
    pointC = pointA;
    Console.WriteLine( pointA == pointC );
    Console.WriteLine(pointA.GetType().IsValueType == false);
    Console.WriteLine(Object.Equals(pointA, pointC) == true); // 비교값이 당연하면 비교X
    Console.WriteLine(Object.Equals(pointA, pointB) == false);
    Point pointD = new Point(10, 20);
    Console.WriteLine(Object.Equals(pointA, pointD) == true);
    Console.WriteLine(pointA.Equals(pointD));
    
    int[] arrayA = new int[2] {1, 2};
    int[] arrayB = new int[2] {
      1, 
      2
    };
    Console.WriteLine((arrayA == arrayB) == false);
    Console.WriteLine(arrayA.GetType().IsValueType == false);
    Console.WriteLine(Object.Equals(arrayA, arrayB) == false); // 단순 래퍼런스만 비교, Equals에 정의가 X 

  } // main

  class Point{
    public int x,y;
    public Point(int _x, int _y){
      x = _x; // 똑같은 이름일 때 this 사용
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