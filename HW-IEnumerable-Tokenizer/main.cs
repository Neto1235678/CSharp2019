using System;
using System.Collections;

class MainClass {
  public static void Main (string[] args) {
    
    Tokens tokens = new Tokens("This is a sample sentence.", new char[] {' ', '-'});
    foreach (string t in tokens)
      Console.WriteLine(t);
  }
}

public class Tokens : IEnumerable {
  string[] elements;

  public Tokens(string soruce, char[] delimiters) {
    elements = soruce.Split(delimiters);
  }

  public IEnumerable GetEnumerator() {
    // return elements.GetEnumerator(); // 제네릭 타입은 오브젝트를 무조건 넣어줘야된다. ※필수
    return new ToKenEnumerator(this);
  }

  class ToKenEnumerator : IEnumerator {
    Tokens t;
    int position = -1;
     public ToKenEnumerator(Tokens t) {
       this.t = t;
     }
     public bool MoveNext() {
       if(position < t.elements.Length-1){
         position++;
         return true;
       } else {
         return false;
       }
     }
     public object Current {
       get {
         return t.elements[position];
       }
     }

     public void Reset() {
       position -1;
     }
  }
}