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
        
        string[] condition = input.ReadLine().Split(' ');
        int n = int.Parse(condition[0]);
        int m = int.Parse(condition[1]);
        
        Dictionary<string, int> names = new Dictionary<string, int>();
        for (int i = 0; i < n; i++)
        {
            string line = input.ReadLine();
            names[line] = i;
        }
        
        List<string> sortedNames = new List<string>();
        for (int i = 0; i < m; i++)
        {
            string line = input.ReadLine();
            if (names.Remove(line))
            {
                sortedNames.Add(line);
            }
        }
        
        sortedNames.Sort((a, b) => a.CompareTo(b));
        
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("" + sortedNames.Count);
        for (int i = 0; i < sortedNames.Count; i++)
        {
            sb.AppendLine(sortedNames[i]);
        }
        
        result.WriteLine(sb.ToString());
        
        input.Close();
        result.Close();
    }
}