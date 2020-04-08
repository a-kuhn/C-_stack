using System;

namespace WizardNinjaSamurai
{
    public class Wizard : Human
    {
        public Wizard(string name) : base(name)
        {
            //Wizard should have a default health of 50 and Intelligence of 25
            health = 50;
            Intelligence = 25;
        }
        //override attack --> damage = 5*Intelligence, Health += damage
        public override int Attack(Human target)
        {
            int damage = (5 * Intelligence);
            target.Health -= damage;
            health += damage;
            Console.WriteLine($"{Name} is inflicting {damage} damage on {target.Name}.\n{target.Name}'s health is now {target.Health} and {Name}'s health is now {Health}");
            return target.Health;
        }

        //Heal(target) --> target.Health += 10*Intelligence
        public void Heal(Human target)
        {
            target.Health += (10 * Intelligence);
            Console.WriteLine($"{target.Name}'s health has been restored to {target.Health}.");
        }
    }
}