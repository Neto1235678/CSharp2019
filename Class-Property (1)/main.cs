using System;

class MainClass {
  public static void Main (string[] args) { // Property 속성, 재산
    Action<object> print = Console.WriteLine;
      Book b = new Book();
      b.SetTitle("LOR");
      print(b.GetTitle() == "LOR");

      Book2 b2 = new Book2();
      b2.Title = "Hobbit";
      print(b2.Title == "Hobbit");
      b2.Title = "";
      print(b2.Title == "None");

      Book3 b3 = new Book3();
      b3.Title = "Bible";
      print(b3.Title == "Bible");

      Book4 b4 = new Book4 { // object initializer 초기화 할 수 있다. , 첫 값을 넣는 행위, 디폴트 값으로 클리어 시키는 것
        Title = "TLOR", 
        Price = 30000 
      };
      print(b4.Price == 30000);

      // 이제 위에 처럼 만들면 된다. 프리버티 , 아니면 원래 만드는 대로 
  }

    class Book4 {
      public string Title { get; set; }
      public int Price { get; set; }

    }

    class Book3 {
      public string Title { get; set; } //get만 사용 가능, 이럴 경우 읽기만 하는 것 private set도 가능 (자기 속에서만 읽을 수 있다.)
    }
  
    class Book2 {
      string title; // 캡슐화, 블랙박스화 기본적으로 private로 보호가 된다.
      public string Title {
        get {
          return title;
        }
        set {
          Console.WriteLine("디버깅"); // 디버깅할때 사용가능 구분짓는것
         if(value == "") // 입력받은 값 (==값 왼쪽에 있는 것); 예약어 set에서만 쓸수있는 value, 변수는 소문자로 시작, private 대문자가 관례.
          title = "None";
         else
          title = value; // 건드리지는 말되 혹시라도 건들일이 있으면 get set준다.
        }
      }
  }

  class Book {
      string title; // 캡슐화, 블랙박스화 기본적으로 private로 보호가 된다.
      public string GetTitle() { return title; } // 가져오는건 GET
      public void SetTitle(string title) { // 셋팅하는건 SET
        this.title = title;
      }
  }
}