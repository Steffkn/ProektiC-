namespace HighQualityCodeGameLibrary.Common.Champions
{
    using System;
    using HighQualityCodeGameLibrary.Interfaces.Champion;
    using HighQualityCodeGameLibrary.Data;

    public abstract class Champion : GameCharacter, IChampion
    {
        private string championName;
        private Champions championType;

        public Champion(Champions champion, float health, float damage, float defence, float armorPenetration)
            : base(champion.ToString(), health, damage, defence, armorPenetration)
        {
            this.ChampionType = champion;
            this.ChampionName = champion.ToString();
        }

        public string ChampionName
        {
            get { return championName; }
            private set { championName = value; }
        }

        public Champions ChampionType
        {
            get
            {
                return this.championType;
            }
            set
            {
                this.championType = value;
            }
        }

        public abstract void FirstAbility();

        public abstract void SecondAbility();

        public abstract void ThirdAbility();

        public abstract void Ultimate();
    }
}
