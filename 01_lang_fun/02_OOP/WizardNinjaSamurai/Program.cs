using System;

namespace WizardNinjaSamurai
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a wizard
            Wizard gandalf = new Wizard("Gandalf");
            Console.WriteLine($"gandalf: {gandalf.Name}, health: {gandalf.Health}, strength: {gandalf.Strength}, intelligence: {gandalf.Intelligence}, dexterity: {gandalf.Dexterity}");

            //create a ninja
            Ninja beverlyHillsNinja = new Ninja("Beverly Hills Ninja");
            Console.WriteLine($"beverlyHillsNinja: {beverlyHillsNinja.Name}, health: {beverlyHillsNinja.Health}, strength: {beverlyHillsNinja.Strength}, intelligence: {beverlyHillsNinja.Intelligence}, dexterity: {beverlyHillsNinja.Dexterity}");

            //create a samurai
            Samurai sam = new Samurai("Sam");
            Console.WriteLine($"sam: {sam.Name}, health: {sam.Health}, strength: {sam.Strength}, intelligence: {sam.Intelligence}, dexterity: {sam.Dexterity}");

            Console.WriteLine("\n\n\n");
            //test attack methods n->w; n->s; w->n; w->s; s->n; s->w;
            beverlyHillsNinja.Attack(gandalf);
            beverlyHillsNinja.Attack(sam);
            gandalf.Attack(beverlyHillsNinja);
            gandalf.Attack(sam);
            sam.Attack(beverlyHillsNinja);
            sam.Attack(gandalf);

            Console.WriteLine("\n\n\n");
            //test special methods: n=Steal; w=Heal; s=Meditate;
            beverlyHillsNinja.Steal(gandalf);
            gandalf.Heal(beverlyHillsNinja);
            sam.Meditate();

        }
    }
}
