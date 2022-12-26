using System;
using System.Linq;
using System.Collections.Generic;

namespace HelloWold
{
    public static class Program 
    {         
        public static void Main()
        {
           	Console.WriteLine("Enter the first number");
			int start =int.Parse(Console.ReadLine());
			Console.WriteLine("Enter the second number");
			int end =int.Parse(Console.ReadLine());
			
			
	     	int a =0;
			for(int i=start; i<=end; i++)
			{
				for(int q=1; q<=i; q++)
				{
					if(i%q==0)
					a++;
				}
				if(a==2)
				{
					Console.WriteLine(i + "  is prime number");
					a=0;
				}
				else
				{
					a=0;
					continue;
				}
			}
        }
    }
}