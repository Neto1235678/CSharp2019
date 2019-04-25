using System;

class MainClass {
  public static void Main (string[] args) {
    Action<object> print = Console.WriteLine;

    print(Add("999","1") == "1000");
    print(Add("999","0") == "999");
    print(Add("9","1") == "10");
    print(Add("123","12") == "135");
    print(Add("123","10000") == "10123");
    //print(Add("0","0") == "0");
    //print(Add("1900000000008",
      //        "9900000009999")
       //   == "11800000010007");
  }
    
  public static string Add(string a, string b)
  {
    int ia;
    int ib;
    string temp;

    if(a.Length < b.Length)
    {
      temp = a;
      a = b;
      b = temp;
      
    } // 사망연산자 사용, 여러가지 배열을 돌릴 때{arrayA, arrayB; i >= 0 , i--, j--} 이렇게 할 수도 있다.
    // 알고리즘을 알고 있을 때 코딩화 시키는 능력.
    
    ia = int.Parse(a.ToString());    
    ib = int.Parse(b.ToString());
    
    Console.WriteLine(ia); 
    Console.WriteLine(ib);
    
  
    for(int c = b.Length; c < a.Length; c++)
    {
    
     // b += c.ToString();

    }
    //int val = b.ToString().Length + a.Length;
    for(int i = a.Length -1; i > -1; i--)
    {      
     
      
    }
    
    for(int j = b.Length -1; j > -1; j--)
    {               
              
    }   
    return a;
  }
} 