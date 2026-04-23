namespace Doke.Pokedex.Models;

public interface IStrategy
{
   Attack Execute(Pokemon attacking, Pokemon attacked); 
}