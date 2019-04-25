using System;

class MainClass {
  public static int Comp(int x, int y) { return x.CompareTo(y); }
  public static void Main (string[] args) {
    Action<object> print = Console.WriteLine;

    
    int[] scores = { 2, 4, 5, 3, 6 ,8 ,1 ,7} ;
    print(scores.GetType().ToString() == "System.Int32[]");
    print(scores.GetType().BaseType.ToString() == "System.Array");

    print(Stringify(new int[] {2}) == "2"); // 익명 객체 
    print(Stringify(new int[] {}) == String.Empty);
    print(Stringify(scores) == "2 4 5 3 6 8 1 7"); // 테스트 작업

    Array.ForEach( scores, v => Console.Write(v*2 + " ")); //ForEach 함수 의미 스코어의 각 멤버에 대해서 뭔가를 해달라는 것, 익명 함수 표현법 남다 익스프레셔; 익명 = 함수이름x, 용도 콜백, {}로 여러개 사용가능 ForEach에서 콜을 해서 백 해주는 것.
    print("\n");

    // Sorting: 오름차순(Ascending order)
    print("\t\tSorting");
    Array.Sort( scores ); // 제자리 알고리즘 추가 메모리 없이 자기 자리에서 움직이는 것 , in - place algorithm
    print(Stringify(scores) == "1 2 3 4 5 6 7 8");
    // public static int Comp(int x, int y) { return x.CompareTo(y); } // 소팅 정의 방법 반대로는 x, y 반대로 일반화 시키는 것
    Array.Sort( scores, Comp);
    print(Stringify(scores) == "1 2 3 4 5 6 7 8");
    Array.Sort( scores, delegate (int x, int y) {return x.CompareTo(y); });
    Array.Sort( scores, (x,y) => x.CompareTo(y) );
    print(Stringify(scores) == "1 2 3 4 5 6 7 8");
    Array.Sort( scores, (x,y) => x-y );


    // 내림차순(Descending order)
    Array.Sort( scores, (x,y) => y.CompareTo(x) );
    print(Stringify(scores) == "8 7 6 5 4 3 2 1");
    Array.Sort( scores, (x,y) => y-x );
    print(Stringify(scores) == "8 7 6 5 4 3 2 1");

    print(1.CompareTo(2) < 0);
    print(2.CompareTo(1) > 0);
    print(1.CompareTo(1) == 0);
    print(2.CompareTo(2) == 0);
  }

  public static string Stringify(int[] list)
  {
    return String.Join(" ", list);
  }
}