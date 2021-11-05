using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternEnemies
{
    class ArmourDecorator : EnemyDecorator
    {
        public ArmourDecorator(Enemy enemyParam) : base(enemyParam)
        {
        }

        public override int takeDamage()
        {
            return (int)(this.enemy.takeDamage() / 1.5);
        }
    }
}
