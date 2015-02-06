namespace HighQualityCodeGameLibrary.Interfaces
{
    public interface IMovable
    {
        int PositionX { get; set; }

        int PositionY { get; set; }

        void Move(int distanceX, int distanceY);
    }
}
