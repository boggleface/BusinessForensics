using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessForensics
{
    abstract class Animal
    {
        public abstract string Name { get; }

        //Object would be replaced by some real Simage type.
        public abstract object Picture { get; }
    }

    abstract class Mammal : Animal
    {

    }

    abstract class Fish : Animal
    {

    }

    abstract class Amphibian : Animal
    {

    }

    abstract class Bird : Animal
    {

    }

    interface IPredator
    {

    }

    interface IHerdAnimal
    {

    }

    interface IMarineAnimal
    {

    }

    interface IPet
    {

    }

    interface IDangerous
    {

    }

    class Tarantula : Mammal, IPredator, IPet, IDangerous
    {
        public override string Name { get; } = "Tarantula";

        public override object Picture { get; } = new object();
    }

    class Shark : Mammal, IPredator, IMarineAnimal, IDangerous
    {
        public override string Name { get; } = "Shark";

        public override object Picture { get; } = new object();
    }

    class Dolphin : Mammal, IMarineAnimal
    {
        public override string Name { get; } = "Dolphin";

        public override object Picture { get; } = new object();
    }

    class Wolf : Mammal, IPredator, IHerdAnimal, IDangerous
    {
        public override string Name { get; } = "Wolf";

        public override object Picture { get; } = new object();
    }

    class Dog : Mammal, IPet
    {
        public override string Name { get; } = "Dog";

        public override object Picture => new object();
    }

    static class AnimalExtensions
    {
        public static void Feed(this Animal animal, int kilograms)
        {

        }
    }
}
