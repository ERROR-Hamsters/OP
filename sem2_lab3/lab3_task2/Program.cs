using System;
using System.Collections;
using System.Collections.Generic;

public class RandomizedQueue<Item> : IEnumerable<Item>
{
    /* test
        randomized_Queue.Enqueue(6);
        randomized_Queue.Enqueue(2);
        randomized_Queue.Enqueue(3);
        randomized_Queue.Enqueue(4);
        randomized_Queue.Enqueue(5);
        randomized_Queue.Enqueue(17);
        
        randomized_Queue.Enqueue(1);
        randomized_Queue.Enqueue(2);
        randomized_Queue.Enqueue(3);
        randomized_Queue.Enqueue(4);
        randomized_Queue.Enqueue(7);
        randomized_Queue.Enqueue(9);
        
        
        
        
     */
    private Item[] items;
    private int size;
    private Random random;

    // construct an empty randomized queue
    public RandomizedQueue()
    {
        items = new Item[1];
        size = 0;
        random = new Random();
    }

    // is the randomized queue empty?
    public bool IsEmpty()
    {
        return size == 0;
    }

    // return the number of items on the randomized queue
    public int Size()
    {
        return size;
    }

    // add the item
    public void Enqueue(Item item)
    {
        if (item == null)
        {
            throw new ArgumentNullException("item");
        }

        if (size == items.Length)
        {
            Resize(2 * items.Length);
        }

        items[size++] = item;
    }

    // remove and return a random item
    public Item Dequeue()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("RandomizedQueue is empty");
        }

        int randomIndex = random.Next(size);
        Item item = items[randomIndex];

        items[randomIndex] = items[size - 1];
        items[size - 1] = default(Item);
        size--;

        if (size > 0 && size == items.Length / 4)
        {
            Resize(items.Length / 2);
        }

        return item;
    }

    // return a random item (but do not remove it)
    public Item Sample()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("RandomizedQueue is empty");
        }

        int randomIndex = random.Next(size);
        return items[randomIndex];
    }

    // return an independent iterator over items in random order
    public IEnumerator<Item> GetEnumerator()
    {
        Item[] shuffledItems = new Item[size];
        Array.Copy(items, shuffledItems, size);
        Shuffle(shuffledItems);

        foreach (Item item in shuffledItems)
        {
            yield return item;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    private void Resize(int capacity)
    {
        Item[] resizedItems = new Item[capacity];
        Array.Copy(items, resizedItems, size);
        items = resizedItems;
    }

    private void Shuffle(Item[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n; i++)
        {
            int r = i + random.Next(n - i);
            Item temp = array[r];
            array[r] = array[i];
            array[i] = temp;
        }
    }
}

// unit testing (required)
public class Program
{
    public static void Main(string[] args)
    {
        RandomizedQueue<int> randomized_Queue = new RandomizedQueue<int>();
        randomized_Queue.Enqueue(1);
        randomized_Queue.Enqueue(2);
        randomized_Queue.Enqueue(3);
        randomized_Queue.Enqueue(4);
        randomized_Queue.Enqueue(7);
        randomized_Queue.Enqueue(9);


        Console.WriteLine("Queue size: " + randomized_Queue.Size());

        foreach (int item in randomized_Queue)
        {
            Console.WriteLine("Item: " + item);
        }

        Console.WriteLine("Sample item: " + randomized_Queue.Sample());

        int removedItem = randomized_Queue.Dequeue();
        Console.WriteLine("Removed item: " + removedItem);
        Console.WriteLine("Queue size after dequeue: " + randomized_Queue.Size());
        
        /* test 
         Queue size: 6
        Item: 17
        Item: 6
        Item: 2
        Item: 5
        Item: 4
        Item: 3
        Sample item: 4
        Removed item: 2
        Queue size after dequeue: 5


         */
    }
}
