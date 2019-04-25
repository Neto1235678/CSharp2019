using System;

class MainClass {
  class Nove1 {
    public string title;
    public string genre;

    public string writer;
    public void Print() {
      Console.WriteLine($"{title}, {genre}, {writer}"); // 문자열 앞에 딸라 중괄호 안에는 변수명
    }
  }

  class Magazine {
    public string title;
    public string genre;

    public int releaseDay;   
    public void Print() {
      Console.WriteLine($"{title}, {genre}, {releaseDay}"); 
    } 
  }
  public static void Main (string[] args) {
    Nove1 nov = new Nove1();
    nov.title = "The Hobbit"; nov.genre = "Fantasy";
    nov.writer = "J.R.R Tolkien";
    nov.Print();
    Console.WriteLine();

    Magazine mag = new Magazine();
    mag.title = "Hello Computer Magazine";
    mag.genre = "Computer";
    mag.releaseDay = 1;
    mag.Print();
  }
}