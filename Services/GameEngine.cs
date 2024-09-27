﻿using W5_assignment_template.Interfaces;
using W5_assignment_template.Models;

namespace W5_assignment_template.Services
{
    public class GameEngine
    {
        private readonly IEntity _character;
        private readonly IEntity _goblin;
        private readonly IEntity _ghost;
        private readonly IEntity _king;
        private readonly IEntity _druid;

        public GameEngine(IEntity character, IEntity goblin, IEntity ghost, IEntity king, IEntity druid)
        {
            _character = character;
            _goblin = goblin;
            _ghost = ghost;
            _king = king;
            _druid = druid;
        }

        public void Run()
        {
            _character.Name = "Hero";
            _goblin.Name = "Goblin";
            _ghost.Name = "Ghost";
            _king.Name = "Mandariik";
            _druid.Name = "Nardand";

            _character.Move();
            _character.Attack(_goblin);

            _goblin.Move();
            _goblin.Attack(_character);

            _ghost.Move();
            _ghost.Attack(_character);

            if (_ghost is IFlyable)
            {
               ((IFlyable)_ghost).Fly();
            }
            else
            {
                _ghost.Move();
            }

            _druid.Move();
            _druid.ExecuteCastSpell(_goblin);

            _king.Move();
            _king.BurnEnemy(_ghost);
        }
    }
}