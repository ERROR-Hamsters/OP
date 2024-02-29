using System;

// базовий клас Vessel
abstract class Vessel
{
    public abstract void PrepareToMovement();
    public abstract void Move();
}

// похідний клас SailingVessel
class SailingVessel : Vessel
{
    public override void PrepareToMovement()
    {
        Console.WriteLine("Підготовка парусника до руху");
    }

    public override void Move()
    {
        Console.WriteLine("Парусник вирушає в море");
    }
}

// похідний клас Submarine
class Submarine : Vessel
{
    public override void PrepareToMovement()
    {
        Console.WriteLine("Підготовка підводного човна до руху");
    }

    public override void Move()
    {
        Console.WriteLine("Підводний човен пірнає");
    }
}


class Program
{
    static void Main(string[] args)
    {
        // створення об'єкту класу SailingVessel
        Vessel sailingVessel = new SailingVessel();
        sailingVessel.PrepareToMovement();
        sailingVessel.Move();

        Console.WriteLine();

        // створення об'єкту класу Submarine
        Vessel submarine = new Submarine();
        submarine.PrepareToMovement();
        submarine.Move();

        Console.ReadLine();
    }
}