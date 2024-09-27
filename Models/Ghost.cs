using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Models
{
    public class Ghost : IEntity
    {
        public string Name { get; set; }

        public void Attack(IEntity target)
        {
            Console.WriteLine($"{Name} attacks {target.Name} with a chilling touch.");
        }

        public void Move()
        {
            Console.WriteLine($"{Name} floats eerily.");
        }

        public void Fly()
        {
            Console.WriteLine($"{Name} flies races through the air.");
        }

        public void BurnEnemy(IEntity target)
        {
            throw new NotImplementedException();
        }

        public void ExecuteCastSpell(IEntity target)
        {
            Console.WriteLine($"{Name} casts an ice spell on {target.Name}.");
        }
    }
}
