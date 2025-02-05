using System;
using System.Collections.Generic;
using System.Text;

public static class Test
{
    public static void Main(string[] args)
    {
        int m = int.Parse(Console.ReadLine());
        StringBuilder sb = new StringBuilder();
        List<int> result = new List<int>();
        for (int i = 0; i < m; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            int number;
            switch (input[0])
            {
                case "add":
                    number = int.Parse(input[1]);
                    if (!result.Contains(number))
                    {
                        result.Add(number);
                    }
                    break;
                case "remove":
                    number = int.Parse(input[1]);
                    if (result.Contains(number))
                    {
                        result.Remove(number);
                    }
                    break;
                case "check":
                    number = int.Parse(input[1]);
                    if (result.Contains(number))
                    {
                        sb.AppendLine("1");
                    }
                    else
                    {
                        sb.AppendLine("0");
                    }
                    break;
                case "toggle":
                    number = int.Parse(input[1]);
                    if (result.Contains(number))
                    {
                        result.Remove(number);
                    }
                    else
                    {
                        result.Add(number);
                    }
                    break;
                case "all":
                    result = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};
                    break;
                case "empty":
                    result = new List<int>();
                    break;
                default:
                    break;
            }
        }
        
        Console.WriteLine(sb.ToString());
    }
}