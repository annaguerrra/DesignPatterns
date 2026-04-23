using Doke.Pokedex;
using Doke.Pokedex.Models;
using Doke.Pokedex.Enum;



Console.WriteLine(new string('=',40) + "Poke Battle!" + new string('=',40));


var round = new Round(Necrozma, Squirtle);
round.onRound();