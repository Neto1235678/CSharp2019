using System;

class MainClass {
  public static void Main (string[] args) {
    Action<object> print = Console.WriteLine;

    int[] array = { 1, 2, 3, 4, 5, 6, 7, 8};
    print( array.Stringify() == "36");
    print( array.Stringify1() == "4.5");
    print( array.Sum() == 36);
    print( array.Avg() == 4.5);


    //string[] length = {"ABCD"};
    //print( LengthRecursive(length) == "4");
    print( MaxRecursive(array) == 8);
    print( MaxRecursive1(array) == 8);

    
  }

//  public static string LengthRecursive(string[] list){

//    return list;
//  }

  public static int MaxRecursive(int[] list){

    int max = 0;
    int temp = 0;
    for(int i = 0; i < list.Length; i++)
    {
      temp = list[i];
      list[i] = max;
      max = temp;  
    }
    
    return max;
  }

   public static int MaxRecursive1(int[] list){

   
    if(list[i] == 8)
   {
      return list; // Array.Copy(list, newList(변수명), 값);
   }
   
    return MaxRecursive1(list) + MaxRecursive1();

  }

}


  public static class ClassExtension{
    
  public static string Stringify(this int[] list){
    int s = 0;
    foreach(int n in list)
    s += n;
    return s.ToString();
  }

  public static string Stringify1(this int[] list){
    int s = 0;
    foreach(int n in list)
    s += n;
    double avg = s / (double)list.Length;
    return avg.ToString();
  }

  public static int Sum(this int[] list){
    int s = 0;
    foreach(int n in list)
    s += n;
    return s;
  }

  public static double Avg(this int[] list){
    return Sum(list) / (double)list.Length;
  }
}
