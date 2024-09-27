using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Models;

public class King : IEntity, IBurn, ICastSpell
{
        public string Name {get;set;}

        public void Attack(IEntity target)
        {
            Console.WriteLine($"{Name} attacks {target.Name} with grace");
        }

        public void Move()
        {
            System.Console.WriteLine($"{Name} moves carefully.");
        }

        public void Fly()
        {
            throw new NotImplementedException();
        }
        public void BurnEnemy(IEntity target)
        {
            System.Console.WriteLine($"{Name} burns {target.Name}.");
        }
        public void ExecuteCastSpell(IEntity target)
        {
            Console.WriteLine($"{Name} casts a stun spell on {target.Name}.");
        }        
}