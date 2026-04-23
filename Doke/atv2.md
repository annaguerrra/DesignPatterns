

### Parte 2
Agora voce deve fazer um novo pokémon, o "Ditto", ele vai agir um pouco diferente dos outros dois, uma vez que a característica memorável dele é que ele imita outros pokémons, portanto é justamente isso que queremos dele aqui.
#### Ditto - Normal
```powershell
Transform                 |   Dano: 0     |   Tipo: Psychic
```
Queremos que ele copie o pokémon com quem ele está batalhando, portanto o comportamento dos seus logs deve ser o seguinte:

```
Squirtle                        | Ditto
Used: Hydro Pump                | Used: Transform
Hp: 300                         | Hp: 289
--------------------------------------------------------------------------------


Squirtle                        | Squirtle
Used: Water Gun                 | Used: Hydro Pump
Hp: 294,5                       | Hp: 287
--------------------------------------------------------------------------------


Squirtle                        | Squirtle
Used: Bubble Beam               | Used: Water Gun
Hp: 292,5                       | Hp: 284
--------------------------------------------------------------------------------


Squirtle                        | Squirtle
Used: Withdraw                  | Used: Withdraw
Hp: 292,5                       | Hp: 284
--------------------------------------------------------------------------------

[...]
```