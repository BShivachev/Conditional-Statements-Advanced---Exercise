using System;

namespace _06._Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1= int.Parse(Console.ReadLine());
            double N2= double.Parse(Console.ReadLine());            
            string tool= Console.ReadLine();            
            double result;
            if (tool == "+")
            {
                result = N1 + N2;
                Console.WriteLine(result % 2 == 0 ? $"{N1} + {N2} = {result} - even" : $"{N1} + {N2} = {result} - odd");
            }
            else if (tool == "-")
            {
                result = N1 - N2;
                Console.WriteLine(result % 2 == 0 ? $"{N1} - {N2} = {result} - even" : $"{N1} - {N2} = {result} - odd");
            }
            else if (tool == "*")
            {
                result = N1 * N2;
                Console.WriteLine(result % 2 == 0 ? $"{N1} * {N2} = {result} - even" : $"{N1} * {N2} = {result} - odd");
            }
            else if (tool == "/")
            {                
                result = N1 / N2;
                Console.WriteLine(N2 == 0 ? $"Cannot divide {N1} by zero" : $"{N1} / {N2} = {result:f2}");
               
            }
            else
            {                
                result = N1 % N2;
                    Console.WriteLine(N2 == 0 ? $"Cannot divide {N1} by zero" : $"{N1} % {N2} = {result}");          
            }
                    
                
            
        }
    }
}
