public interface IShockController
{
    void EnqueueShock(int intensity, int duration, bool death, string? code = null);
}