namespace InversionCounter
{
    public interface ICounter<in T>
    {
        long Count(T input);
    }
}