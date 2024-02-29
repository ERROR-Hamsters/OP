using System;
using System.Collections.Generic;

public class hash_table<TKey, TValue>
{
    private const int default_capacity = 10;
    private LinkedList<KeyValuePair<TKey, TValue>>[] container;

    public hash_table()
    {
        container = new LinkedList<KeyValuePair<TKey, TValue>>[default_capacity];
    }

    public hash_table(int initial_capacity)
    {
        container = new LinkedList<KeyValuePair<TKey, TValue>>[initial_capacity];
    }

    private int get_index(TKey key)
    {
        int hashCode = key.GetHashCode();
        int index = Math.Abs(hashCode) % container.Length;
        return index;
    }

    public void add(TKey key, TValue value)
    {
        int index = get_index(key);

        if (container[index] == null)
        {
            container[index] = new LinkedList<KeyValuePair<TKey, TValue>>();
        }

        foreach (var pair in container[index])
        {
            if (pair.Key.Equals(key))
            {
                throw new ArgumentException("There is already an element with the same key in the dictionary");
            }
        }

        container[index].AddLast(new KeyValuePair<TKey, TValue>(key, value));
    }

    public void remove(TKey key)
    {
        int index = get_index(key);

        if (container[index] == null)
        {
            throw new KeyNotFoundException("The specified key was not found in the dictionary");
        }

        bool found = false;
        LinkedListNode<KeyValuePair<TKey, TValue>> current_node = container[index].First;

        while (current_node != null)
        {
            if (current_node.Value.Key.Equals(key))
            {
                container[index].Remove(current_node);
                found = true;
                break;
            }

            current_node = current_node.Next;
        }

        if (!found)
        {
            throw new KeyNotFoundException("The specified key was not found in the dictionary.");
        }
    }

    public TValue get(TKey key)
    {
        int index = get_index(key);

        if (container[index] == null)
        {
            throw new KeyNotFoundException("The specified key was not found in the dictionary.");
        }

        foreach (var pair in container[index])
        {
            if (pair.Key.Equals(key))
            {
                return pair.Value;
            }
        }

        throw new KeyNotFoundException("The specified key was not found in the dictionary.");
    }

    public bool contains(TKey key)
    {
        int index = get_index(key);

        if (container[index] == null)
        {
            return false;
        }

        foreach (var pair in container[index])
        {
            if (pair.Key.Equals(key))
            {
                return true;
            }
        }

        return false;
    }

    public void Clear()
    {
        Array.Clear(container, 0, container.Length);
    }

    public int size()
    {
        int count = 0;

        foreach (var bucket in container)
        {
            if (bucket != null)
            {
                count += bucket.Count;
            }
        }

        return count;
    }
}

public class Spell_Checker
{
    public static void Main()
    {
        hash_table<string, bool> dictionary = new hash_table<string, bool>();


        dictionary.add("name", true);
        dictionary.add("clouds", true);
        dictionary.add("world", true);
        dictionary.add("sky", true);
        dictionary.add("summer", true);
        dictionary.add("math", true);
        dictionary.add("life", true);
        dictionary.add("heart", true);
        dictionary.add("green", true);
        dictionary.add("pizza", true);
        dictionary.add("diamond", true);
        dictionary.add("music", true);
        dictionary.add("ocean", true);
        dictionary.add("word1", true);
        dictionary.add("moon", true);
        dictionary.add("cat", true);
        dictionary.add("apple", true);
        dictionary.add("dog", true);
        dictionary.add("notebook", true);
        dictionary.add("star", true);
        dictionary.add("key", true);
        dictionary.add("egg", true);
        dictionary.add("ball", true);
        dictionary.add("wi-fi", true);
        dictionary.add("battery", true);
        dictionary.add("monitor", true);
        dictionary.add("smartphone", true);
        dictionary.add("cable", true);
        dictionary.add("laptop", true);
        dictionary.add("keyboard", true);
        dictionary.add("mouse", true);
        dictionary.add("water", true);
        dictionary.add("pen", true);
        dictionary.add("friend", true);
        dictionary.add("pencil", true);
        dictionary.add("coin", true);
        dictionary.add("paper", true);
        dictionary.add("mother", true);
        dictionary.add("dad", true);
        dictionary.add("movie", true);
        dictionary.add("calculator", true);
        dictionary.add("folder", true);
        dictionary.add("paint", true);
        dictionary.add("camera", true);
        dictionary.add("love", true);
        dictionary.add("sad", true);
        dictionary.add("Ukraine", true);
        dictionary.add("lines", true);
        dictionary.add("death", true);
        dictionary.add("war", true);



        while (true)
        {
            Console.Write("Введiть слово для перевiрки  (Введiть exit для виходу): ");
            string word = Console.ReadLine();

            if (word == "exit")
            {
                break;
            }

            if (dictionary.contains(word.ToLower()))
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("Wrong Spelling");
            }
        }
    }
}
