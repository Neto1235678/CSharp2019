//magi82.github.io/process-thread/

using System;
using System.Threading;

class MainClass {
  public static void Main (string[] args) {
		Action<object> print = Console.WriteLine;
		Console.WriteLine("Thread ID: " + Thread.CurrentThread.ManagedThreadId); // 현재 실행중인 스레드 아이디를 가져온다. 보통은 1, 2, 3, 4 번 순서
  
		Thread t = new Thread(Todo);
		print("before: " + t.ThreadState); // 스타트 상태 (대기)

		t.Start();
		print("after: " + t.ThreadState); // 러닝 상태 (실행)


		// delegate void ThreadStart();
		// Thread t2 = new Thread(new ThreadStart(Todo)); // 델리게이터 만드는 법으로 생성
		// t2.Start();

		t.Join(); // 메인 쓰레드에서 합리화 할 때 까지 대기하라.
		// Console.ReadLine();

		print("end: " + t.ThreadState); // 마지막 상태 (끝남)

	}
	
	static void Todo() {
		Thread.Sleep(500); // 0.5s
		Console.WriteLine("Todo: " + Thread.CurrentThread.ManagedThreadId);
	}
}