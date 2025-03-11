using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public static class Test
{
    public static void Main(string[] args)
    {
        int m = int.Parse(Console.ReadLine());
        List<int> messi = new List<int>();
        messi.Add(6);
        messi.Add(6 + 8);
        
        int i = 1;
        int idx;
        while (true)
        {
            if (m == messi[i])
            {
                Console.WriteLine("Messi Messi Gimossi");
                return;
            }
            else if (m < messi[i])
            {
                idx = i;
                break;
            }
            else if (m > messi[i])
            {
                messi.Add(messi[i-1] + messi[i]);
            }
            i++;
        }
        
        while (idx > 1)
        {
            if (m > messi[idx-1])
            {
                m -= messi[idx-1];
                idx -= 2;
            }
            else
            {
                idx -= 1;
            }
        }
        
        string MessiString = "Messi Gimossi";
        if (m == 14 || MessiString[m-1] == ' ') Console.WriteLine("Messi Messi Gimossi");
        else Console.WriteLine(MessiString[m-1].ToString());
    }
}