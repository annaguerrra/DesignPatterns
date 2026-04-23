using Doke.Pokedex;
using Doke.Pokedex.Enum;
using Doke.Pokedex.Models;

public class Squirtle : IStrategy
{
    public List<Attack> Attacks { get; set; } = [
        new Attack("Water Gun", 10, PokemonType.Water),
        new Attack("Withdraw", 16, PokemonType.Water),
        new Attack("Bubble Beam", 7, PokemonType.Water),
        new Attack("Rapid Spin", 0, PokemonType.Normal),
        new Attack("Hydro Pump", 20, PokemonType.Water)
    ];
    public Attack Execute(Pokemon attacking, Pokemon attacked)
    {
        int a1 = Random.Shared.Next(0, 5);
        Attack attack = Attacks[a1];

        float multiplier = Multiplier.GetMultiplier(attack.Type, attacked.Type);
        var damage = attack.Damage * multiplier;
        attacked.Hp -= (int)damage;

        return attack;
    }
}