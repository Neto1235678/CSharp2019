using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    Action<object> print = Console.WriteLine;
    var names = new List<string>() { "John", "Tom", "Peter"}; // 이런 타임은 var 쓰기 뒤에 넣는 값이 명확할 때 사용

    string s = "";
    foreach(var name in names) {
      s += name + " ";
    }
    print(s == "John Tom Peter ");


    s = "";
    var enumerator = names.GetEnumerator(); // List<stirng>.Enumerator
    while(enumerator.MoveNext()) { // MoveNext 다음께 있는 지 체크 없으면 false 리턴
      s += enumerator.Current + " "; // MoveNext가 있다면 Current에 값을 바꿔준다.
    }
    print(s == "John Tom Peter ");

    string nick = "Game"; // or stirn nick = new stirng(new char[] {'G','a','m','e'})
    s = "";
    var stringEnumerator = nick.GetEnumerator(); // CharEnumerator
    while(stringEnumerator.MoveNext()) { 
      s += stringEnumerator.Current; 
    }
    print(s == "Game");
  }
}