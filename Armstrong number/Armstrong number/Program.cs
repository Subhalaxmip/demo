using System;

namespace Armstrong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int a ,b,sum=0,temp;
            Console.WriteLine("enter number");
            a=int.Parse(Console.ReadLine());
            temp = a;

            while (a > 0)
            { 
            b = a % 10;
            sum = sum + (b * b * b);
            a = a / 10;
            }
            if(temp==sum)
            {
                Console.WriteLine("armstrong number");
            }
            else
            {
                Console.WriteLine("not an armstrong number");
            }
            Console.ReadLine();

        }
    }
}
