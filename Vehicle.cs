﻿using System;


class Animal
{
    public string Name { get; set; }

    
    public Animal(string name)
    {
        Name = name;
    }
    
    public void Speak()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}


class Dog : Animal
{
    
    public Dog(string name) : base(name)
    {
    }

    
    public void Speak()
    {
        Console.WriteLine($"{Name} barks.");
    }
}




class Program
{
    static void Main()
    {
        
        Dog dog = new Dog("Buddy");
        

        
        dog.Speak();  
        
    }
}
