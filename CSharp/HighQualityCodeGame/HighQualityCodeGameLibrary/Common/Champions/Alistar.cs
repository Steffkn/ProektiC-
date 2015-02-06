namespace HighQualityCodeGameLibrary.Common.Champions
{
    using HighQualityCodeGameLibrary.Data;
    using System;

    public class Alistar : Champion
    {
        public Alistar()
            : base(Champions.Alistar, 345, 40, 20, 0)
        {
        }

        public override void FirstAbility()
        {
            Console.WriteLine("Alistar Q");
        }

        public override void SecondAbility()
        {
            Console.WriteLine("Alistar W");
        }

        public override void ThirdAbility()
        {
            Console.WriteLine("Ahri E");
        }

        public override void Ultimate()
        {
            Console.WriteLine("Alistar R");
        }
    }
}