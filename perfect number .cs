using System;
using System.Linq;
using System.Collections.Generic;

namespace Salah
{
    public class Mohamed 
    {         
         public static void Main()
        {
        	
            int i,y,sum=0;
            Console.WriteLine("Enter the first number");
			int start =int.Parse(Console.ReadLine());
			Console.WriteLine("Enter the second number");
			int end =int.Parse(Console.ReadLine());
			
			sum=0;
			
				for( i=start; i<=end; i++)
			{
				for( y=1; y<=end; y++)
				{
					if(y<i)
					{
						if(i%y==0)
						sum = sum + y;
					}
				}
				if(sum==i)
				{
					Console.WriteLine(i + "   is perfect number");
				}
			    
				sum =0;
			}
			return;
			

        }

    }
}