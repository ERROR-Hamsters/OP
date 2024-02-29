using System;
using System.Collections;
using System.Collections.Generic;

public interface IIterator<T>
{
    bool HasNext();
    T Next();
}
/* test:    deque.addFirst(0);
            deque.addLast(8);
            deque.addFirst(3);
            deque.addLast(4);
            deque.addFirst(9);
            deque.addLast(6); */ 
public class Deque<Item> : IIterator<Item>, IEnumerable<Item>
{
    private Node head; // front 
    private Node tail; // back 
    private int count; // number of items in deque

    private class Node
    {
        public Item item;
        public Node following;
        public Node preceding;
    }

    // construct an empty deque
    public Deque()
    {
        head = null;
        tail = null;
        count = 0;
    }

    // is the deque empty?
    public bool isEmpty()
    {
        return count == 0;
    }

    // return the number of items on the deque
    public int size()
    {
        return count;
    }

    // add the item to the front
    public void addFirst(Item item)
    {
        if (item == null)
            throw new ArgumentNullException("item");

        Node new_node = new Node
        {
            item = item,
            following = head,
            preceding = null
        };

        if (isEmpty())
        {
            tail = new_node;
        }
        else
        {
            head.preceding = new_node;
        }

        head = new_node;
        count++;
    }

    // add the item to the back
    public void addLast(Item item)
    {
        if (item == null)
            throw new ArgumentNullException("item");

        Node new_Node = new Node
        {
            item = item,
            following = null,
            preceding = tail
        };

        if (isEmpty())
        {
            head = new_Node;
        }
        else
        {
            tail.following = new_Node;
        }

        tail = new_Node;
        count++;
    }

    // remove and return the item from the front
    public Item RemoveFirst()
    {
        if (isEmpty())
            throw new InvalidOperationException("Deque is empty");

        Item item = head.item;
        head = head.following;
        count--;

        if (isEmpty())
        {
            tail = null;
        }
        else
        {
            head.preceding = null;
        }

        return item;
    }

    // remove and return the item from the back
    public Item RemoveLast()
    {
        if (isEmpty())
            throw new InvalidOperationException("Deque is empty");

        Item item = tail.item;
        tail = tail.preceding;
        count--;

        if (isEmpty())
        {
            head = null;
        }
        else
        {
            tail.following = null;
        }

        return item;
    }

    // return an iterator over items in order from front to back
    public IEnumerator<Item> GetEnumerator()
    {
        return new DequeIterator(this);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    // Iterator class for Deque
    private class DequeIterator : IEnumerator<Item>
    {
        private Deque<Item> deque;
        private Node current;

        public DequeIterator(Deque<Item> deque)
        {
            this.deque = deque;
            current = null;
        }

        public Item Current
        {
            get { return current.item; }
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }

        public bool MoveNext()
        {
            if (current == null)
            {
                current = deque.head;
            }
            else
            {
                current = current.following;
            }

            return current != null;
        }

        public void Reset()
        {
            current = null;
        }

        public void Dispose()
        {
            // Not needed in this case
        }
    }

    public bool HasNext()
    {
        return !isEmpty();
    }

    public Item Next()
    {
        if (isEmpty())
            throw new InvalidOperationException("No more elements in the deque");

        return RemoveFirst();
    }
}

public class Program
{
    public static void Main()
    {
        // Create a Deque of integers
        Deque<int> deque = new Deque<int>();
        deque.addFirst(1);
        deque.addLast(2);
        deque.addFirst(3);
        deque.addLast(4);
        deque.addFirst(9);
        deque.addLast(6);


        Console.WriteLine("Size: " + deque.size());
        
        // Iterate over the items in the deque
        foreach (int item in deque)
        {
            Console.WriteLine(item);
        }
        
        Console.WriteLine("Removed first: " + deque.RemoveFirst());
        Console.WriteLine("Removed last: " + deque.RemoveLast());

        Console.WriteLine("Size: " + deque.size());

        foreach (int item in deque)
        {
            Console.WriteLine(item);
        }
        
    }
}
/* test:
 
Size: 6
9
3
0
8
4
6
Removed first: 9
Removed last: 6
Size: 4
3
0
8
4
       
 */ 