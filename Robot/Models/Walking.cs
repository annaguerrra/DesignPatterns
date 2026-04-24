public class Walking : IBehavior
{
    public void Execute(Robot robot)
    {
        Console.WriteLine("Walking");
        
        Random random = new Random();
        var _event = random.NextDouble();
        
        Combat combat= new Combat();
        Hacking hacking= new Hacking();

        if ( _event < 0.05)
        {
            robot._behavior = combat;
        }
        else if ( _event < 0.25)
        {
            robot._behavior = hacking;
        }
    }
}