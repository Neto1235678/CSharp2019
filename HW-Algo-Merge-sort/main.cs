using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    Action<object> print = Console.WriteLine; 

    int[] list = { 6, 8, 1, 4, 3, 2, 5, 7, 9 };
    MergeSort(list, 0, list.Length-1);
    print( list.Stringify());

    list = new int[] { 6, 8, 1, 4, 3, 2, 5, 7, 9 };
    Conbine(list, 0, 0, 1, 1); //Conbine(비교 어레이 위치번호)
    print( list.Stringify());
    Conbine(list, 0, 1, 2, 3);
    print( list.Stringify());
    Conbine(list, 5, 6, 7, 8);
    print( list.Stringify());
  }

  public static void MergeSort(int[] list, int left, int right) {
    if(left == right)
      return;
    int mid = (left+right) / 2;
    MergeSort(list, left, mid);
    MergeSort(list, mid+1, right);
    Conbine(list, left, mid, mid+1, right);
  }

  // not - inplace : 주어진 소스 데이타 외에 다른 데이터를 사용하는 알고리즘., inplace : 주어진 데이터만 사용
  // 오프라인 : 알고리즘이 실행하기전에 데이터가 다 있어야된다. 온라인 : 실시간으로 알고리즘이 돌아간다.
  public static void Conbine(int[] list, int leftBegin, int leftEnd, 
                                         int rightBegin, int rightEnd) {
    int i = leftBegin;
    int j = rightBegin;
    var C = new int[(rightEnd - leftBegin)+1];
    for(int k = 0; k < C.Length; k++){

      if(i > leftEnd || j > rightEnd){
        if(i > leftEnd)
          C[k] = list[j++];
        else 
          C[k] = list[i++];
      } else {

        if(list[i] <= list[j])
          C[k] = list[i];
        else
          C[k] = list[j];
      }
    }

    i = leftBegin;
    for(int k = 0; k < C.Length; k++)
      list[i++] = C[k];
  }
}

public static class ClassExtension{
  public static string Stringify<T>(this IEnumerable<T> list){
    return String.Join(" ", list);
  }
} 
