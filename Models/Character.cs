using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Models;

public class Character : IEntity
{
    public string Name { get; set; }

    public void Attack(IEntity target)
    {
        Console.WriteLine($"{Name} attacks {target.Name}");
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
        Console.WriteLine($"{Name} moves forward.");
    }
    public void ExecuteCastSpell(IEntity target)
    {
        Console.WriteLine($"{Name} casts a repelling spell.");
    }
}
