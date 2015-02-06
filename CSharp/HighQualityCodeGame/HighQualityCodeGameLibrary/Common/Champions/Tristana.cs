namespace HighQualityCodeGameLibrary.Common.Champions
{
    using HighQualityCodeGameLibrary.Data;
    using System;

    public class Tristana : Champion
    {
        public Tristana()
            : base(Champions.Tristana, 345, 40, 20, 0)
        {
        }

        public override void FirstAbility()
        {
            Console.WriteLine("Tristana Q");
        }

        public override void SecondAbility()
        {
            Console.WriteLine("Tristana W");
        }

        public override void ThirdAbility()
        {
            Console.WriteLine("Ahri E");
        }

        public override void Ultimate()
        {
            Console.WriteLine("Tristana R");
        }
    }
}