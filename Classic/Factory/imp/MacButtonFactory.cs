public class MacButtonFactory : IButtonFactory
{
    public IButton Create()
    {
        Console.WriteLine("Mac Button created!");
        return new MacButton();
    }
}