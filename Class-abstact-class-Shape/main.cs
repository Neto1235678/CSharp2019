using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    Shape[] shapes = {
      new Square(5, "Square #1"),
      new Circle(3, "Circle #1")
    };
    double[] areas = new double[shapes.Length];
    for(int i = 0; i < shapes.Length; i++) {
      areas[i] = shapes[i].Area;
    }
    Console.WriteLine(Stringify(areas) == "25 28.2743338823081");
  }

  // Shape s = new Shape("tri") // error! 추상화는 이렇게 사용하지 못한다.
    public static string Stringify(double[] list)
  {
    return String.Join(" ", list);
  }
}


public abstract class Shape {
  string name;
  public Shape(string s) {
    Id = s;

  }
  public string Id {
    get {
      return name;
    }
    set {
      name = value;
    }
  } 
  public abstract double Area {get; } // abstract 추상 여기서 구체적으로 못하겠다. 밑에서 상속받아서 구체적으로 해라 구체적으로 사용할 수없다. 클래스에 abstract 추가
  public override string ToString() {
    return $"{Id} Area = {Area}";
  }
}

public class Square : Shape {
  int side;
  public Square(int side, string id) : base(id) {
    this.side = side;
  }
  public override double Area {
    get {
      return  side * side;
    }
  }
}
  public class Circle : Shape {
    int radius;
    public Circle(int radius, string id) : base(id) {
      this.radius = radius;
    }

    public override double Area {
      get {
        return radius * radius * Math.PI;
      }
    }
}