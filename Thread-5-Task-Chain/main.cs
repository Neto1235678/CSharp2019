using System;
using System.Threading;
using System.Threading.Tasks;

class MainClass {
  public static void Main (string[] args) {
		Task<string> taskChain = Task<int>.Run( () => { // 바로 실행.
			Console.WriteLine("1 task");
			Thread.Sleep(100);
			return 100;
		}).ContinueWith(task => {
			Console.WriteLine();
			Console.WriteLine(task.Result); // 리조트 나올 때 까지 블락.
			Console.WriteLine("2 task");
			Thread.Sleep(100);
			return 200;
		}).ContinueWith(task => {
			Console.WriteLine();
			Console.WriteLine(task.Result);
			Console.WriteLine("3 task");
			Thread.Sleep(100);
			return 300.ToString();
		});

		Console.WriteLine("in Main");
		Console.WriteLine( taskChain.Result == "300");
  }
}