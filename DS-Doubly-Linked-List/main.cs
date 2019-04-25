using System;

class MainClass {
  public static void Main (string[] args) {
   Action<object> print = Console.WriteLine;

  LinkedList list = new LinkedList();

  // AddLast
  list.AddLast("one");
  print(list.Stringify() == "one");
  list.AddLast("two");
  print(list.Stringify() == "two");
  list.AddLast("three");
  print(list.Stringify() == "onetwothree");

  // AddFirst
  list.AddFirst("one");
  print(list.Stringify() == "one");
  list.AddFirst("two");
  print(list.Stringify() == "two");
  list.AddFirst("three");
  print(list.Stringify() == "onetwothree");
    
  // RemoveLast
  print(list.RemoveLast() == "three");
  print(list.RemoveLast() == "onetwo");
  list.RemoveLast();
  print(list.RemoveLast() == "one");

  // RemoveFirst
  print(list.RemoveFirst() == "one");
  print(list.RemoveFirst() == "twothree");
  list.RemoveFirst();
  print(list.RemoveFirst() == "three");


  }
}

public class Node {
  public string data;
  public Node next;
  public Node prey;
}

public class LinkedList {
  Node head;
  Node tail;

  public LinekdList() {
    head = tail = null;
  }
}

public void AddLast(string obj) {
  Node newNode = new Node();
  newNode.data = obj;
  newNode.next = null;
  if(head == null) {
    head = tail = newNode;
  } else {
    tail.next = newNode;
    tail = newNode;
  }
}

public void AddFirst(string obj) {
  Node newNode = new Node();
  newNode.data = obj;
  newNode.prey = obj;

}

public string RemoveFirst() {

}

public string RemoveLast() {

}

public string Stringify() {
  
}

// Doubly Linekd list
// AddLast(). AddFirst(),
// RemoveFirst(). RemoveLast(). 
// ReverseStringify(), Node Search(str)