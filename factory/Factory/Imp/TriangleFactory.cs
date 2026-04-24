public class TriangleFactory : IFactory
{
    public IForm Create()
    {
        Console.WriteLine("Triangulo criado com sucesso!");
        return new Triangle();
    }
}