using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternEnemies
{
   public abstract class EnemyDecorator : Enemy
    {
    protected Enemy enemy;

      public EnemyDecorator(Enemy enemyParam)
        {
            this.enemy = enemyParam;
        }

        public virtual int takeDamage()
        {
            return this.enemy.takeDamage();
        }
    }
}
