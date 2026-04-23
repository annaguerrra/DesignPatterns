using Doke.Pokedex;
using Doke.Pokedex.Enum;
using Doke.Pokedex.Models;

public class Ditto : IStrategy
{
    public List<Attack> Attacks { get; set; } = [
    new Attack("Transform", 0, PokemonType.Psychic)
];
    public Attack Execute(Pokemon attacking, Pokemon attacked)
    {
        attacking.strategy = attacked.strategy;
        attacking.Name = attacking.Name;
        return Attacks[0];
    }
}