using System;

class MainClass {
  public static void Main (string[] args) {
    Action<object> print = Console.WriteLine;  

    int[] num = new int[] {
      1, 1, 1, 2, 1, 2, 3, 3, 3, 3, 1, 1, 3, 4, 4, 1, 1, 4, 4
    }; 

    print(FrequencyOf(num, 1) == 8);
    print(FrequencyOf(num, 4) == 4);
    print(FrequencyOf(num, 100) == 0);
    print(ValueOfMaxFreq(num) == 1);
    int[] num2 = {1, 2, 2, 3, 3, 3};
    print(ValueOfMaxFreq(num2));
    
  }

  public static int ValueOfMaxFreq(int[] list)
  {
    int num = 0;
    int max = 0;
    int[] count = new int[10]; // 해쉬 테이블 사용하여,, 하는게 좋다.
    foreach(int n in list)
    {
      for(int j = 0; j < 10; j++)
      {
        if(n == j)
        {
          count[j]++;
        }

        if(max < count[j])
        {
          max = count[j];
          num = j;
        }

      }
            
    }
    return num;
  }

  public static int FrequencyOf(int[] list, int a)
  {
    int count = 0;
    foreach(int n in list)
    {
      if(n == a)
      {
        count++;
      }
    }
    return count;
   
  }

  public static string Stringfiy(int[] list)
  {
    return String.Join("", list); 
  }

}




// FrequencyOf(변수명, 찾을 내용) , ValueOfMaxFreq(변수명)// 다시 가장 많은 내용이 있는 것 1. 숫자 몇개 있는지 찾기, 2.
// Marge arrays , 리니어 타임 따로 있는 내용을 앞에 있는 것과 비교해서 순서대로 정렬 하는 것 
// 결과 를 담을 배열을 하나 담고 뒤에 남는 것을 관리 잘 하면된다. 1. 숫자들 정렬, 2. 같은 숫자들 정렬 3. 공백 4.익명으로 만들어서 정렬 5. 익명으로 만들어서 정렬

// 수 목 금.. 숙제 다 하기 ㅠ ㅠ//
