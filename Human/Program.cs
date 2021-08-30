using System;

namespace Human
{
    class Human
{
    // Fields for Human
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    private int health;

    public int Health
    {
    // add a public "getter" property to access health
        get {return health;}
    }

    // Add a constructor that takes a value to set Name, and set the remaining fields to default values
    public Human(string name)
    {
        Name = name;
        Strength = 3;
        Intelligence = 3;
        Dexterity = 3;
        health = 100;
    }
    // Add a constructor to assign custom values to all fields
    public Human(string name, int strength, int intelligence, int dexterity)
    {
        Name = name;
        Strength = strength;
        Intelligence = intelligence;
        Dexterity = dexterity;
        // Health = health;
        }
    // Build Attack method
    public void Attack(Human target)
    {
        Human enemy = target as Human;
        if(enemy == null)
        {
            Console.WriteLine("Can't Attack");
        }
        // else
        // {
        //     enemy.health -= strength * 5;
        // }
    }
}
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


        }
    }
}
