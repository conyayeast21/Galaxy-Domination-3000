using System;
using System.Collections.Generic;
using System.Text;

namespace Rossi_Project_Template
{
    class Enemy
    {
        private Beans beans;

        public Enemy(int health)

        {
            Health = health;
        }
        public int Health { get; set; }

        public void TakeDamage(int damage)
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
    

        public void Attack(Player1 player1)
        {
            player1.TakeDamage(10);
        }
        public void Pickup(Beans pickupBeans)
        {
            beans = pickupBeans;
        }
    }
}
