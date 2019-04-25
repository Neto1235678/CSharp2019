using System;
using System.Collections.Generic;
using System.Linq; // 활성화 되는 순간 함수가 arr에 들어간다.


// Linq: Language INtegrated Query
// 일종의 쿼리 표현식
// Query: 다양한 형태의 Data source로부터 일관된 방식으로 데이터를 추출하는 표현식
// Data source: DB, ADO.NET Data sets, .NET Collections
// IEnumerable<T> type은 모두 Linq 적용이 가능하다 == Queryable type

// Deferred excution: foreach, ToArray(), ToList(), Count(), Max(), Average() ... 즉시 실행
// 컴파일러가 알아서 함수형식으로 변경 시킴
// IEnumerable Extension Method로 정의
// using System.Linq
// Class extension으로 구현

class MainClass {
  public static void Main (string[] args) {
    Action<object> print = Console.WriteLine;

    // 1. Data source
    int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
   
    // 2. Query creation: Query syntex <- 여기서는 실행이 안됨.
    IEnumerable<int> evens = 
      from n in numbers     // data source
      where n%2 == 0        // filtering
      select n;             // result Type, ！select n == IEnumerable<int>

    // 3. Query excution: Deferred excution <- 여기서 실행
      foreach(int n  in evens)
        print(n);

      print(evens);

      print( evens.Stringify() == "2 4 6 8 10"); 

      // 즉시 실행
      print( evens.ToArray().Stringify() == "2 4 6 8 10"); 
      print( evens.ToList().Stringify() == "2 4 6 8 10");  

      // Method syntex
      IEnumerable<int> evens2 =
      numbers.Where(n =>n%2==0).Select(n => n);
      print( evens.Stringify() == "2 4 6 8 10"); 
      print(evens2);

      List<Student> list = new List<Student> {
        new Student() { Name="ctkm", Height=175, Scores= new List<int>() { 100, 70, 90, 77, 88} },
        new Student() { Name="Steve", Height=167, Scores= new List<int>() { 77, 60, 90, 77, 55} },
        new Student() { Name="Brown", Height=180, Scores= new List<int>() { 30, 61, 91, 100, 57} },
        new Student() { Name="Won", Height=171, Scores= new List<int>() { 100, 100, 91, 100, 100} },
        new Student() { Name="jj", Height=165, Scores= new List<int>() { 10, 100, 9, 100, 100} }
    };
    // List
    print(list.Stringify() == "ctkm Steve Brown Won jj");
    List<Student> ss1 = list.FindAll(s => s.Height < 175);
    print(ss1.Stringify() == "Steve Won jj");

    //Ling version
    var ss2 = from student in list
              where student.Height < 175
              select student;
    print(ss2.Stringify() == "Steve Won jj");
    // print(ss2);

    IEnumerable<Student> ss3 = from student in list
              where student.Height < 175
              orderby student.Height // 정렬하기 오름차순으로
              select student;
    print(ss3.Stringify() == "jj Steve Won");

    IEnumerable<Student> ss4 = from student in list
              where student.Height < 175
              orderby student.Height descending // 정렬하기 내림차순으로
              select student;
    print(ss4.Stringify() == "Won Steve jj");

    IEnumerable<string> ss5 = from student in list
              where student.Height < 175
              orderby student.Height descending 
              select student.Name;  // Name이 stirng 타입
    print(ss5.Stringify() == "Won Steve jj");   

    var ss6 = from student in list
              where student.Height < 175
              orderby student.Height descending 
              select new { Name = student.Name, InchHeight=student.Height*0.393};  //익명객체 , *0.393 인치로 바꿈
    print(ss6.Stringify());     

		var ss6_ = list
							.Where( student => student.Height < 175 )
							.OrderBy( student => student.Height )
							.Select( student => new { Name = student.Name,
							InchHeight=student.Height*0.393} );
 		print(ss6_.Stringify());     							

		print("\n");

		var ct = new {Name="ctkim", Height=178};
		print(ct.Name);
		print(ct.GetType().ToString());

		var ss7 = 
			from s in list
			let totalScore = s.Scores[0] + s.Scores[1] + s.Scores[2] + s.Scores[3] + s.Scores[4]
			select totalScore;
		print(ss7.Stringify() == "425 359 339 491 319");
		double averagetScore = ss7.Average();
		print(averagetScore);
	}
}

public class Student {
  public string Name { get; set; }
  public int Height { get; set; }
  public List<int> Scores { get; set; }
  public override string ToString() {
    return Name;
  }
}


public static class ClassExtension{
  public static string Stringify<T>(this IEnumerable<T> list){
    return String.Join(" ", list); // String.Join 안에 foreach가 있다.
  }
}