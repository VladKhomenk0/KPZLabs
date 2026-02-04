using System;

public static class StringExtensions
{
    public static string ReverseString(this string str)
    {
        if (str == null) return null;
        char[] arr = str.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }

    public static int CountChar(this string str, char c)
    {
        if (str == null) return 0;
        int count = 0;
        foreach (var ch in str)
            if (ch == c) count++;
        return count;
    }
}