using Doke.Pokedex.Enum;

namespace Doke.Pokedex;

public class Attack(string name, int damage, PokemonType type)
{
    public string Name {get;set;} = name;
    public int Damage {get;set;} = damage;
    public PokemonType Type {get;set;} = type;
}


public static class Multiplier
{
    private static readonly float[,] attackTable = {
        {1,    1,    1,    1,    1,    0.5f, 1,    0,    0.5f, 1,    1,    1,    1,    1,    1,    1,    1,    1},
        {2,    1,    0.5f, 0.5f, 1,    2,    0.5f, 0,    2,    1,    1,    1,    1,    0.5f, 2,    1,    2,    0.5f},
        {1,    2,    1,    1,    1,    0.5f, 2,    1,    0.5f, 1,    1,    2,    0.5f, 1,    1,    1,    1,    1},
        {1,    1,    1,    0.5f, 0.5f, 0.5f, 1,    0.5f, 0,    1,    1,    2,    1,    1,    1,    1,    1,    2},
        {1,    1,    0,    2,    1,    2,    0.5f, 1,    2,    2,    1,    0.5f, 2,    1,    1,    1,    1,    1},
        {1,    0.5f, 2,    1,    0.5f, 1,    2,    1,    0.5f, 2,    1,    1,    1,    1,    2,    1,    1,    1},
        {1,    0.5f, 0.5f, 0.5f, 1,    1,    1,    0.5f, 0.5f, 0.5f, 1,    2,    1,    2,    1,    1,    2,    0.5f},
        {0,    1,    1,    1,    1,    1,    1,    2,    1,    1,    1,    1,    1,    2,    1,    1,    0.5f, 1},
        {1,    1,    1,    1,    1,    2,    1,    1,    0.5f, 0.5f, 0.5f, 1,    0.5f, 1,    2,    1,    1,    2},
        {1,    1,    1,    1,    1,    0.5f, 2,    1,    2,    0.5f, 0.5f, 2,    1,    1,    2,    0.5f, 1,    1},
        {1,    1,    1,    1,    2,    2,    1,    1,    1,    2,    0.5f, 0.5f, 1,    1,    1,    0.5f, 1,    1},
        {1,    1,    0.5f, 0.5f, 2,    2,    0.5f, 1,    0.5f, 0.5f, 2,    0.5f, 1,    1,    1,    0.5f, 1,    1},
        {1,    1,    2,    1,    0,    1,    1,    1,    1,    1,    2,    0.5f, 0.5f, 1,    1,    0.5f, 1,    1},
        {1,    2,    1,    2,    1,    1,    1,    1,    0.5f, 1,    1,    1,    1,    0.5f, 1,    1,    0,    1},
        {1,    1,    2,    1,    2,    1,    1,    1,    0.5f, 0.5f, 0.5f, 2,    1,    1,    0.5f, 2,    1,    1},
        {1,    1,    1,    1,    1,    1,    1,    1,    0.5f, 1,    1,    1,    1,    1,    1,    2,    1,    0},
        {1,    0.5f, 1,    1,    1,    1,    1,    2,    1,    1,    1,    1,    1,    2,    1,    1,    0.5f, 0.5f},
        {1,    2,    1,    0.5f, 1,    1,    1,    1,    0.5f, 0.5f, 1,    1,    1,    1,    1,    2,    2,    1}
    };
    public static float GetMultiplier(PokemonType att, PokemonType def)
    {
        int row = (int)att;
        int col = (int)def;

        if (row >= 18 || col >= 18) return 1.0f;

        return attackTable[row, col];
    }
}