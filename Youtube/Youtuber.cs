public class Youtuber
{
    public EventManager em { get; set;} = new();

    public void Publish()
    {
        em.Notify();
    }
}