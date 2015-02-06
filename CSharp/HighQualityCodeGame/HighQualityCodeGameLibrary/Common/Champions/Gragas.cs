namespace HighQualityCodeGameLibrary.Common.Champions
{
    using HighQualityCodeGameLibrary.Data;
    using System;

    public class Gragas : Champion
    {
        public Gragas()
            : base(Champions.Gragas, 345, 40, 20, 0)
        {
        }

        public override void FirstAbility()
        {
            Console.WriteLine("Gragas Q");
        }

        public override void SecondAbility()
        {
            Console.WriteLine("Gragas W");
        }

        public override void ThirdAbility()
        {
            Console.WriteLine("Ahri E");
        }

        public override void Ultimate()
        {
            Console.WriteLine("Gragas R");
        }
    }
}