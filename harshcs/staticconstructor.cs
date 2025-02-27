using System;
namespace Class1
{
    class program
    {
        static int a;
        static program()
        {
            a = 10;
            Console.WriteLine("Hello");
        }
        static void Main(string[] args)
        {
            program p=new program();
            Console.WriteLine("Value of a: " + a);
        }
    }
}
