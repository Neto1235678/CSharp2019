using System;

class MainClass {
  class Book {
    public string title;
    public string genre;

     public void Print() {
      Console.WriteLine($"{title}, {genre}"); 
    } 
  }

  class Nove1 : Book {
    public string writer;
    public void Print() {
      base.Print();
      Console.WriteLine($"{writer}"); 
    }
  }

  class Magazine : Book {
    public int releaseDay;   
    public void Print() {
      base.Print();
      Console.WriteLine($"{releaseDay}"); 
    }    
  }

  public static void Main (string[] args) {
    Nove1 nov = new Nove1();
    nov.title = "The Hobbit"; nov.genre = "Fantasy";
    nov.writer = "J.R.R Tolkien";
    nov.Print();
    //Console.WriteLine();

    Magazine mag = new Magazine();
    mag.title = "Hello Computer Magazine";
    mag.genre = "Computer";
    mag.releaseDay = 1;
    mag.Print();

    Book[] books = {nov, mag}; // 담기는 타입이 다르다. 상위 부모의 타입으로 하위 자식을을 담을 수 있다.
    foreach(var b in books) {
      b.Print(); // 담은 녀석(nov, mag)의 프린트가 콜된다. 1. 부모쪽으로 자동 캐스팅 2. 상위 것이 아닌 하위 것이 콜 된다.
      Console.WriteLine(); // 스테틱 바인딩, 버츄얼과 오버라이드 -> 다이널 바이징 실행시점에서 결정
    }                      // 연관성이 있는 상속일 경우 부모에게 virtual 자식들은 override(재정의)를 함수 만들 때 추가.
  }                        // override 내 것으로 재정의 하지만 base.함수()가 들어갈 경우 부모의 것을 쓰고 내것으로 재정의 한다.
}   // 여러개 다각형의 면적을 구하기. 면적 구한걸 array 담아서 스트링파인으로 테스트 파일과 비교하기
    // 삼각형, 사격형, 원형