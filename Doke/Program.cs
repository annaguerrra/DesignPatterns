using Doke.Pokedex;
using Doke.Pokedex.Models;
using Doke.Pokedex.Enum;



Console.WriteLine(new string('=',40) + "Poke Battle!" + new string('=',40));

List<Attack> NecrozmaAttacks = [
    new Attack("Photon Geyser", 10, PokemonType.Psychic),
    new Attack("Prismatic Laser", 16, PokemonType.Psychic),
    new Attack("Night Slash", 7, PokemonType.Dark),
    new Attack("Iron Defense", 0, PokemonType.Steel),
    new Attack("Light That Burns the Sky", 20, PokemonType.Psychic)
];

List<Attack> SquirtleAttacks = [
    new Attack("Water Gun", 10, PokemonType.Water),
    new Attack("Withdraw", 16, PokemonType.Water),
    new Attack("Bubble Beam", 7, PokemonType.Water),
    new Attack("Rapid Spin", 0, PokemonType.Normal),
    new Attack("Hydro Pump", 20, PokemonType.Water)
];

Pokemon Necrozma = new Pokemon("Necrozma", 100, PokemonType.Psychic, NecrozmaAttacks);
Pokemon Squirtle = new Pokemon("Squirtle", 100, PokemonType.Water, SquirtleAttacks);

var round = new Round(Necrozma, Squirtle);
round.onRound();