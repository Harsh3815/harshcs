using System;
class person
{
	public void display()
	{
		Console.WriteLine("called");
	}
	public static void display2()
	{
		Console.WriteLine("called");
	}
}
class xyz:person
{
	public void fun()
	{
		Console.WriteLine("xyz");
	}
}
class demo
{
	public static void Main()
	{
		Console.WriteLine("hii");
		xyz x1=new xyz();
		x1.display();
		//x1.display2();
		x1.fun();
		Console.WriteLine("hello");
	}
		
}
