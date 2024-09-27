using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Models
{
    public class Goblin : IEntity
    {
        public string Name { get; set; }

        public void Attack(IEntity target)
        {
            Console.WriteLine($"{Name} attacks {target.Name} with a screech.");
        }

        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void BurnEnemy(IEntity target)
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            Console.WriteLine($"{Name} moves aggressively.");
        }
        public void ExecuteCastSpell(IEntity target)
        {
           throw new NotImplementedException(); 
        }        
    }

}
