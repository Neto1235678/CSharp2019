using System;

class MainClass {
  public static void Main (string[] args) {
    Action<object> print = Console.WriteLine; // 유닛벡터 길이가 1인 벡터

    print(Vector3.forword.magntiude == 1f); // (0, 0, 1) => 1
    //v.magntiude = 0; // error!
    print((-Vector3.one).ToString() == "-1,-1,-1");

    print((Vector3.right + Vector3.zero).ToString() == "1,0,0");

    Vector3 a = new Vector3(2f, 2f, 0f);
    Vector3 b = new Vector3(2f, 0f, 0f);
    print( Vector3.Distance(a, b) == 2f);

    print((2f*a).ToString() == "4,4,0");
    print((a*2f).ToString() == "4,4,0");

    print( b.normalized.ToString() == "1,0,0");
    print( (3f*b).normalized.ToString() == "1,0,0"); // normalized 정규화

    print( Vector3.Angle(Vector3.right, Vector3.up) == 90);
    print( Vector3.Angle(a, Vector3.right) == 45);
    print( Vector3.Angle(Vector3.right, a) == 45);
    print( Vector3.Angle(Vector3.right, Vector3.left) == 180);
    print( Vector3.Angle(Vector3.right,Vector3.right) == 0);
    print( Vector3.Angle(Vector3.right,Vector3.dowm) == 90);

    print( Vector3.Dot(Vectro3.right, Vector3.right) == 1);
    print( Vector3.Dot(Vectro3.right, Vector3.up) == 0);
    print( Vector3.Dot(Vectro3.right, Vector3.left) == -1);
  }

  public class Mathf {
    public static double Rad2Deg = 360 / (2 * Math.PI);
    public static double Deg2Rad = (2 * Math.PI * d) / 360;
  }

  public class Vector3 {
    public static readonly Vector3 zero = new Vector3(0f, 0f, 0f); // 스테틱하다? 재기적이다. readonly == 상수 클래스 내부에서 쓰는 상수
    public static readonly Vector3 one = new Vector3(1f, 1f, 1f);
    public static readonly Vector3 forword = new Vector3(0f, 0f, 1f);
    public static readonly Vector3 back = -forword;
    public static readonly Vector3 right = new Vector3(1f, 0f, 0f);
    public static readonly Vector3 left = -right;
    public static readonly Vector3 up = new Vector3(0f, 1f, 0f);
    public static readonly Vector3 dowm = -up;

    public float x { get; set; }
    public float y { get; set; }
    public float z { get; set; }



    public Vector3(float _x, float _y, float _z) {
      x = _x; y = _y; z = _z;
    }

    public override string ToString() {
      return $"{x},{y},{z}";
    }


    // public static float Cosine(Vector3 a, Vector3 b, Vector3 c) {
    //   int cosine = z;
    //   return c = Math.Sqrt(a) - (a * a) + (b * b) + cosine(z) + Math.Sqrt(b);
    // }


    
    public float magntiude { //크게하다
      get { return Math.Abs((float)Math.Sqrt(x*x + y*y + z*z)); } //Abs 절대값 Sqrt 루트처리
    }

    public Vector3 normalized {
      get { return this * (1 / this.magntiude); }
    }

    public static float ScalarProduct(Vector3 a, Vector3 b) {
      return(a.x * b.x + a.y * b.y + a.z * b.z);
    }

    public static float Distance(Vector3 a, Vector3 b) {
      return(a-b).magntiude;
    }

    public static float Angle(Vector3 a, Vector3 b) {
      Vector3 na = a.normalized;
      Vector3 nb = b.normalized;
      return (float)(Math.Acos(Dot(a, b)) * Mathf.Rad2Deg);
    } // ACOS 으로 곱하면 양쪽 수식이 같아서 한쪽 수식이 날라간다 그러므로 ACOS(V1 * V2) = A;
    // raidan 360 : 2*pi = d : r, 2 * pi * d = 360, d = r * (360 / (2 * pi))
    public static Vector3 operator-(Vector3 a, Vector3 b) {
      return (a + -b);
    }

    public static Vector3 operator+(Vector3 a, Vector3 b) {
      return new Vector3(a.x + b.x, a.y + b.y, a.z + b.y);
    }

    public static Vector3 operator-(Vector3 a) {
      return new Vector3(-a.x, -a.y, -a.z);
    }

    public static Vector3 operator*(Vector3 a, float d) {
      return new Vector3(d*a.x, d*a.y, d*a.z);
    }

    public static Vector3 operator*(float d, Vector3 a) {
      return a*d;
    }

    public static float Dot(Vector3 d, Vector3 a) {
      return a.x * b.x + a.y * b.y + a.z * b.z;
    }

    // public static Vector3 operator*(Vector3 a, Vector3 b) {
    //   return new Vector3(a.x * b.x, a.y * b.y, a.z * b.y);
    // }
    // 카메라 앵글 구하는 것 내적연산. 코사인. 등..
    // 곱하기 연산도 구해보기. 두 벡터 사이의 간격 구하기.
  }
}