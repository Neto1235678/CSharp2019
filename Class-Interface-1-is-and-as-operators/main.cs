using System;
using System.Collections.Generic;


// public static class ClassExtension{
//   public static string Stringify<T>(this IEnumerable<T> list){ // Stringify을 누구에게 넣나는 것 this , IEnumerable<T>(열거가능 한 것들) 사용 할려면 using System.Collections.Generic 사용 , Generic 하다는 것은 <T> 템플릿 하는 것.
//     return String.Join(" ", list);
//   }
// }  

interface IEquatable { //albe ~ 가능하냐
  bool Equals(Car obj); // public + abstarct 안에 든 애는 구체적이지 않다. Equals는 무조건 public 
}

interface ICloneable {
  Car Clone();
}

interface IEStringify {
  string Stringify();
}


// ICompareable.CompareTo() 누가 빨리오냐
class Car : IEquatable, ICloneable, IEStringify, ICompareable { // 이런 식으로 여러개의 interface 를 가질 수 있다.  interface = 약속
  public string Make { get; set; }
  public string Model { get; set; }
  public string Year { get; set; }

  public bool Equals(Car other) { // Equals 같냐
    if (this.Make == other.Make && this.Model == other.Model && this.Year == other.Year)
    return true;
    else
    return false;
  }


  public Car Clone() {
    Car car = new Car();
    car.Make = Make;
    car.Model = Model;
    car.Year = Year;
    return car;
  }

  public string Stringify() {

    
    return $"{Make}, {Model}, {Year}"; // "${}" ToString()으로 자동 전환.
  }

  public int CompareTo(object obj) {
    return this.Year.CompareTo((obj as Car).Year); // 정방향
    //return (obj as Car).Year.CompareTo(this.Year); 역순 , overloading 함수 타입 또는 파라미터가 다르다 그 외에는 같다.
  }

  public override string ToString(){
  return Make+Year;
  }
}


class MainClass {
  public static void Main (string[] args) {
    Action<object> print = Console.WriteLine;

    Car car = new Car();
    car.Make = "BMW";
    car.Model = "Mini";
    car.Year = "2018";
    
    Car car2 = new Car();
    car2.Make = "BMW";
    car2.Model = "Mini";
    car2.Year = "2017";

    Car car3 = new Car();
    car3.Make = "Volvo";
    car3.Model = "X";
    car3.Year = "2012";

    print(car.Equals(car2) == false);
    Car clone = car.Clone();
    print(clone.Equals(car) == true);
    clone.Make = "Tesla";
    print(car.Make == "BMW");
    print(clone.Make == "Tesla");
    print(car.Stringify());

    //print();

    //pirnt(Car(car) == car2);
    // print(car is int == false);
    // print(car is Cake == false);
    print(car is Car == true);
    print(car is IEquatable == true);
    print(car is ICloneable == true); // is = ~ 따르고 있나
    print(car is object);

    ICloneable ic = car as ICloneable;
    print( ic != null);
    print(ic.GetType().Name == "Car");

    ICompareable[] cars = {car, car2, car3};
    Array.Sort(cars);
    print(cars.Stringify() == "Volvo2012 BMW2017 BMW2018");
  }
}
