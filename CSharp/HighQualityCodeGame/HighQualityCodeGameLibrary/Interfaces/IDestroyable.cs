namespace HighQualityCodeGameLibrary.Interfaces
{
    public interface IDestroyable
    {
        float Health { get; set; }
        
        float Defence { get; set; }

        void TakeDamage(float damage);

        bool IsDestroyed();

        void Destroy(int time);

        void OnDeath();
    }
}