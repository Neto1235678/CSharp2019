using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    Action<object> print = Console.WriteLine;

    Stack s = new Stack(3);
    print(s.stringify() == String.Empty);
    //print(s.Count == 0);
    s.Push(10);
    //print(s.Count == 1);
    s.Push(20);
    s.Push(30);
    //print(s.Count == 3);
    print(s.stringify() == "10 20 30");
    print(s.Push(40) == false);
    print(s.stringify() == "10 20 30");
    //print(s.Count == 3); 

    object v;
    print(s.Pop(out v) == true);
    print((int)v == 30);
    print(s.Pop(out v) == true);
    print((int)v == 20);
    print(s.Pop(out v) == true);
    print((int)v == 10);
    print(s.Pop(out v) == false);
    print(s.stringify() == String.Empty);
    print(s.Count == 0);
    //s.Count == 100; // error!
    // 템플릿 프로그램 제네릭 프로그램

    Stack s1 = new Stack(5);
    s1.Push("Hi");
    s1.Push("There");
    s1.Push("How");
    s1.Push("About");
    s1.Push(100);
    print(s1.stringify() == "Hi There How About 100");
    print(s1.Pop(out v) == true);
    print((int)v == 100);
  }
}

public class Stack{
  object[] data;
  int size;
  int top = -1;

  // property : 속성
  public int Count{ // get 읽기, set 쓰기 
    get{
      return top+1;
    }
  }

  public Stack(int size){
      data = new object[size];
      this.size = size;
  }
  public bool Push(object value){
    if(top == size -1)
    return false;
    data[++top] = value;
    return true;
  }

  public bool Pop(out object v){
    if(top == -1){
      v = null;
      return false;
    }
    v = data[top--];
    return true;
  }

  public string stringify(){
    object[] list = new object[top+1];
    Array.Copy(data, list, top+1);
    return list.Stringify();
  }
}

public static class ClassExtension{
  public static string Stringify<T>(this IEnumerable<T> list){
    return String.Join(" ", list);
  }
}

// 기사 class 함수를 정의 해보자. 추상화로
// Bubble sort 짜오기 