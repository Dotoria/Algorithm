using System;
using System.Collections.Generic;
using System.Text;

public static class Test
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split(' ');
        List<int> result = new List<int>();
        for (int i = 0; i < n; i++)
        {
            result.Add(int.Parse(input[i]));
        }
        
        result.Sort((a, b) => a.CompareTo(b));
        int sum = result[0];
        for (int i = 1; i < n; i++)
        {
            result[i] += result[i-1];
            sum += result[i];
        }
        
        Console.WriteLine("" + sum);
    }
}