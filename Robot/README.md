# Atividade

Crie uma classe `Robô` que possui um **comportamento** interno (`IComportamento`).

O robô inicia **caminhando**. Durante a execução:

* Enquanto **Caminhando**

  * 20% de chance → mudar para **Combate**
  * 5% de chance → mudar para **Hackeado**

* Enquanto **Combate**

  * 5% de chance → mudar para **Hackeado**

* Enquanto **Hackeado**

  * permanece hackeado para sempre

Cada comportamento deve apenas imprimir um log.

Execute **20 iterações** chamando `robo.Agir()`.

## Exemplo

```
[01] [Robô] andando...
[02] [Robô] andando...
[03] [Robô] andando...
[04] [Robô] COMBATE...
[05] [Robô] COMBATE...
[06] [Robô] hAckEaDo...
[07] [Robô] hAckEaDo...
[08] [Robô] hAckEaDo...
...
```
