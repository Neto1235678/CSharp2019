using System;
using System.Collections;

class MainClass {
  public static void Main (string[] args) { //Generic이 아닌 버전 object로 짠 거, 성능적인 문제가 있다.
    Action<object> print = Console.WriteLine;

    ArrayList list = new ArrayList();
    list.Add(100);
    print((int)list[0] == 100); // 박씽할 때 오브젝트 타입으로 들어가기에, 언 박씽을 잘 해줘야된다.
    list.Add(200);
    print(list.Count == 2); // 모든 스텍 리스트 큐? 등은 카운트를 가지고 있다.
    //list.Insert(5, 300);  // Argment
    list.Insert(2, 300);
    print((int)list[2] == 300);

    list.Remove(100);
    print(list.Count == 2);
    print((int)list[0] == 200);
    print((int)list[1] == 300);

    foreach(var v in list) // 이너물이 가능해야지 폴이취가 가능하다.
      print(v);


    print(list.Contains(200) == true);
    print(list.Contains(700) == false);
  }
}