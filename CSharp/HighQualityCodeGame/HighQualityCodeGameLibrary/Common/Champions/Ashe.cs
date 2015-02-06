namespace HighQualityCodeGameLibrary.Common.Champions
{
    using HighQualityCodeGameLibrary.Data;
    using System;

    public class Ashe : Champion
    {
        public Ashe()
            : base(Champions.Ashe, 345, 40, 20, 0)
        {
        }

        public override void FirstAbility()
        {
            Console.WriteLine("Ashe Q");
        }

        public override void SecondAbility()
        {
            Console.WriteLine("Ashe W");
        }

        public override void ThirdAbility()
        {
            Console.WriteLine("Ahri E");
        }

        public override void Ultimate()
        {
            Console.WriteLine("Ashe aRRow");
        }
    }
}