public class Subscriber : ISubscriber
{
    public void Update()
    {
        var i = Random.Shared.Next(1, 3);

        if(i == 3) 
            Console.WriteLine("Dislike");
        else 
            Console.WriteLine("Like");
    }
}