namespace HighQualityCodeGameLibrary.Common.Champions
{
    using HighQualityCodeGameLibrary.Data;
    using System;

    public class Annie : Champion
    {
        public Annie()
            : base(Champions.Annie, 345, 40, 20, 0)
        {
        }

        public override void FirstAbility()
        {
            Console.WriteLine("Annie Q");
        }

        public override void SecondAbility()
        {
            Console.WriteLine("Annie W");
        }

        public override void ThirdAbility()
        {
            Console.WriteLine("Ahri E");
        }

        public override void Ultimate()
        {
            Console.WriteLine("Annie R");
        }
    }
}