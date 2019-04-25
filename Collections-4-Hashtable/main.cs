using System;
using System.Collections;

class MainClass {
  public static void Main (string[] args) {
    Action<object> print = Console.WriteLine;

    Hashtable ht = new Hashtable();
    ht.Add("txt", "notepab.exe");
    ht.Add("bmp", "paint.exe");
    ht.Add("dib", "paint.exe");
    ht.Add("rtf", "wrodpad.exe");
    print(ht.Count == 4);


    try {
      ht.Add("txt", "winword.exe");
    } catch {
      print("already exists!");
    }
    print(ht.Count == 4);

    ht["max"] = "3dsmax.exe"; // [] 어레이 참고 연산자(대괄호) c#은 
    print(ht.Count == 5);

    print((string)ht["max"] == "3dsmax.exe");

    print(ht.ContainsKey("bmp") == true);
    ht.Remove("bmp");
    print(ht.ContainsKey("bmp") == false);

    Hashtable users = new Hashtable();
    users[100] = new User(100, "ctkim", 20);
    users[101] = new User(101, "brown", 30);
    users[102] = new User(102, "hash", 10);
    print(users.Count == 3);
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