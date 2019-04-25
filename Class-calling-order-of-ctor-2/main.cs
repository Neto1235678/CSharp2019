using System;

class MainClass {
  class Book{
   public string title;
    public Book(string title) {
      this.title = title;
      Console.WriteLine("Book ctor");
    }
  }

  class Nove1 : Book {
    public string writer;

    public Nove1(string title, string writer) : base(title) {
      this.writer = writer;
      Console.WriteLine("Novel ctor");
    }
  }

  class SFNove1 : Nove1 {
     public SFNove1(string title, string writer) : base(title, writer) {
      Console.WriteLine("SFNove1 ctor");
    } 
  }

  public static void Main (string[] args) {
    SFNove1 nov = new SFNove1("Hobbit", "Tolkien");
    Console.WriteLine(nov);


   
  }   
} 