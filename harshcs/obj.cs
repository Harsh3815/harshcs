using System;
public class student 
{
	int id;
	string name;
	public static void Main(String[]args)
	{
		student s1=new student();
		s1.id=101;
		s1.name="hello";
		Console.WriteLine(s1.id);
		Console.WriteLine(s1.name);
	}
}