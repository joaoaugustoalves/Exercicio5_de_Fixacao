using System;

namespace exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
          int num = 0;
            int resultado = 0;

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Tabuada do 1 ao 10: ");
            Console.ResetColor();
            Console.WriteLine();

                
                for (int k = 1; k <= 10; k++) {
                    
                        num = k;                    
                    
                    
                    for (int i = 0; i <= 10; i++)
                    {

                        Console.WriteLine();
                        
                        resultado = i * num;

                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine($"{i} x {num} = {resultado}"); 

                        Console.ResetColor();

                    }
                }
             
              
        }
    }
}
