public class ButtonFactory
{
    Dictionary<string, Func<IButton>> types = [];
    
    public void Add(string type, Func<IButton> button)
    {
        types.Add(type, button);
    }

    public IButton Create(string type)
    {
        return types[type].Invoke();
    }
}