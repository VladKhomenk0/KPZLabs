using System;
using System.Collections;
using System.Collections.Generic;

public class ExtendedDictionary<T, U, V> : IEnumerable<ExtendedDictionaryElement<T, U, V>>
{
    private readonly List<ExtendedDictionaryElement<T, U, V>> items =
        new List<ExtendedDictionaryElement<T, U, V>>();

    public void Add(T key, U value1, V value2)
    {
        items.Add(new ExtendedDictionaryElement<T, U, V>(key, value1, value2));
    }

    public bool Remove(T key)
    {
        return items.RemoveAll(e => e.Key.Equals(key)) > 0;
    }

    public bool ContainsKey(T key)
    {
        return items.Exists(e => e.Key.Equals(key));
    }

    public bool ContainsValue(U value1, V value2)
    {
        return items.Exists(e => e.Value1.Equals(value1) && e.Value2.Equals(value2));
    }

    public ExtendedDictionaryElement<T, U, V> this[T key]
    {
        get => items.Find(e => e.Key.Equals(key));
    }

    public int Count => items.Count;

    public IEnumerator<ExtendedDictionaryElement<T, U, V>> GetEnumerator() => items.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}