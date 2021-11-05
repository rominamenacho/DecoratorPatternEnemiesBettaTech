using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternEnemies
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy enemy = new BaseEnemy();
            int computedDamage = enemy.takeDamage();
            Console.WriteLine("Enemigo base. Daño:"+ computedDamage);

            //enemigo decorado con casco
            Enemy enemyHelmet = new HelmetDecorator( enemy);
            computedDamage = enemyHelmet.takeDamage();
            Console.WriteLine("Enemigo base con casco. Daño:" + computedDamage);

            Enemy enemyWithARmourAndHelmet = new ArmourDecorator(enemyHelmet);
            computedDamage = enemyWithARmourAndHelmet.takeDamage();
            Console.WriteLine("Enemigo base con casco y armadura. Daño:" + computedDamage);


            Console.ReadKey();
        }
    }
}
