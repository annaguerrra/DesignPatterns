using System.Security.Cryptography.X509Certificates;
using Doke.Pokedex.Models;

namespace Doke.Pokedex.Models;
public class Round(Pokemon pokemon1, Pokemon pokemon2)
{
    Pokemon p1 = pokemon1;
    Pokemon p2 = pokemon2;
    bool battleEnd = false;
    string winner = "";

    public void onRound()
    {
        while( p1.Hp != 0 && p2.Hp != 0)
        {
            var a1 = Random.Shared.Next(0, 5);
            var attack1 = p1.Attacks[a1];
            p1.Strike(p2, attack1);
            p2.Hp -= attack1.Damage;

            var a2 = Random.Shared.Next(0, 5);
            var attack2 = p2.Attacks[a2];
            p2.Strike(p1, attack2);
            p1.Hp -= attack2.Damage;
            
            if(p1.Hp <= attack2.Damage)
            {
                p1.Hp = 0;
                winner = p2.Name;
                battleEnd = true;
            }
            if(p2.Hp <= attack1.Damage)
            {
                p2.Hp = 0;
                winner = p1.Name;
                battleEnd = true;
            }

            Console.WriteLine($"\n{p1.Name} |               {p2.Name}");
            Console.WriteLine($"Used: {attack1.Name} |   Used: {attack2.Name}");
            Console.WriteLine($"HP: {p1.Hp} |                  HP: {p2.Hp}");      

            if (battleEnd)
            {
                Console.WriteLine($"\n{winner} wins!");
                break;
            }
        }

    }
}