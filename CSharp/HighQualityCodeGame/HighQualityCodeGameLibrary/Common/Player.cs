namespace HighQualityCodeGameLibrary.Common
{
    using System;
    using HighQualityCodeGameLibrary.Interfaces.Player;
    using HighQualityCodeGameLibrary.Interfaces.Champion;

    public class Player : IPlayer
    {
        private string name;
        private IChampion champion;

        public Player(string name)
        {
            this.Name = name;
        }

        string Name
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

        public IChampion Champion
        {
            get
            {
                return this.champion;
            }
            set
            {
                this.champion = value;
            }
        }

        void PickChampion(IChampion championPick)
        {
            if (championPick == null)
            {
                throw new NullReferenceException("Champion picked is null!");
            }

            this.Champion = championPick;
        }
    }
}
