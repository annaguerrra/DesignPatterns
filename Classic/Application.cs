public class Application(string obj, ButtonFactory factory)
{
    private ButtonFactory Factory = factory;
    private string obj = obj;

    public void CreateButton( )
    {
        Factory.Create(obj);
    }
}