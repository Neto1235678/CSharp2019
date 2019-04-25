using System;

class MainClass {
  public static void Main (string[] args) {
    Action<object> print = Console.WriteLine;
    // == void print(object obj);  

    // int, short : signed
    // uint, ushort : unsigend
  byte byteA = 255;
  byteA++;
  print(byteA == 0);
  byteA--;
  print(byteA == 255);

  int ix = 128;
  print(Convert.ToString(ix, 2) == "10000000"); // Convert.ToString(변수명, 바꿀 진법); 진법 바꾸는 코드
  sbyte sy = (sbyte)ix;
  print(sy == -128);  //"10000000" 작은 것에서 큰 캐스팅은 괜찮지만 반대는 이상하게 된다.
  print(Convert.ToString(sy, 2) == "1111111110000000"); // ToString에 sbyte가 없다.
  print(Convert.ToString((byte)sy, 2) == "10000000");


  float floatA = 0.9f;
  int intA = (int)floatA;
  print(intA == 0);
  float floatB = 1.1f;
  int intB = (int)floatB;
  print(intB == 1);

  print(12345.ToString() == "12345"); // ToString,겟 헤쉬, 이콜은 최상위 부모에게 있다. 외에 5개정도 더 있다. 
  print(int.Parse("12345") == 12345); // int.Pares("바꿀 내용");은 파일에 문자열을 숫자화 시키는것 parse = 해석하다.
  
  float a = 69.6875f;
  double b = (double)a;
  print(a == b);

  //enum 가짓수를 가장 인터져, var는 컨파일할 때 되기에 메인 함수 안에 사용!

  // https://www.h-schmidt.net/FloatConverter/IEEE754.html
  const float x = 4.2f; // const = 상수라고 정의 하는 함수. 컴 파일중에 상수로 다 처리한다. 무언가를 짤 때 x 변수안에 있는 숫자를 지키는데 사용 , x = 100f; error !
  double y = (double)x; // float 타입의 값은 정확하게 저장하지 않는다. , floatconverter
  print(y < 4.2);
  string strX = String.Format("{0:G9}", x); // 문자열로 포멧하고 싶을 때
  print( strX == "4.19999981" );
  print(String.Format("{0}", y) == "4.19999980926514");
  print(y == 4.2f); // 정밀도가 더 좋으면 같다고 해준다. 부동 소수점은 잠재적으로 에러를 가질 수 있다. float. double등 , == 보다 범위로 비교한다., 조심해서 사용 중요!!!

  print(4.19999980926514f == 4.2f);
  print(4.1999998f == 4.2f); // 0.7자리를 비교하여 검사한다.
  
  print((double)x * 10);
  int n = (int)(x * 10);
  print(n == 41); // int로 캐스팅하면 소수점 자리 다 날린다. not 42

  double d = 4.2;
  print((int)(d * 10) == 42);
  print(String.Format("{0:G9}", d));
  
  print(4.2 == 4.20000000000000001);
  print(4.2 == 4.2000000000000001);   // double이 ==에서 정밀도가 더 높다. 기본적으로 부동 소수점 표현 방법은 오류를 가지고 있다. 조심해야된다. 돈관련 쓴다면 double, 더 정확하게는 decimal
  
  print(DiscountedPrice1(100, 0.1f) == 89);
  print(DiscountedPrice2(100, 0.1) == 90);
  print(DiscountedPrice3(100, 0.1) == 90);
  }


  public static int DiscountedPrice1(int fullPrice, float discount)
  {
    return (int)(fullPrice * (1-discount));
  }

  public static int DiscountedPrice2(int fullPrice, double discount)
  {
    return (int)(fullPrice * (1-discount));
  }

   public static decimal DiscountedPrice3(int fullPrice, double discount)
  {
    return (decimal)(fullPrice * (1-discount));
  }
  // 값 형식은 스테틱, 참조는 힙에 저장 
}