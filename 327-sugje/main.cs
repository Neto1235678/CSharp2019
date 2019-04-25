using System;

class MainClass {
  class Polygon {

    public int length = 4;
    public int width = 5;
    //public int Pz;
    public virtual void Print() {
      Console.WriteLine($"{length}, {width}");
    }
  }

  class Triangle : Polygon {
    public int num;
    public override void Print() {
      Console.WriteLine($"{num}");
    }
  }

  class Rectangle : Polygon {
    public int rectnum;
    public override void Print() {
      Console.WriteLine($"{rectnum}");
    }

  }

  class Circle : Polygon {
    public double cirnum;
    public override void Print() {
      Console.WriteLine($"{cirnum}");
    }
  }

  public static void Main (string[] args) {
    //Action<object> print = Console.WriteLine;

    Triangle tri = new Triangle();
    tri.num = (tri.length * tri.width) / 2;
    tri.Print();

    Rectangle rect = new Rectangle();
    rect.rectnum = rect.length * rect.width;
    rect.Print();
    
    Circle cir = new Circle();
    cir.cirnum = 3.14 * (Math.Sqrt(cir.length / 2));
    cir.Print();


  }
}