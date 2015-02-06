using HighQualityCodeGameLibrary.Common;
using HighQualityCodeGameLibrary.Common.Champions;
using HighQualityCodeGameLibrary.Interfaces.Champion;
namespace HighQualityCodeGame
{
    public class HighQualityCodeGameEntryPoint
    {
        public static void Main()
        {
            /*
             * Class Item -> IItem (ward, inventory), IDestroyable IInvisible (ward), IUsable (inventory)
             * Class Player -> IPlayer, ITeamMember
             * Class Monster -> IMonster (lane, jungle), ITeamMember, INeutral, IMakedamage
             * Class Team -> ITeamMember
             * Class Champion, ITeamMember, IDestroyable, IMakeDamage, IChampion, IInvisible
             */
            
            var ahri = new Ahri();
            ahri.FirstAbility();
            ahri.Ultimate();
            
            GameCharacter amumu = new Amumu();
            System.Console.WriteLine(amumu.Health);
            ahri.Attack(ref amumu);
            System.Console.WriteLine(amumu.Health);
            
        }
    }
}
