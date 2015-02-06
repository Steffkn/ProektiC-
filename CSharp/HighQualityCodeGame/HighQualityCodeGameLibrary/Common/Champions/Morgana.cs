namespace HighQualityCodeGameLibrary.Common.Champions
{
    using HighQualityCodeGameLibrary.Data;
    using System;

    public class Morgana : Champion
    {
        public Morgana()
            : base(Champions.Morgana, 345, 40, 20, 0)
        {
        }

        public override void FirstAbility()
        {
            Console.WriteLine("Morgana Q");
        }

        public override void SecondAbility()
        {
            Console.WriteLine("Morgana W");
        }

        public override void ThirdAbility()
        {
            Console.WriteLine("Ahri E");
        }

        public override void Ultimate()
        {
            Console.WriteLine("Morgana R");
        }
    }
}