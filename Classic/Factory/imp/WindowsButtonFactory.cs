public class WindowsButtonFactory : IButtonFactory
{
    public IButton Create()
    {
        Console.WriteLine("Windows button created!");
        return new WindowsButton();
    }
}