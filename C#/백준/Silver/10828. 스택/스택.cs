using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public static class Test
{
    public static void Main(string[] args)
    {
        StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter result = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        
        StringBuilder sb = new StringBuilder();
        int n = int.Parse(input.ReadLine());
        
        List<int> stack = new List<int>();
        for (int _ = 0; _ < n; _++)
        {
            string[] line = input.ReadLine().Split(' ');
            switch (line[0])
            {
                case "push":
                    stack.Add(int.Parse(line[1]));
                    break;
                case "pop":
                    if (stack.Count == 0) sb.AppendLine("-1");
                    else
                    {
                        sb.AppendLine(stack[^1].ToString());
                        stack.RemoveAt(stack.Count - 1);
                    }
                    break;
                case "size":
                    sb.AppendLine(stack.Count.ToString());
                    break;
                case "empty":
                    sb.AppendLine(stack.Count == 0 ? "1" : "0");
                    break;
                case "top":
                    sb.AppendLine(stack.Count == 0 ? "-1" : stack[^1].ToString());
                    break;
            }
        }
        
        result.WriteLine(sb.ToString());
        
        input.Close();
        result.Close();
    }
}