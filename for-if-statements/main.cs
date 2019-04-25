using System;

class MainClass {
  public static void Main (string[] args) {

   for( int i = 0; i <= 9; i++){
      for(int j = 0; j < 9 - i; j++){  
        Console.Write(" "); 
      }    
      for(int j = 0; j < i; j++)
      {
        Console.Write("*"); 
      }
      Console.WriteLine();
    }
		Console.WriteLine();


	 int count = 5;	
   for( int i = 0; i <= 9; i++){
     if(i % 2 == 1 || i == 1){
      for(int j = 9; j > count; j--){  
        Console.Write(" ");    
			}
      for(int a = 0; a < i; a++)
      {
        Console.Write("*"); 
      }  
      	Console.WriteLine();
				count++; 
		 }
	 }

	 int _count = 1;
   for( int b = 7; b > 0; b--){
     if(b % 2 == 1 || b == 1){
      for(int j = 0; j < _count; j++){  
        Console.Write(" ");    
			}
      for(int a = 0; a < b; a++)
      {
        Console.Write("*"); 
      }  
      	Console.WriteLine();
				_count++; 
		 }		 
}

  // double x1; // 음수 해
  // double x2; // 양수 해
  // double a = 5;
  // double b = 5;
  // double c = 1; 
  // double d; // 판별식

  // d = Math.Pow(b, 2)-4 * a * c;

  // x1 = -b + Math.Sqrt(d) / 2 * a;
  // x2 = -b - Math.Sqrt(d) / 2 * a;

  // if(d > 0)
  // {

  //  Console.WriteLine(x1);
  //  Console.WriteLine(x2);

  //  Console.WriteLine(x1.GetType().IsValueType == true);
  //  Console.WriteLine(x2.GetType().IsValueType == true);

  // }
  // else if(d == 0)
  // {

  //   Console.WriteLine(x1);
  //   Console.WriteLine(x1.GetType().IsValueType == true);

  // }
  // else
  // {
  //   Console.WriteLine("해가없음");
  // }
  
  
    
    
    
    
    /*int num = 10;
    if(num > 0)
    {
      Console.WriteLine(true);
    } else {
      if(true){


      }else {

      }
      
    }*/
     // 절대 값 Math.abs(함수); , Math.sqrt
  } //  for(int a = 0; a < 9; a++){ , Console.Write("*"); ,  Console.WriteLine();     
     
     
}