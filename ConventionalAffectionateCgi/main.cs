using System;

class MainClass {
  public static void Main (string[] args) {
    Action<object> print = Console.WriteLine;

    print(CheckPassword("kIMJ"));
    // print(CheckPassword(str.Length) == 6 && 15);
    // print(CheckPassword(str.Length) == 5);

  }

  // public static void TextConsole(){

  //   string name;

  //   Console.Write("password를 입력해 주세요");
  //   name = Console.ReadLine();
  //   Console.WriteLine(name);

  // }

  public static int CheckPassword(string password)
  {

    str temp =;

    for(int i = 0; i < password.Length; i++)
    {
      temp = i;
    }
    
    return temp.ToString(); // \해서 특수문자를 사용하면 특수하게 봐달라는 것. OR @을 사용하여 가능.

  }
}

// Check password
// 주어진 password 문자열이 다음 규칙을 만족하는지 알려주는 CheckPassword(string password) 작성하세요.
// 테스트
// 1. 6 ~ 15 자리까지만 가능
// 2. 연속으로 동일 문자가 나오지 않아야 함
// 3. 적어도 하나의 소문자 포함
// 4. 적어도 하나의 대문자 포함
// 5. 적어도 하나의 특수 문자 포함: !@#$%^&*()?/>.<,:;'\|}]{] {[_~`+="-
// 6. 공백 문자(white space) 포함 불가

// 주말 숙제 : 퀵 소팅 알고리즘만 이용
// 7 5 3 8 1 , 7이 기준이라면 피벗이 어느 기준으로 들어가는지 찾기. 앞에서 부터 잡기.
// 7보다 큰 것 찾기 7보다 찾은 것 찾기. 찾은 다음 두개를 교환 
// 위치 찾는 것. 찾다가 인덱스가 바뀌는 부분이 자기가 있는 부분. 
// 앞뒤로 조사할 것이 없으면 끝
// 자기자리일 시에도 끝
// 마지막 남으면 두개 비교
// 비교를 하다가
// 작은 수는 왼쪽, 큰 수는 오른쪽으로 옮겨진다는게 보장이 된다.