using System;

class MainClass {
  public static void Main (string[] args) {
    Action<object> print = Console.WriteLine;
    
    int[] array = {7, 5, 3, 8, 1};
    print(QuickSort(array));
    
    }

    public static void QuickSort(int[] list){ //인플레이션 = 추가적인 메모리가 필요 없다.

    int pivot = list[0];

    for(int i; i < list.Length+1; i++){
      if(pivot < list[i]){
        for(int j; j > list.Length-1; j--)
        {
          if(list[j] >= list[i]){
            int temp = list[j];
            list[j] = pivot;
            pivot = temp;
            Console.WriteLine(temp);
          }
        }
      }
      if(list[i] < list[j])
      {

      }
    }
  }
}



// 주말 숙제 : 퀵 소팅 알고리즘만 이용
// 7 5 3 8 1 , 7이 기준이라면 피벗이 어느 기준으로 들어가는지 찾기. 앞에서 부터 잡기.
// 7보다 큰 것 찾기 7보다 찾은 것 찾기. 찾은 다음 두개를 교환 
// 위치 찾는 것. 찾다가 인덱스가 바뀌는 부분이 자기가 있는 부분. 
// 앞뒤로 조사할 것이 없으면 끝
// 자기자리일 시에도 끝
// 마지막 남으면 두개 비교
// 비교를 하다가
// 작은 수는 왼쪽, 큰 수는 오른쪽으로 옮겨진다는게 보장이 된다.