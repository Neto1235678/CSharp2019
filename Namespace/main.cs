using System;
using static System.Math;
using static System.Console;  // only static member!
using Project = Outer.A.Car;  // alising 별칭을 준 것

class MainClass {
  public static void Main (string[] args) {
    Action<object> print = Console.WriteLine;

    print("test");
    print(PI); //Math.PI;
    WriteLine(PI); //Console안에 있는 스테틱한 멤버

    Outer.A.Car a = new Outer.A.Car();
    var a2 = new Outer.A.Car();
    WriteLine(a.name == "Car in namespace A");

    Project a3 = new Outer.A.Car();
    var a4 = new Project();

    var b = new Outer.B.Car();
    WriteLine( b.name != a.name );
  }
}

namespace Outer {
  namespace A {
    class Car {
      public string name = "Car in namespace A";
    }
  }
  namespace B {
    class Car {
      public string name = "Car in namespace B";
    }
  }
}