public class LinuxButtonFactory : IButtonFactory
{
    public IButton Create()
    {
        Console.WriteLine("Linux button created");
        return  new LinuxButton();
    }
}