namespace W5_assignment_template.Interfaces
{
    public interface IEntity
    {
        void Attack(IEntity target);
        void Move();
        void Fly();
        void ExecuteCastSpell(IEntity target);
        void BurnEnemy(IEntity target);
        
        string Name { get; set; }
    }

}
