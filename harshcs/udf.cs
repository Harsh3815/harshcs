using System;
class xyz
{
	public void fun()
	{
		Console.WriteLine("udf");
	}
	public static void Main()
	{
		xyz x=new xyz();
		x.fun();
		//fun();
		Console.WriteLine("hello");
	}
}