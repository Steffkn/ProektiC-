namespace HighQualityCodeGameLibrary.Common.Champions
{
    using HighQualityCodeGameLibrary.Data;
    using System;

    public class Elise : Champion
    {
        public Elise()
            : base(Champions.Elise, 345, 40, 20, 0)
        {
        }

        public override void FirstAbility()
        {
            Console.WriteLine("Elise Q");
        }

        public override void SecondAbility()
        {
            Console.WriteLine("Elise W");
        }

        public override void ThirdAbility()
        {
            Console.WriteLine("Ahri E");
        }

        public override void Ultimate()
        {
            Console.WriteLine("Elise R");
        }
    }
}