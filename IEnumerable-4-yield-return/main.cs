using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    Action<object> print = Console.WriteLine;


    foreach(int n in OddNumbers())
      print(n);

    print("\n");
    IEnumerator<int> enumeraotr = OddNumbers().GetEnumerator();
    while(enumeraotr.MoveNext())
      print(enumeraotr.Current); 

  }


  public static IEnumerable<int> OddNumbers() { //Async Function 특징 : 동시성
    yield return 1; // Tree를 선형화 하지 않고 사용가능하다.
    yield return 3; 
    yield return 5; // 내부적으로 컴파일러가 IEnumerable하게 처리해준다.

  }
}