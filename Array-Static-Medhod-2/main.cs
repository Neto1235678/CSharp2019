using System;

class MainClass {
  public static int Comp(int x, int y) { return x.CompareTo(y); }
  public static void Main (string[] args) {
    Action<object> print = Console.WriteLine;

    
    string[] names = new string[] {"c", "b", "a", "d"};

    print(names.GetType().ToString() == "System.String[]");
    print(names.GetType().BaseType.ToString() == "System.Array");

    print(Stringify(new string[] {"a"}) == "a"); // 익명 객체 
    print(Stringify(new string[] {}) == String.Empty);
    print(Stringify(names) == "c b a d"); // 테스트 작업

    Array.Sort( names );
    print(Stringify(names) == "a b c d");
    Array.Sort( names, (x, y) => x.CompareTo(y) );
    print(Stringify(names) == "a b c d");
    Array.Sort( names, (x, y) => y.CompareTo(x) );
    print('a'.CompareTo('b') < 0); // a = 97, b = 98 , 97 - 98 < 0
    print('b'.CompareTo('a') > 0); // 98 - 97 > 0
    print('a'.CompareTo('a') == 0); // 97 - 97 == 0
    print(Stringify(names) == "d c b a");

    User[] users = new User[3]{
    new User("Betty", 23),
    new User("Susan", 20),
    new User("Lisa", 25) 
    };
    // Array.Sort( users ); // No IComparable 어떻게 소팅해야될 지 모르겠다는 것
    Array.Sort( users, (u1, u2) => u1.age.CompareTo(u2.age) );
    Array.Sort( users, (u1, u2) => u1.age-u2.age );
    foreach(User user in users)
      Console.Write(user.name + user.age + " ");
    Console.WriteLine();
    Array.Sort( users, (u1, u2) => u2.name.CompareTo(u1.name) );
    foreach(User user in users)
      Console.Write(user.name + user.age + " ");

  }

  class User
  {
    public string name;
    public int age;
    public User(string _name, int _age)
    {
      name = _name; age = _age;
    }
  }

  public static string Stringify(string[] list)
  {
    return String.Join(" ", list);
  }
}