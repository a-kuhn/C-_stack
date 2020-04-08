using System;

namespace WizardNinjaSamurai
{
    public class Ninja : Human
    {
        public Ninja(string name) : base(name)
        {
            //default dexterity = 175
            Dexterity = 175;
        }
        //override attack target.Health -= 5*Dexterity && 20% chance of additional 10 damage
        public override int Attack(Human target)
        {
            Random rand = new Random();
            int damage = (5 * Dexterity);
            if (rand.Next(0, 5) == 0)
            {
                damage += 10;
            }
            target.Health -= damage;
            Console.WriteLine($"{Name} is inflicting {damage} damage on {target.Name}.\n{target.Name}'s health is now {target.Health}");
            return target.Health;
        }

        //Steal(target) --> target.Health -= 5, ninja's Health += 5
        public void Steal(Human target)
        {
            target.Health -= 5;
            health += 5;
            Console.WriteLine($"{Name} just stole 5 health from {target.Name}.\n{Name}'s health is now {Health} and {target.Name}'s health is now {target.Health}");
        }
    }
}