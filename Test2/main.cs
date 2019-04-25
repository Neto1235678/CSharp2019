using System;

class MainClass {
  public static void Main (string[] args) {

		Circle o = new Circle(); // o 가 인스턴트

		o.set_Pi(3.14159);
		double piValue = o.get_Pi();

		Console.WriteLine(piValue);

}

class Circle { 

	double pi = 3.14; //  멤버변수

	public void set_Pi(double value) // 메소드
		{
			n as string // 멤버변수
			pi = value;
		}

	public double get_Pi()
		{
			return pi;
		}
	} 
}