using System;
class person
{
	public string name{get;set;}
}
class program
{
	static void Main()
	{
		person myjob=new person();
		myjob.name="abc";
		Console.WriteLine(myjob);
	}
}