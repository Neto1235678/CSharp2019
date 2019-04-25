using System;

class MainClass {


  class Nove1 : Book {
    public Nove1() : base() {
      Console.WriteLine("Novel ctor");
    }
  }

  class SFNove1 : Book {
     public SFNove1() : base() {
      Console.WriteLine("SFNove1 ctor");
    } 
  }

  public static void Main (string[] args) {

    SFNove1 nov = new SFNove1();
    nov.title = "the Hobbit";
   
  }   

  class Book{
   public string title;
    public Book() {
      Console.WriteLine("Book ctor");
    }
  }
} 