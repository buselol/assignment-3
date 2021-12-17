using System;
class Program
{
    public static void Main(string[] args)







    {

        Console.WriteLine("Enter the numbr ");
        int n = Convert.ToInt32(Console.ReadLine());

        
        
        
        
        
        
        bool[] prime = new bool[n + 1]; 
        for (int i = 2; i <= n; i++) prime[i] = true;

        
        
        
        
        
        int limit = (int)Math.Ceiling(Math.Sqrt(n));

        for (int i = 2; i <= limit; i++)
            if (prime[i])
                for (int j = i * i; j <= n; j += i)
                    prime[j] = false;

        Console.WriteLine("Prime Numbers ", n);

        for (int i = 0; i <= n; i++)
            if (prime[i])
                Console.WriteLine(i);
    }

}
