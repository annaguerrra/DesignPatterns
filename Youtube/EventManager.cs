public class EventManager()
{
    List<ISubscriber> subscribers = [];

    public void Notify()
    {
        foreach(var i in subscribers)
            i.Update();
    }

    public void Subscribe(ISubscriber subs) 
        => subscribers.Add(subs);
}
