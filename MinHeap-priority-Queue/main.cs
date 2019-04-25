using System;
using System.Collections;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    Action<object> print = Console.WriteLine;

    MinHeap h = new MinHeap();
    h.Insert(7);
    print(h.Stringify() == "7");
    h.Insert(1);
    print(h.Stringify() == "1 7");
    h.Insert(3);
    h.Insert(2);
    h.Insert(5);
    h.Insert(1);
    h.Insert(8);
    h.Insert(0);
    print(h.Stringify() == "0 1 1 2 5 3 8 7");
    h.Remove(1);
    print(h.Stringify() == "0 2 1 7 5 3 8");
    print( h.Find(o=>o==2) == 2);

    h.Insert(1);
    h.Remove(0);
    print(h.RemoveTop() == 1);
    print(h.RemoveTop() == 1);
    print(h.RemoveTop() == 2);
    print(h.Stringify() == "3 5 8 7");
    print(h.RemoveTop() == 3);
    print(h.RemoveTop() == 5);
    print(h.RemoveTop() == 7);
    print(h.RemoveTop() == 8);
    print(h.Stringify() == "");
    try {
        print(h.RemoveTop());
    } catch { }

    // print(h.Stringify() == "7 5 8 1 2 1 3 0");

   // RemoveTop();
   // print(h.Stringify());
    //print( h.RemoveTop() == 0);

    //print( h.Find(o=>o==2) == 2); //object가 2인걸 찾고 2를 리턴한다. Generic하게 만들면 특정 조건을 만족하는 애를 찾아서 데리고 온다.

  }
}




public class MinHeap {
  List<int> list;

  public MinHeap() {
    list = new List<int>();
  }

  public void Insert(int v) {
    list.Add(v);
    HeapifyUp(list.Count-1);
   

  }

  void HeapifyUp(int i) {
    if (i < 1) // 리커전은 항상 종료 조건을 잘 넣어야된다.
    return;
    int p = Parent(i);
    if(list[p] > list[i])
      list.Swap(p, i);
      HeapifyUp(p);
      
  }

//  public void HeapifyDown(int i){

//     if(i < 1)
//     return;
//     int r = RChild(i);
//     int l = LChild(i);
//     if(list[r] < list[l] || list[r] > list[l]) {

//       if(list[r] < list[i]) {
//         list.Swap(r, i);
//         HeapifyDown(i);
//       }else
//         list.Swap(l, i);
//         HeapifyDown(i);
      
//     }else if(list[r] > list.Count -1)
    
      
//  }
  
  public void Remove(int v) {
    if(list.Count > 0) {
      int index = list.FindIndex( o=> o==v);
      if(index != -1) {
        list[index] = list[list.Count-1];
        list.RemoveAt(list.Count-1);
        HeapifyDown(index);
      }
    }
  }

  public int RemoveTop() {

    if(list.Count > 0) {
      int v = list[0];
      list[0] = list[list.Count-1];
      list.RemoveAt(list.Count-1);
      HeapifyDown(0);
      return v;
    } else {
      throw new InvalidOperationException("No data");
    }
  

  }

  void HeapifyDown(int p) {
    if(list.Count <= 1)
    return;
    int l = LChild(p);
    int r = RChild(p);
    if(IsLeaf(p))
      return;
    if(r > list.Count-1) {
      if(list[l] < list[p])
        list.Swap(l, p);
        return;
    } else {
      if(list[r] <= list[p]) {
        if(list[l] < list[p]) {
          list.Swap(r, p);
          HeapifyDown(r); 
        }
      } else {
        if(list[r]  < list[p]) {
          if(list[l] < list[p]) {
          list.Swap(r, p);
          HeapifyDown(r); 
        }
        }
      }
    }
    

  }

  // Func<int,bool> f
  public int Find(Predicate<int> f) { // return Predicate은 제한이 없고 리턴값이 트루 펄스 인 리턴값이 1개인 것 == Func<int,bool> f  같다
    int i = list.FindIndex(f);
    if (i != -1)
      return list[i];
    else
      return -1;
  }

  public string Stringify() {
    return list.Stringify();
  }

  int Parent(int i) { return (i-1)/2; }
  int LChild(int i) { return 2*(i+1)-1; }
  int RChild(int i) { return LChild(i)+1; }
  bool IsLeaf(int i ) { return LChild(i) > list.Count-1;}
}


public static class ClassExtension{
  public static string Stringify<T>(this IEnumerable<T> list){
    return String.Join(" ", list);
  }

  public static IList<T> Swap<T>(this IList<T> list, int i, int j) {
    T temp = list[i];
    list[i] = list[j];
    list[j] = temp;
    return list;
  }
}
// P(i) = P(i -1)/2
// L(i) = 2*(L+1)-1;
// R(I) = L(i)+1;
// 자식간에 관계 중요하지 않음, 대신 부모와의 관계 중요!@
// 힙핑 업, 힙핑 다운

// 힙핑ify 다운해서 작업해야된다.