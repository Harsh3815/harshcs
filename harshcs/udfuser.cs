using System;
class xyz
{
	public void fun()
	{
		int a = Convert.ToInt32(Console.ReadLine()); 
		int b = Convert.ToInt32(Console.ReadLine());
		int c=a+b;
		Console.WriteLine("sum:"+c);
	}
	public static void Main()
	{
		xyz s=new xyz();
		s.fun();
	}
}