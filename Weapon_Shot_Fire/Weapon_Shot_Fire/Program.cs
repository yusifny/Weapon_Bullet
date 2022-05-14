using System;
using Weapon_Shot_Fire.Models;

namespace Weapon_Shot_Fire
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletCapacity;
            int currentBullet;
            int isManual;
            do
            {
                bulletCapacity = Convert.ToInt32(Console.ReadLine());
            } while (bulletCapacity < 0);
            do
            {
                currentBullet = Convert.ToInt32(Console.ReadLine());
            } while (currentBullet < 0||currentBullet>bulletCapacity);

            Weapon weapon = new Weapon(bulletCapacity, currentBullet, isManual);

            

            bool Check = true;

            do
            {
                int Choice = Convert.ToInt32(Console.ReadLine());
                switch (Choice)
                {
                    case 0:
                        break;
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    default:
                        break;
                }
            } while (Check);

        }
    }
}
