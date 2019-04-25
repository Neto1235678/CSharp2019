 using System;

class MainClass {
  public static void Main (string[] args) { // stringify 자바에서 문자열로 바꿔주는 것;
    Action<object> print = Console.WriteLine;

    double a = 20.0;
    double b = 10.0;
    Swap(ref a, ref b);
    print(a == 10.0 && b == 20.0);

		int[] arrayA = new int[5];
		int[] arrayB = new int[3];

		print(Swap1(arrayA, arrayB));

		int[] list = {2, 4, 5, 6, 1, 3, 7};

		print(SwapMinMax(list));
		// print(SwapMinMax(list[6]) == 7);
		
    
  }

public static int SwapMinMax(int[] array)
{

	int temp = 0;
	int max = 0;
	int min = 0;

	for(int i = 0; i < array.Length; i++)
	{
		if(max < array[i])
		{
			max = array[i];
		}
	}

	return max;


}

public static void Swap(ref double a, ref double b)
{
 
   double temp = a;
   a = b;
   b = temp;

}

public static object Swap1(int[] arrayA, int[] arrayB)
{
		if(arrayA.Length == arrayB.Length)
    {

       Console.WriteLine(arrayA.Length);
       Console.WriteLine(arrayB.Length);
       Console.WriteLine((arrayA != arrayB) == true);

    }
    // else if(arrayA.Length == arrayB.Length)
    // {

    //   Console.WriteLine(arrayA.Length);
    //   Console.WriteLine(arrayB.Length);
    //   Console.WriteLine((arrayA == arrayB) == true);

    // }
    else
    {

    	 Console.WriteLine("아무것도 들어있지 않습니다.");

    }
		return null;
	
}

}


// Swap
// 1. double형 Swap(double a, double b)를 작성하세요.
// 2. int[]형 Swap(int[] arrayA, int[] arrayB)를 작성하세요, 배열 사이즈가 서로 다른 경우 호출자에게 알려주세요. // return 사이즈 다른 경우
// 3. Book(멤버가 Title, Price)형 Swap(Book a, Book b)를 작성하세요.
// 4. 하나의 int[]를 주어졌을 때 min, max 값을 서로 SwapMinMax(int[] array)를 작성하세요.
// 5. 근의 공식 구하는 걸 함수로 바꾸기
