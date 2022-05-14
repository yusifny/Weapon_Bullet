using System;
using System.Collections.Generic;
using System.Text;

namespace Weapon_Shot_Fire.Models
{
    class Weapon
    {
        private int _bulletCapacity;
        private int _currentBullet;
        public int BulletCapacity
        {
            get => _bulletCapacity;
            set
            {
                if (value >= 0 && value <= 30)
                {
                    _bulletCapacity = value;
                }
            }
        }
        public int CurrentBullet
        {
            get => _currentBullet;
            set
            {
                if (value >= 0 && value <= 30)
                {
                    _currentBullet = value;
                }
            }
        }
        public bool IsManual { get; set; }

        public Weapon(int bulletCapacity, int currentBullet, bool isManual)
        {
            BulletCapacity = bulletCapacity;
            CurrentBullet = currentBullet;
            IsManual = isManual;
        }

        public void Shoot()
        {
            Console.WriteLine("Shoot method used.");
            if (CurrentBullet > 0)
            {
                CurrentBullet--;
                if (CurrentBullet > 1)
                {
                    Console.WriteLine($"{CurrentBullet} bullets remain.");
                }
                else
                {
                    Console.WriteLine($"{CurrentBullet} bullet remains.");
                }
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Have no enough bullet!");
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }

        public void Fire()
        {
            Console.WriteLine("Fire method used.");
            if (CurrentBullet > 0)
            {
                if (IsManual == true)
                {
                    CurrentBullet--;
                    if (CurrentBullet > 1)
                    {
                        Console.WriteLine($"{CurrentBullet} bullets remain.");
                    }
                    else
                    {
                        Console.WriteLine($"{CurrentBullet} bullet remains.");
                    }
                }
                else
                {
                    CurrentBullet = 0;
                    Console.WriteLine($"{CurrentBullet} bullet remains.");
                }
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Have no enough bullet!");
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }

        public void GetRemainBulletCount()
        {
            Console.WriteLine($"{BulletCapacity - CurrentBullet}");
        }

        public void ChangeFireMode()
        {
            if (IsManual == true)
            {
                Console.WriteLine($"Mode is changed to Automatic");
            }
            else if(IsManual == false)
            {
                Console.WriteLine($"Mode is changed to Manual");
            }

        }
        
        public void Reload()
        {
            CurrentBullet = 30;
        }
    }
}
