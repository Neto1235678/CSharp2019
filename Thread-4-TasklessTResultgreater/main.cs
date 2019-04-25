using System;
using System.Threading;
using System.Threading.Tasks;

class MainClass {
  public static void Main (string[] args) {
		Task<string> task = new Task<string>( () => { // Func<string> d;
			Thread.Sleep(100);
			Console.WriteLine("in Task");
			return "Task reuslt";
		});
		task.Start();
		Console.WriteLine("in Main");
	
		Console.WriteLine( task.Result == "Task reuslt"); // 메인 스레드 블락 된다.  받아볼 때 까지
 // 네트워크는 대부분 언씽크로 처리한다.
  }
}