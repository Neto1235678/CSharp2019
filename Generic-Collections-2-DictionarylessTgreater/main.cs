using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    Action<object> print = Console.WriteLine;

    Dictionary<string, string> ht = new Dictionary<string, string>();
    ht.Add("txt", "notepad.exe");
    ht.Add("bmp", "paint.exe");
    ht.Add("dib", "paint.exe");
    ht.Add("rtf", "wrodpad.exe");
    print(ht.Count == 4);

    try {
      ht.Add("txt", "winword.exe");
    } catch {
      print("already exists !");
    }
    print(ht.Count == 4);

    ht["max"] = "3dsmax.exe"; // [] 어레이 참고 연산자(대괄호) c#은 
    print(ht.Count == 5);

    print(ht["max"] == "3dsmax.exe");

    print(ht.ContainsKey("bmp") == true);
    ht.Remove("bmp");
    print(ht.ContainsKey("bmp") == false);

    // Dictionary<int, string> users = new Dictionary<int, string>();
    // users.Add(100, "ckckck");
    // users[100, "ctkim"] = new User(100, "ctkim");
    // print(users.Count == 3);
  }
}

public class User {
  public int Id { get; set; }
  public string Name { get; set; }
  public int Age { get; set; }
  public User(int Id, string name, int age) {
    Name = name;
    Age = age;
  }

}


// // public class Student {
//   public string Name { get; set; }
//   public List<int> Scores { get; set; }
// }
// 점수 중에 60점 미만이 하나라도 있으면 낙제생 리스트(이름) 넣기
// 낙제생이 아닌 사람들 리스트(이름) 구하기
// Console.WriteLine(name.Stringify() == 비교) 