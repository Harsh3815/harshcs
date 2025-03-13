using System;
class demo
{
	private int a;
	public int pr_am
	{
		set
		{
			a=value;
			Console.WriteLine("value of A in set:"+a);
		}
		get
		{
			return a;
		}
	}
}
class main_cls
{
	public static void Main()
	{
		demo d=new demo();
		d.pr_am=10;
		Console.WriteLine("value of A in main:"+d.pr_am);
	}
}