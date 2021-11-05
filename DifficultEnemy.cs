using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternEnemies
{
    class DifficultEnemy : Enemy
    {
        public int takeDamage()
        {
            return 1;
        }
    }
}
