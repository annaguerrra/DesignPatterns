public class Robot(IBehavior behavior)
{
    public IBehavior _behavior= behavior;
    public void Act()
    {
        for( int i = 0; i < 20; i++)
            _behavior.Execute( this );
  
    }
}