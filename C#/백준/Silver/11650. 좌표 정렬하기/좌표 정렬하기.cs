using System;
using System.Collections.Generic;
using System.Text;

public static class Test
{
    public static void Main(string[] args)
    {
        int t = int.Parse(Console.ReadLine());
        List<Coords> result = new List<Coords>();
        StringBuilder sb = new StringBuilder();
        for (int _ = 0; _ < t; _++)
        {
            string input = Console.ReadLine();
            int x = int.Parse(input.Split(' ')[0]);
            int y = int.Parse(input.Split(' ')[1]);
            
            result.Add(new Coords(x, y));
        }
        
        result.Sort((coordA, coordB) =>
                    {
                        if (coordA.X != coordB.X) return coordA.X.CompareTo(coordB.X);
                        return coordA.Y.CompareTo(coordB.Y);
                    });
        
        for (int k = 0; k < result.Count; k++)
        {
            sb.AppendLine(result[k].ToString());
        }
        
        Console.WriteLine(sb.ToString());
    }
    
    public class Coords
    {
        public Coords(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; }
        public int Y { get; }

        public override string ToString() => $"{X} {Y}";
    }
}