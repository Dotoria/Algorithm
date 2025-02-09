using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public static class Test
{
    public static void Main(string[] args)
    {
        StreamReader reader = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter writer = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        
        int t = int.Parse(reader.ReadLine());
        bool[,] result = new bool[t+1,t+1];
        
        int e = int.Parse(reader.ReadLine());
        for (int _ = 0; _ < e; _++)
        {
            string[] input = reader.ReadLine().Split(' ');
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            
            result[a,b] = true;
            result[b,a] = true;
        }
        
        // 초기설정
        bool[] connected = new bool[t+1];
        List<int> lines = new List<int>();
        for (int j = 2; j <= t; j++)
        {
            if (result[1,j]) lines.Add(j);
        }
        connected[1] = true;
        
        // 반복
        while (true)
        {
            if (lines.Count == 0) break;
            
            List<int> newLines = new List<int>();
            for (int idx = 0; idx < lines.Count; idx++)
            {
                if (connected[lines[idx]]) continue;
                for (int j = 2; j <= t; j++)
                {
                    if (result[lines[idx],j]) newLines.Add(j);
                }
                connected[lines[idx]] = true;
            }
            
            lines = newLines;
        }
        
        int num = 0;
        for (int i = 2; i <= t; i++)
        {
            if (connected[i]) num++;
        }
        
        writer.WriteLine(num.ToString());
        
        reader.Close();
        writer.Close();
    }
}