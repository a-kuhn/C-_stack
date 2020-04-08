using System;

namespace WizardNinjaSamurai
{
    public class Samurai : Human
    {
        public Samurai(string name) : base(name)
        {
            //default health = 200
            health = 200;
        }
        //override attack calls base attack, reduces target to 0 if target.Health < 50
        public override int Attack(Human target)
        {
            base.Attack(target);
            int damage = Strength * 5;
            if (target.Health < 50)
            {
                target.Health = 0;
            }
            Console.WriteLine($"{Name} is inflicting {damage} damage on {target.Name}.\n{target.Name}'s health is now {target.Health}");
            return target.Health;
        }

        //Meditate() heals samurai back to full health
        public void Meditate()
        {
            health = 200;
            Console.WriteLine($"{Name}'s health is fully restored to {Health}.");
        }
    }
}