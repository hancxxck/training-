using System;

namespace FizzBuzz2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            {
                string fizz = "Fizz";
                string buzz = "Buzz";
                int j = 0; 
                for (int i = 1; i <= 100; i++)
                {
                   
                    string results = "";
                    if (i % 3 == 0 && i % 5 == 0)
                    { Console.WriteLine("FizzBuzz"); }

                    if (i % 3 == 0)
                    { Console.WriteLine(fizz); }

                    if (i % 5 == 0)
                    { Console.WriteLine(buzz); }
                    
                    while (j > 0)
                       if (j % 10 == 3)
                            { Console.WriteLine(fizz); }
                       if (j % 10 == 5)
                            { Console.WriteLine(buzz); }


                    else Console.WriteLine(i);
                    if (results.Length == 0) results = i.ToString();
                }
            }
  
        }      
       
    }
}
