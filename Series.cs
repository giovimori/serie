using System;
using System.Collections.Generic;

public static class Series
{

    public static string[] Slices(string numbers, int sliceLength)
    {
        List<string> retVal = new List<string>();
        if(sliceLength <=0)
        {
            throw new ArgumentException();
        }
        else
        {
        if (numbers.Length >= sliceLength)
        {
            for (int i = 0; i < (numbers.Length - (sliceLength - 1)); i++)
            {
                string s = numbers.Substring(i, sliceLength);
                retVal.Add(s);
            }
        }
        else
        {
            throw new ArgumentException();
        }
        }
        return retVal.ToArray();
    }
    
}








































































