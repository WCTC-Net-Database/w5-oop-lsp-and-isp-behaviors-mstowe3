using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Models
{
    public class Druid : IEntity, ICastSpell
    {
        public string Name {get;set;}

        public void Attack(IEntity target)
        {
            Console.WriteLine($"{Name} attacks {target.Name} with arcane magic.");
        }

        public void Move()
        {
            Console.WriteLine($"{Name} moves by rolling.");
        }

        public void Fly()
        {
            Console.WriteLine($"{Name} flys by shapeshifting into a moth.");
        }
        
        public void BurnEnemy(IEntity target)
        {
        throw new NotImplementedException();
        }

        public void ExecuteCastSpell(IEntity target)
        {
            Console.WriteLine($"{Name} casts an moonfire spell on {target.Name}.");
        }
    }
}