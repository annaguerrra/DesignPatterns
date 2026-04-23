using Doke.Pokedex.Enum;

namespace Doke.Pokedex.Models;

public class Pokemon
{
    public string Name { get; set;}
    public int Hp {get; set; }
    public PokemonType Type { get; set; }
    public IStrategy strategy{ get; set; } = strategy;
    public List<Attack> Attacks { get; set; } = new List<Attack>(5);

    public Pokemon(string name, int hp, PokemonType type, List<Attack> attacks)
    {
        Name = name;
        Hp = hp;
        Type = type;
        Attacks = attacks;
    }

    public float Strike(Pokemon pokemon, Attack attack)
    {
        float multiplier = Multiplier.GetMultiplier(Type, attack.Type);
        var damage = attack.Damage * multiplier;
        
        return damage;
    }
}

