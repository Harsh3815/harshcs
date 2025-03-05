using System;
class person
{
	public void display()
	{
		Console.WriteLine("1st calling");
	}
	public void display(int a,float b)
	{
		Console.WriteLine("3rd calling"+a+b);
	}
	/*public void display(float b,int a)
	{
		Console.WriteLine("2nd calling");
	}*/
}
class demo
{
	public static void Main(String[] args)
	{
		Console.WriteLine("hii");
		person v1=new person();
		v1.display();
		v1.display(10,1.5);
		//v1.display(1.5,2);
		Console.WriteLine("hello");
	}	
}