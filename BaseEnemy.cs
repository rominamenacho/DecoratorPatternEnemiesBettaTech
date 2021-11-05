using System;

namespace DecoratorPatternEnemies
{
    public class BaseEnemy : Enemy
    {
        public BaseEnemy()
        {
        }

        public int takeDamage()
        {
           return 10;
        }

    }
}