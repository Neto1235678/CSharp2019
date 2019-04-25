using System;


delegate int CallBack(int a, int b); // 콜백이라는 함수(파라미타 추가 가능)을 만듬 int 리턴 값이 있는  

class MainClass {
  public static void Main (string[] args) {
    Action<object> print = Console.WriteLine;

    //1
    CallBack cb = new CallBack(Sum);

    //2
    CallBack cb2;
    cb2 = Sum;
    print( cb(1, 2) == 3);
    print( cb2(1, 2) == 3);


    cb = delegate(int i, int j) { return i + j;}; // 익명함수
    print( cb(1, 2) == 3);

    cb = (int i, int j) => { return i+j; };       // 람다식
    print( cb(1, 2) == 3); 

    cb = (i , j) => i+j; // 문장 여러 개는 중괄호 필요 
    print( cb(1, 2) == 3);

    
  }
  public static int Sum(int a, int b){
    return a + b;
  }
}