
namespace HighQualityCodeGameLibrary.Interfaces
{using HighQualityCodeGameLibrary.Common;
    public interface IDamageMaker
    {
        float Damage { get; set; }

        float ArmorPenetration { get; set; }

        void Attack(ref GameCharacter target);
    }
}
