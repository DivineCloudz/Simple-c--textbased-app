using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        while(true){
            
            Console.ReadKey();
            Console.Clear();
            
            Console.WriteLine("Welcome to the Arora app\n\n1. Add two numbers.\n2. Subtract two numbers.\n3. Exit.");
            int user = Convert.ToInt32(Console.ReadLine());
            
            if (user == 1){
                
                Console.Write("Enter the first number: ");
                float a = float.Parse(Console.ReadLine());
                
                Console.Write("Enter your second number: ");
                float b = float.Parse(Console.ReadLine());
                
                Console.WriteLine($"The sum of your number is {a + b}");
                
            }
            
            else if (user == 2){
                
                Console.Write("Enter the first number: ");
                float a = float.Parse(Console.ReadLine());
                
                Console.Write("Enter your second number: ");
                float b = float.Parse(Console.ReadLine());
                
                Console.WriteLine($"The sum of your number is {a - b}");
                
            }
            
            else{
                
                Console.WriteLine("Thanks for using our app :)");
                break;
                
            }
            
            
        }
    }
}
