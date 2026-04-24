# Atividade Factory Classic
Crie a interface base de "Botao" e então 3 tipos de botões:
LinuxBotao
MacBotao
WindowsBotao

Implemente seus respectivos factories conforme foi visto no refactoring guru. 
Coloque um "Console.WriteLine(<NOME DO BOTAO>)" no metodo de criação.

### Application
Crie uma classe "Application", essa classe terá um atributo do 
tipo "Factory" (aquela que é a base das implementações das factories)

No construtor de Application receba o parâmetro a factory de botao desejada,
e então atribui para o atributo especificado anteriormente.

Crie um método CreateButton que usa a factory para criar um botão.