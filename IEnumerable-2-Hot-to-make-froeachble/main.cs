using System;
// using System.Collections;
using System.Collections.Generic;

public class Person {
  public string Name { get; set; }
  public override string ToString() { return Name; }
}

public class People : IEnumerable<Person> {
  public List<Person> list { get; set; }
  
  public IEnumerable<Person> GetEnumerator() { return list.GetEnumerator(); }
  IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
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