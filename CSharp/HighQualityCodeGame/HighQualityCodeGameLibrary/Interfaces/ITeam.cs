namespace HighQualityCodeGameLibrary.Interfaces
{
    using HighQualityCodeGameLibrary.Data;
    using HighQualityCodeGameLibrary.Interfaces.Player;
    using System.Collections.Generic;

    public interface ITeam
    {
        Team TeamColor { get; set; }

        string TeamName { get; set; }

        IEnumerable<IPlayer> TeamMembers { get; set; }
    }
}
