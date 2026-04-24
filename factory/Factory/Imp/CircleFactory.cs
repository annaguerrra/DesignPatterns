public class CirculoFactory : IFactory
{
    public IForm Create()
    {
        Console.WriteLine("Circulo criado com sucesso!");
        return new Circle();
    }
}