using System;
using System.Collections;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    Action<object> print = Console.WriteLine;

    // var list1 = new List<object>();
    // var list2 = new List<Customer>();
    // var list3 = new List<int>();

    // var list = new List<int>();
    // print(list.String() == 0);
    var list = new List<int>() {8, 3, 2};
    print(list.Stringify() == "8 3 2");

    var listA = new List<int>() {8, 3, 2};
    var listB = new List<int>(listA);
    print(listB.Stringify() == "8 3 2");

    //var list = new List<int>(16);

    //List[index]
    int item = list[1];
    print(list.Stringify() == "3");

    list[1] = 4;
    print(list.Stringify() == "8 4 2");

    list.Add(5);
    print(list.Stringify() == "8 3 2 5");

    listA.AddRange(listB);
    print(list.Stringify() == "8 3 2 5 7");
    
    


    
  }
}

public static class ClassExtension {
  public static string Stringify<T>(this IEnumerable<T> list) {
    return String.Join(" ", list);
  }
}