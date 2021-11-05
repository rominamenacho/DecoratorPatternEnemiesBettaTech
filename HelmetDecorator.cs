using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternEnemies
{
    public class HelmetDecorator : EnemyDecorator
    {
        public HelmetDecorator(Enemy enemyParam) : base(enemyParam)
        {
        }

        public override int takeDamage()
        {
            return this.enemy.takeDamage()/2;
        }

    }
}
