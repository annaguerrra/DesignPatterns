public class Combat : IBehavior
{
    public void Execute(Robot robot)
    { 
        Console.WriteLine("COMBAT");

        Random random = new Random();
        var _event = random.NextDouble();
        
        Hacking hacking= new Hacking();

        if ( _event < 0.05)
        {
            robot._behavior = hacking;
        }
    }

}