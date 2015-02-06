namespace HighQualityCodeGameLibrary.Common
{
    using HighQualityCodeGameLibrary.Interfaces;
    using System;

    public abstract class GameCharacter : IMovable, IDestroyable, IDisposable, IDamageMaker
    {
        private string name;
        private float health;
        private float damage;
        private float defence;
        private float armorPenetration;
        private int positionX;
        private int positionY;

        public GameCharacter(string name, float health, float damage, float defence, float armorPenetration)
        {
            this.Name = name;
            this.Health = health;
            this.Damage = damage;
            this.Defence = defence;
            this.ArmorPenetration = armorPenetration;
        }

        public int PositionY
        {
            get
            {
                return this.positionY;
            }
            set
            {
                this.positionY = value;
            }
        }

        public int PositionX
        {
            get
            {
                return this.positionX;
            }
            set
            {
                this.positionX = value;
            }
        }
        
        public float ArmorPenetration
        {
            get
            {
                return this.armorPenetration;
            }
            set
            {
                this.armorPenetration = value;
            }
        }

        public float Health
        {
            get
            {
                return this.defence;
            }
            set
            {
                this.defence = value;
            }
        }
        
        public float Damage
        {
            get { return this.damage; }
            set { this.damage = value; }
        }

        public float Defence
        {
            get
            {
                return this.health;
            }
            set
            {
                this.health = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public void Move(int distanceX, int distanceY)
        {
            this.PositionX += distanceX;
            this.PositionY += distanceY;
        }

        public void TakeDamage(float damage)
        {
            this.Health -= damage;
        }

        public bool IsDestroyed()
        {
            if (this.Defence <= 0)
            {
                return true;
            }

            return false;
        }

        public void Attack(ref GameCharacter target)
        {
            target.TakeDamage(this.Damage);
        }
        
        public void Destroy(int time)
        {
            OnDeath();
            Dispose();
        }
        
        public void OnDeath()
        {
            string result = string.Format("{0} said: Goodbye!", this.Name);
            Console.WriteLine(result);
        }

        public void Dispose()
        {
            string result = string.Format("{0} destroyed!", this.Name);
            Console.WriteLine(result);
        }
    }
}
