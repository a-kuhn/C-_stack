using System;

namespace HumanOOP
{
    public class Human
    {
        //fields for human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;

        //add a public 'getter' to access health
        public int Health
        {
            get { return health; }
        }

        //add constructor that takes a value to set Name
        //set remaining fields to default values
        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }

        //add constructor to assign custom values to all fields
        public Human(string name, int strength, int intelligence, int dexterity, int healthInitial)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            health = healthInitial;
        }

        //build attack method to decrease target Human health by 5*strength of attacker
        //return remaining health of target Human
        public int Attack(Human target)
        {
            Console.WriteLine($"{Name} is attacking {target.Name}!");
            int attackStrength = Strength * 5;
            target.health -= attackStrength;
            return target.Health;
        }
    }
}