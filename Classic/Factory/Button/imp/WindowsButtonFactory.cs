public class WindowsButtonFactory : ButtonFactory
{
    public IButton Create()
    {
        Console.WriteLine("Windows button created!");
        return new WindowsButton();
    }
}