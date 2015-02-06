namespace HighQualityCodeGameLibrary.Common.Champions
{
    using HighQualityCodeGameLibrary.Data;
    using System;

    public class Amumu : Champion
    {
        public Amumu()
            : base(Champions.Amumu, 345, 40, 20, 0)
        {
        }

        public override void FirstAbility()
        {
            Console.WriteLine("Amumu Q");
        }

        public override void SecondAbility()
        {
            Console.WriteLine("Amumu W");
        }

        public override void ThirdAbility()
        {
            Console.WriteLine("Ahri E");
        }

        public override void Ultimate()
        {
            Console.WriteLine("Amumu R");
        }
    }
}