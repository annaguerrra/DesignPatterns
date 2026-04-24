public class SquareFactory : IFactory
{
    public IForm Create()
    {
        Console.WriteLine("Quadrado criado com sucesso!");
        return new Square();
    }
}