using System;

namespace q53.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //part a
            int x=20;
            int y=35;
            x= y++ + x++;
            y+ ++y + ++x;
            Console.Write(x);
            Console.Write(y);

            //part b
            int x=10;
            int y=15;
            x=x++;
            y=++y;
            console.Write(x);
            Console.Write(y);

            //part c
            int a=10;
            a++;
            console.Write(a);

            //part d
            int a=10;
            Console.Write(a++);
        }
    }
}
