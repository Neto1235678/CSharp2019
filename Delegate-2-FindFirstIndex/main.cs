using System;

class MainClass {
  public delegate bool Condition(int index, int value);

  public static void Main (string[] args) {
    Action<object> print = Console.WriteLine;

    int[]  scores = { 1, 2, 3, 4, 5, 6, 7};
    print(FindFirstIndex(scores, (i,v) => v == 7) == 6); 
    print(FindFirstIndex(scores, (i,v) => i > 4 && v >= 7) == 6);  
    print(FindFirstIndex(scores, (i,v) => v == 0) == -1);     
  }
  
  public static int FindFirstIndex(int[] list, Condition condition){
    for (int i = 0; i < list.Length; i++){
      if(condition(i, list[i]))
      return i;
    }
    return -1;
  }

  // static 스텍 자료 구조 짜오기? 선형 = array로 만들기 테스트 케이스 만들기. Push, Pop 작동되는지 확인, int 타입만 되는지 확인.
}