using System;
using System.Threading;
using System.Threading.Tasks;


class MainClass {
  public static void Main (string[] args) {
			Chain();
			Console.ReadLine();
  }

	public static async void Chain() {
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
		Console.WriteLine(result == 600);
	}
}

// 