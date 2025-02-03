using System;
using System.Collections.Generic;
using System.Text;

public static class Test
{
    public static void Main(string[] args)
    {
        int t = int.Parse(Console.ReadLine());
        for (int i = 0; i < t; i++)
        {
            int k = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            
            Console.WriteLine("" + SumPeople(k, n));
        }
    }
    
    public static int SumPeople(int a, int b)
    {
        int[,] people = new int[a+1, b+1];
        for (int j = 1; j <= b; j++)
        {
            people[0, j] = j;
        }
        
        for (int i = 1; i <= a; i++)
        {
            for (int j = 1; j <= b; j++)
            {
                if (j == 1) people[i, j] = 1;
                else people[i, j] = people[i-1, j] + people[i, j-1];
            }
        }
        
        return people[a, b];
    }
}
