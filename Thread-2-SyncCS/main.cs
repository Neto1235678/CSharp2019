using System;
using System.Threading;

// lock에 사용되면 안 되는 object
// 1. this
// 2. string
// 3. GetType(): Type 

class Counter {
	public int Count { get; set; }
	readonly object thisLock = new object(); // 체크
	public void Increase() {
		// Crltical Section(CS)
		lock (thisLock) { // 체크
		Count++; // Thread로 동시에 한 번만 건드리도록 설정. 크리티컬 섹션
		}
	}
}

class MainClass {
  public static void Main (string[] args) {
		Counter c = new Counter();
		Thread t1 = new Thread(c.Increase);
		Thread t2 = new Thread(c.Increase);
		t1.Start();
		t2.Start();

		Console.ReadLine();
  }
}