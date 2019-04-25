using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    Action<object> print = Console.WriteLine;

    int[] array = { 1, 2, 3};
    print( array.Stringify() == "1 2 3"); // 클래스 확장

    print( "abc".Stringify() == "a b c");

    print((new char[] {'a', 'b', 'c'}).Stringify() == "a b c");

    List<int> list2 = new List<int>() {8, 3, 2}; // 콜렉션에서 사용 
    print(list2.Stringify() == "8 3 2");

    print((new int[] { 1 }.Stringify() == "1"));
  }
}

public static class ClassExtension{
  public static string Stringify<T>(this IEnumerable<T> list){ // Stringify을 누구에게 넣나는 것 this , IEnumerable<T>(열거가능 한 것들) 사용 할려면 using System.Collections.Generic 사용 , Generic 하다는 것은 <T> 템플릿 하는 것.
    return String.Join(" ", list);
  }

//  public static string Stringify(this string list){ 
//    return String.Join(" ", list);    
//  }
//
//  public static string Stringify(this char[] list){ 
//   return String.Join(" ", list);    
//  }
}