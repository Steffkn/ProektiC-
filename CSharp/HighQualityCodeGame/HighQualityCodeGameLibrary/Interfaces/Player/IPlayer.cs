namespace HighQualityCodeGameLibrary.Interfaces.Player
{
    using HighQualityCodeGameLibrary.Interfaces.Champion;

    public interface IPlayer
    {
        IChampion Champion { get; set; }
    }
}
