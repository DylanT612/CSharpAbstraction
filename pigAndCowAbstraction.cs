/*
I certify, that this computer program submitted by me is all of my own work.
Signed: Dylan Theis 6/1/2024

Author: Dylan Theis
Date: Summer 2024
Class: CSC330
Project: Abstract classes using C#
Description: Lesson 7 Assignment making a pig and cow both eat and make noise
 */

using System;
using System.Collections.Generic;

// Abstract base class farm animal
abstract class FarmAnimal {
    // Abstract method MakeNoise that sub classes will override
    public abstract void MakeNoise();

    // Since allsubclass can use this a concrete method is used for Eat()
    public void Eat() {
        Console.WriteLine("The animal is eating.");
    }
}

// Pig class inherites from FarmAnimal
class Pig : FarmAnimal {
    // What will happen when Oink is called
    public void Oink() {
        Console.WriteLine("The pig says: Oink!");
    }

    // Overrides FarmAnimals MakeNoise
    public override void MakeNoise() {
        Oink();
    }
}

// Cow class inherites from FarmAnimal
class Cow : FarmAnimal {
    // What will happen when Moo is called
    public void Moo() {
        Console.WriteLine("The cow says: Moo!");
    }

    // Overrides FarmAnimals MakeNoise
    public override void MakeNoise() {
        Moo();
    }
}

// Main class was given
class Program
{
    public static void Main()
    {
        // Instances of Pig and Cow
        Pig pig = new Pig();
        Cow cow = new Cow();

        // Make the pig and cow make their specific noises
        pig.Oink();
        cow.Moo();

        // List of FarmAnimal objects
        List<FarmAnimal> animals = new List<FarmAnimal>();
        animals.Add(pig);
        animals.Add(cow);

        // Iterate through list and make each animal eat and make noise
        animals.ForEach(delegate(FarmAnimal a) {
            a.Eat();
            a.MakeNoise();
        });
    }
}
