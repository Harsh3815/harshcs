using System;
interface intr1
{
	void abc();
}
interface intr2
{
	void xyz();
}
class demo:intr1,intr2
{
	public void fun()
	{
		Console.WriteLine("fun");
	}
	public void abc()
	{
		Console.WriteLine("abc");
	}
	public void xyz()
	{
		Console.WriteLine("xyz");
	}	
}
class main_cls
{
	public static void Main()
	{
		demo d=new demo();
		d.fun();
		d.abc();
		d.xyz();
	}
}