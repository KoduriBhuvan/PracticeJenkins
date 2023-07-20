using System;

class Program
{
    static void Main()
    {
        void greet()
        {
            var name = Console.ReadLine();
            Console.WriteLine("hi  " + name);
        }
        int add(int x,int y)
        {
            return x + y;
        }
        greet();
        Console.WriteLine(add(3, 5));
    }
}