using System;
public delegate void del_nm(int a,int b);
class del_class
{
	public void sum(int a,int b)
	{
		Console.WriteLine("sum is:"+(a+b));
	}
}
class program
{
	public static void Main()
	{
		del_class d_c=new del_class();
		del_nm obj_del=new del_nm(d_c.sum);
		obj_del(10,20);
		//obj_del.invoke(10,20);
		//d_c.sum(10,20);
		Console.WriteLine();
	}
}