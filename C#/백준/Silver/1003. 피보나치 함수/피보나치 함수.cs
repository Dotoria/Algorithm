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
        
        int t = int.Parse(input.ReadLine());
        List<int> zeroes = new List<int>();
        List<int> ones = new List<int>();
        StringBuilder sb = new StringBuilder();
        for (int _ = 0; _ < t; _++)
        {
            int n = int.Parse(input.ReadLine());
            zeroes.Clear();
            ones.Clear();
            for (int i = 0; i < n + 1; i++)
            {
                if (i == 0)
                {
                    zeroes.Add(1);
                    ones.Add(0);
                }
                else if (i == 1)
                {
                    zeroes.Add(0);
                    ones.Add(1);
                }
                else
                {
                    zeroes.Add(zeroes[i-2] + zeroes[i-1]);
                    ones.Add(ones[i-2] + ones[i-1]);
                }
            }
            
            sb.AppendLine("" + zeroes[n] + " " + ones[n]);
        }
        
        result.WriteLine(sb.ToString());
        
        input.Close();
        result.Close();
    }
}