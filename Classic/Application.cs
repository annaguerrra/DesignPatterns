public class Application(IButtonFactory factory)
{
    public IButtonFactory Factory = factory;

    public void CreateButton( )
    {
        Factory.Create();
    }
}