 # Atividade
Seu desafio é criar uma boa estrutura abstraindo pokémons.

### Parte 1
Queremos criar 2 pokémons a sua escolha, oficial ou inventado por você, cada um deles deve ter:
- Nome
- Hp
- Tipo (enum PokemonType)
- 5 ataques (classe Attack)

Abaixo temos dois pokemons caso esteja com preguiça de pesquisar:

#### Necrozma - Psychic
```powershell
Photon Geyser             |   Dano: 10    |   Tipo: Psychic  
Prismatic Laser           |   Dano: 16    |   Tipo: Psychic  
Night Slash               |   Dano: 7     |   Tipo: Dark  
Iron Defense              |   Dano: 0     |   Tipo: Steel  
Light That Burns the Sky  |   Dano: 20    |   Tipo: Psychic  
```

#### Squirtle - Water
```powershell
Water Gun                 |   Dano: 4     |   Tipo: Water  
Withdraw                  |   Dano: 0     |   Tipo: Water  
Bubble Beam               |   Dano: 6     |   Tipo: Water  
Rapid Spin                |   Dano: 5     |   Tipo: Normal  
Hydro Pump                |   Dano: 11    |   Tipo: Water  
```
---
Faça os dois batalharem até a morte, e resulte um Log similar ao abaixo, sinta-se livre para adicionar mais informações (dano infligido, dano recebido, etc).

```
[...]

Squirtle                        | Necrozma
Used: Withdraw                  | Used: Prismatic Laser
Hp: 28                          | Hp: 183
--------------------------------------------------------------------------------


Squirtle                        | Necrozma
Used: Bubble Beam               | Used: Photon Geyser
Hp: 18                          | Hp: 177
--------------------------------------------------------------------------------


Squirtle                        | Necrozma
Used: Rapid Spin                | Used: Prismatic Laser
Hp: 2                           | Hp: 172
--------------------------------------------------------------------------------


Squirtle                        | Necrozma
Used: Withdraw                  | Used: Light That Burns the Sky
Hp: -18                         | Hp: 172
--------------------------------------------------------------------------------
```


**Use o método da classe estática Multiplier.GetMultiplier(att, def) para pegar o multiplicador do dano que será infligido
Exemplo (código didático, este não é o fluxo de operações obrigatório para a execução da tarefa):
```cs
var tipoDoAtaque = ataque.Type;
var tipoDoPokemonAtacado = Pokemon.Fire;

float multiplicador = Multiplier.GetMultiplier(tipoDoAtaque, tipoDoPokemonAtacado);

var danoQueSeraCausado = ataque.Damage * multiplicador;
```



