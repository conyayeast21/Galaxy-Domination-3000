using System;
using System.Collections.Generic;
using System.Text;

namespace Rossi_Project_Template
{
    class Player1
    {
        private Beans beans;
        private Lightsaber lightsaber;

        public int Health { get; set; }

        public Player1 (int health)

        {
            Health = health;
        }
        public void Punch(Enemy enemy)
        {
            enemy.TakeDamage(10);
        }

        public void TakeDamage(int damage = 10) //optional parameter
        {
            try
            {
                Health = Health - damage;
            }
            catch (ArgumentException)
            {
                Health = 0;
                Console.WriteLine("Player health is 0, you have died");
            }
        }

        public void Pickup (Beans pickupBeans) //make general pickup method, one for beans one for lightsaber
        {
            beans = pickupBeans;
        }
        public void Pickup(Lightsaber pickupLightsaber)
        {
            lightsaber = pickupLightsaber;
        }
        public void BeanAttack(Enemy enemy)
        {
            enemy.TakeDamage(1);
        }
        public void LightsaberAttack(Enemy enemy)
        {
            enemy.TakeDamage(100);
        }
        public void GiveBeans(Enemy enemy)
        {

        }
    }
}
