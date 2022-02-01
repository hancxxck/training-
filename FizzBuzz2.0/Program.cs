using System;

namespace FizzBuzz2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            {
                int j = 0;
                for (int i = 1; i <= 100; i++)
                {
                    
                    string results = "";
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }

                    else if (i % 3 == 0)
                    { 
                        Console.WriteLine("Fizz");
                    }

                    else if (i % 5 == 0)
                    { 
                        Console.WriteLine("Buzz");
                    }
                   

                    else Console.WriteLine(i);
                    if (results.Length == 0) results = i.ToString();

                    bool fizz;
                    bool buzz;
                    while (j > 0)
                        if (j % 10 == 3)
                        {
                            fizz = true;
                            Console.WriteLine("Fizz");
                        }
                        if (j % 10 == 5)
                        {
                        buzz = true;
                        Console.WriteLine("Buzz");
                        }
                }
            }
  
        }      
       
    }
}
