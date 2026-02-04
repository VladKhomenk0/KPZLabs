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
        return items.RemoveAll(e =>
            EqualityComparer<T>.Default.Equals(e.Key, key)) > 0;
    }

    public bool ContainsKey(T key)
    {
        return items.Exists(e =>
            EqualityComparer<T>.Default.Equals(e.Key, key));
    }

    public bool ContainsValue(U value1, V value2)
    {
        return items.Exists(e =>
            EqualityComparer<U>.Default.Equals(e.Value1, value1) &&
            EqualityComparer<V>.Default.Equals(e.Value2, value2));
    }

    public ExtendedDictionaryElement<T, U, V> this[T key]
    {
        get => items.Find(e =>
            EqualityComparer<T>.Default.Equals(e.Key, key));
    }

    public int Count => items.Count;

    public IEnumerator<ExtendedDictionaryElement<T, U, V>> GetEnumerator() => items.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}