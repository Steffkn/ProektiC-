namespace HighQualityCodeGameLibrary.Common.Champions
{
    using HighQualityCodeGameLibrary.Data;
    using System;

    public class Zed : Champion
    {
        public Zed()
            : base(Champions.Zed, 345, 40, 20, 0)
        {
        }

        public override void FirstAbility()
        {
            Console.WriteLine("Zed Q");
        }

        public override void SecondAbility()
        {
            Console.WriteLine("Zed W");
        }

        public override void ThirdAbility()
        {
            Console.WriteLine("Ahri E");
        }

        public override void Ultimate()
        {
            Console.WriteLine("Zed R");
        }
    }
}