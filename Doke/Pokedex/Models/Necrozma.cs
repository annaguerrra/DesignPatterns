using Doke.Pokedex;
using Doke.Pokedex.Enum;
using Doke.Pokedex.Models;

public class Necrozma : IStrategy
{
    public List<Attack> Attacks { get; set; } = [
    new Attack("Photon Geyser", 10, PokemonType.Psychic),
    new Attack("Prismatic Laser", 16, PokemonType.Psychic),
    new Attack("Night Slash", 7, PokemonType.Dark),
    new Attack("Iron Defense", 0, PokemonType.Steel),
    new Attack("Light That Burns the Sky", 20, PokemonType.Psychic)
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