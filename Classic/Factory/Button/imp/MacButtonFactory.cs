public class MacButtonFactory : ButtonFactory
{
    public IButton Create()
    {
        Console.WriteLine("Mac Button created!");
        return new MacButton();
    }
}