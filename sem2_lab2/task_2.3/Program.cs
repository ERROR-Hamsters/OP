using System;

// інтерфейс IVessel
interface IVessel
{
    void PrepareToMovement();
    void Move();
}

// клас SailingVessel
class SailingVessel : IVessel
{
    public void PrepareToMovement()
    {
        Console.WriteLine("Підготовка парусника до руху");
    }

    public void Move()
    {
        Console.WriteLine("Парусник вирушає в море");
    }
}

// клас Submarine
class Submarine : IVessel
{
    public void PrepareToMovement()
    {
        Console.WriteLine("Підготовка підводного човна до руху");
    }

    public void Move()
    {
        Console.WriteLine("Підводний човен пірнає");
    }
}


class Program
{
    static void Main(string[] args)
    {
        // створення об'єкту класу SailingVessel
        IVessel sailingVessel = new SailingVessel();
        sailingVessel.PrepareToMovement();
        sailingVessel.Move();

        Console.WriteLine();

        // створення об'єкту класу Submarine
        IVessel submarine = new Submarine();
        submarine.PrepareToMovement();
        submarine.Move();

        Console.ReadLine();
    }
}