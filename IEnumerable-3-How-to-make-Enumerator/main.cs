using System;
using System.Collections;
using System.Collections.Generic;

public class Person {
  public string Name { get; set; }
  public override string ToString() { return Name; }
}

public class People : IEnumerable<Person> {
  public List<Person> list { get; set; }
  
  // public IEnumerable<Person> GetEnumerator() { return list.GetEnumerator(); }
  public IEnumerable<Person> GetEnumerator() { return new PersonEnumerator(list); }
  IEnumerator IEnumerable.GetEnumerator() { return this.GetEnumerator(); }

  class PersonEnumerator : IEnumerator<Person> {
    int position = -1;
    List<Person> list;

    public PersonEnumerator(List<Person> list) {
      this.list = list;
    }

    public Person Current { // 현재 가르키고 있는 내용 넘기기
      get {
        return list[position];
      }
    }
    object IEnumerator.Current { // 박싱 언방식 때문에.
      get {
        return this.Current;
      }
    }
    public bool MoveNext() {
      if (position < list.Count-1 ) {
        position++;
        return true;
      } else 
      return false;
    }
    public void Reset() {
      position = -1;
    }
    public void Dispose() { }
  }
}

class MainClass {
  public static void Main (string[] args) {
    People people = new People();
    people.list = new List<Person>() {
      new Person() { Name="ctkim"},
      new Person() { Name="Steve"},
      new Person() { Name="Brown"},
      new Person() { Name="Won"},
      new Person() { Name="jj"}
    };

    foreach(var person in people)
    Console.WriteLine(person.Name);
  }
}

// 제네릭 버전 안해도 된다.

//Tokens f = new Tokens("This is a sample sentence. ", new char[] {' ', '-'});  , 스플릿함수 사용해서 쪼개진 스트링 어웨이에 대해서 이믈ㄹ이터
//foreach (string item in f)
// {
//   System.Console.WriteLine(item);
// }
// This
// is
// a
// sample
// sentence