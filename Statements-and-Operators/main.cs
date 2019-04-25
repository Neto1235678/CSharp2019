using System;

class MainClass {
  public enum Color {Red, Green, Blue};

  public static void Main (string[] args) {
    Action<object> print = Console.WriteLine;

    Random rnd = new Random();
    Color c = (Color) rnd.Next(0, 4); // 0 ~ 3 random value
    if(c == Color.Red)
    {
      print(c == Color.Red);
    }
    else if(c == Color.Green)
    {
      print(c == Color.Green);
    }
    else if(c == Color.Blue)
    {
      print(c == Color.Blue);
    }
    else
    print("Unknown Color !");


    switch(c) 
    {
      case Color.Red:
        print(c == Color.Red);
        break;
      case Color.Green:
        print(c == Color.Green);
        break;
      case Color.Blue:
        print(c == Color.Blue);
        break;
      default: 
        print("Unknown Color !");
        break;
    }

    switch(c) 
    {
      case Color.Red:      
      case Color.Green:      
      case Color.Blue:
        print(c);
        break;    
      default: 
        print("Unknown Color !");
        break;
    }

    int[] scroes = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};    
    print(SumIf(scroes, v => v%2==0) == 30);
    print(SumIf(scroes, v => v%2!=0) == 25);
    print(SumIf(scroes, v => v > 6) == 34);
    print(SumIf(scroes, v => true) == 55);

    print(SumIf1(scroes, v => v%2==0) == 30);

    int count = 1;
    print(++count == 2);
    count = 1;
    print(count++ == 1);
    
    int a= 9, b = 8;
    int carry = a+b > 10 ? 1 : 0; //carry 올림 
    int ramainder = a+b > 10 ? a+b-10 : a+b; // 나누기
    print(carry == 1 && ramainder == 7); // short - circuit evaluation
    
  }

  public static int  SumIf(int[] list, Func<int, bool> condition) // Func <파라미터, 리턴값> 마지막 값이 항상 리턴 값 ex bool등 bool function(int v); condition 함수를 가진 변수
  {
   int i = 0;
   int sum = 0;
   while(i < list.Length)
   {
     if(!condition(list[i]))
     {
       i++;
       continue;
       //break;가 있으면 루프를 종료한다.
     }
     else 
     {
       sum += list[i++];
     }
   }
    return sum;
  }

  public static int  SumIf1(int[] list, Func<int, bool> condition) 
  {
    int i = 0;
    int sum = 0;
    do // 한번은 시작된다는 것을 보장해준다. 그리고 뒤에 조건, 윈도우 R 
    {
      if(condition(list[i]))
      sum += list[i];
    } while(++i < list.Length);
    return sum;
  }


}