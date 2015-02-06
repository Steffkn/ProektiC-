namespace HighQualityCodeGameLibrary.Common.Champions
{
    using HighQualityCodeGameLibrary.Data;
    using System;
    using HighQualityCodeGameLibrary.Interfaces;

    public class Ahri : Champion
    {
        public Ahri()
            : base(Champions.Ahri, 345, 40, 20, 0)
        {
        }

        public override void FirstAbility()
        {
            Console.WriteLine("Ahri Q");
        }

        public override void SecondAbility()
        {
            Console.WriteLine("Ahri W");
        }

        public override void ThirdAbility()
        {
            Console.WriteLine("Ahri E");
        }

        public override void Ultimate()
        {
            Console.WriteLine("Ahri R");
        }
    }
}
