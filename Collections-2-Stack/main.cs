using System;
using System.Collections;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    Action<object> print = Console.WriteLine;

    Stack stack = new Stack();
    stack.Push(100);
    stack.Push(200);
    stack.Push(300);
    stack.Push(400);
    stack.Push(500);
    print(stack.Count == 5); // 인터페이스 똑같다 == 프로그래밍에서는 규약을 따르고 있다.
    print((int)stack.Peek() == 500); // 위에가 뭐가 들었는지 확인 할 때 사용
    print(stack.ToArray().Stringify() == "500 400 300 200 100");

    while(stack.Count > 0)
      print(stack.Pop());
    print(stack.Count == 0);
  }
}

public static class ClassExtension {
  public static string Stringify<T>(this IEnumerable<T> list) {
    return String.Join(" ", list);
  }
}