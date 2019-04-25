using System;

class MainClass {
  public static void Main (string[] args) {
    Action<object> print = Console.WriteLine;

    int[] scores = {7, 4, 5, 1, 3};
    BubbleSort(scores);
    print(Stringify(scores) == "1 3 4 5 7");

    
  }
  public static void BubbleSort(int[] arr){
    int temp, i, j;

    for( i = 0; i < arr.Length; i++){
      
      for(j =0; j < arr.Length-1; j++){
         
        if(arr[j] > arr[j+1]){
          temp = arr[j];
          arr[j] = arr[j+1];
          arr[j+1] = temp;

        }       
      }     
    } 
  }
  public static string Stringify(int[] list)
  {
    return String.Join(" ", list);
  }
}