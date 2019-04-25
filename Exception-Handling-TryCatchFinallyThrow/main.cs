using System;


// class Calc {
//   public float Divide(int x, int y) {
//     float z = 0;
//     try {
//     z = x / y;
//     return z;
//     } catch(Exception e) {
//       Console.WriteLine(e.Message);
//     } finally {
//       Console.WriteLine("finally"); // 무조건되는 것 하지만 단독으로 뜨는건 안된다.
//     }

//     return 0;
//   }
// }

// class MainClass {
//   public static void Main (string[] args) {
//     Calc c = new Calc();
//     Console.WriteLine(c.Divide(10,1) == 10);
//     Console.WriteLine(c.Divide(10,0) == 0);
//   }
// }






class Calc {
  public float Divide(int x, int y) {
    float z = 0;
    try {
    z = x / y;
    return z;
    } catch(Exception e) {
      Console.WriteLine("Divide():" + e.Message);
      throw e; // 자기를 부른 이전함수에게 권한을 넘긴다. 여기서 브레이크 걸어서 처리하는게 좋다.

    } finally {
      Console.WriteLine("finally"); // 무조건되는 것 하지만 단독으로 뜨는건 안된다.
    }

    return 0;
  }
}

class MainClass {
  public static void Main (string[] args) {
    Calc c = new Calc();
    // Console.WriteLine(c.Divide(10,1) == 10);
    try {
    Console.WriteLine(c.Divide(10,0) == 0);
    }catch(Exception e) {
      Console.WriteLine("Main():" + e.Message);
    }
  }
}