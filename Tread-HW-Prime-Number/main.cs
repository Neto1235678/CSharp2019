using System;
using System.Threading;
using System.Threading.Tasks;


class MainClass {
  public static void Main (string[] args) {
			GetNumberOfPrime();
			Console.ReadLine();
		 
  }

	public static async void GetNumberOfPrime() {

		int a = await Task<int>.Run( () => {
			Thread.Sleep(100);
			Console.WriteLine("1 task");
			return 100;
		});
		int b = await Task<int>.Run( () => { // 내부에 await 라는 함수를 가지고 있다. 이 함수가 async하다는 것을 알려준다.
			Thread.Sleep(100);
			Console.WriteLine("2 task"); // async 하다는 것은 중간에 멈출 수 있다.
			return 200 + a;
		});
		int result = await Task<int>.Run( () => {
			Thread.Sleep(100);
			Console.WriteLine("3 task");
			return 300 + b;
		});
	//	Console.WriteLine(result == 600);

	}

	public static int AddTask(int a, int b) {

				if( a != 2 && a % 2 == 0 ) {

				// for( a = 2; a <= b; a++) {

				// }
			
			}
				return 0;
	}
}


// 자기랑 1 빼고는 나눌 수 없는 수
// 짝수는 2 빼고는 다 실수가 아니다.
// 2부터 시작해서 해당 숫자까지 다 나눠서 찾기
// 소수 168개 나온다
// p.AddTask(0, 11) 
// p.AddTask(12, 20)
// p.AddTask(21, 1000)
//int n = p.GetNumberOfPrime();

// Task.WhenAll

// async 및 await를 사용한 비동기 프로그래밍