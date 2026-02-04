using System;
using System.Collections.Generic;

public static class ArrayExtensions
{
    public static int CountValue<T>(this T[] array, T value)
        where T : IEquatable<T>
    {
        if (array == null) return 0;

        int count = 0;
        foreach (var item in array)
            if (item.Equals(value)) count++;

        return count;
    }

    public static T[] Unique<T>(this T[] array)
        where T : IEquatable<T>
    {
        if (array == null) return Array.Empty<T>();

        HashSet<T> unique = new List<T>();

        foreach (var item in array)
        {
            if (!unique.Contains(item))
                unique.Add(item);
        }

        return unique.ToArray();
    }
}