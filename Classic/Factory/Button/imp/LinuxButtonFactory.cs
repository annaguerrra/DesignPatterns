public class LinuxButtonFactory : ButtonFactory
{
    public IButton Create()
    {
        Console.WriteLine("Linux button created");
        return  new LinuxButton();
    }
}