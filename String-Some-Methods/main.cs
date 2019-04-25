using System;

class MainClass {
  public static void Main (string[] args) {
    Action<object> print = Console.WriteLine; // Fucn 리턴 타입이 있는 것을 담을 수 있다.

    string s;
    s = "ABC";
    print(s.Length == 3);

    s = "ABCDEF";
    print(s.IndexOf("CDE") == 2);
    print(s.IndexOf("ZZZ") == -1);

    s = "Mr Song";
    print(s.Replace("Mr", "Miss") == "Miss Song"); // Replace 교체 하는 함수

    int[] arrayA = {1, 3, 5, 7, 9};
    print(String.Join(" ", arrayA) == "1 3 5 7 9");// Join 원하는 특수문자로 교환 가능하는 것
    print(Stringify(arrayA) == "1 3 5 7 9");

    s = "1000,2000,3000";
    string[] prices = s.Split(','); // 특정 기준으로 분리하고 싶을 때 사용
    print(String.Join(" ", prices) == "1000 2000 3000");

    s = "1000, 2000, 3000";
    prices = s.Replace(" ", "").Split(','); // 특정 기준으로 분리하고 싶을 때 사용
    print(String.Join(" ", prices) == "1000 2000 3000");
    print("" == String.Empty && "" == string.Empty);

    s = "ABCDEF";
    print(s.Substring(1, 3) == "BCD"); // Substring(행, 길이);
   // print(s.Substring(3, 7)); // System.ArgumentOutOfRangeException: ! error
  }

  public static string Stringify(int[] list)
  {
    return String.Join(" ", list);
  }
}