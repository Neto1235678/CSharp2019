using System;


					
public class Program
{
	public static void Main()
	{
		Book lor = new Book("The Load of the Rings", 30000, "J.R.R Tolkien"); // 힙은 가비지 콜렉션이 제거한다. 함수를 가르키는 놈이 없을 때. C#은 메니지트?, DOTS,lor이 객체(만들어진 붕어빵 실체), 그 뒤에 있는 것은 붕어빵을 만든 틀과 내용?

		Book hobbit = new Book("The Hobbit", 40000, "J.R.R Tolkien");

    Console.WriteLine(Book.count == 2); // 참조를 클래스.변수명

    Book[] books = new Book[2]; // Book이라는 객체를 담는 레퍼런스를 만든 것.
    books[0] = lor;
    books[1] = hobbit;

    foreach(var book in books)
    Console.WriteLine(book.title + ", " + book.price + ", " + book.author + 
    book.author +", " + book.DiscountPrice(0.15));

	}
}
public class Book{ // class는 붕어빵 틀 
	//private string title; // 필드, 어빌리티, 인 캡슐레이터(기본) == or string title
  public string title;
	public int price;
	public string author;
	
  public static int count = 0; // 공통된 녀석, 초기화 값(상수역할), 비교

	public Book(string _title, int _price, string _author){
		this.title = _title;
		this.price = _price;
		this.author = _author;
    count++;
	}
	
  public double DiscountPrice(double discount){
    return (price - price * discount);
  }
}