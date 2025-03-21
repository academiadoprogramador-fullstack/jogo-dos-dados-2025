# Jogo Dos Dados 2025

![](https://imgur.com/HLBi0dp.gif)

## Introdu��o

O Jogo dos Dados � um jogo simples baseado em turnos, onde o jogador compete contra o computador para ver quem alcan�a primeiro a linha de chegada. O jogo implementa eventos especiais que podem acelerar ou retardar o progresso dos participantes.

Regras do Jogo

1. O jogo ocorre em uma pista com um limite de 30 casas.
2. O jogador e o computador jogam alternadamente.
3. Cada turno, um dado � sorteado (valores entre 1 e 6) para determinar o avan�o.
4. Eventos especiais ocorrem em determinadas posi��es:

- Avan�o extra (+3 casas):

	- Posi��es: 5, 10, 15, 25

- Recuo (-2 casas):

	- Posi��es: 7, 13, 20

5. O primeiro a alcan�ar ou ultrapassar a linha de chegada vence.

## Tecnologias

[![Tecnologias](https://skillicons.dev/icons?i=git,github,cs,dotnet,visualstudio)](https://skillicons.dev)

## Como utilizar

1. Clone o reposit�rio ou baixe o c�digo fonte.
2. Abra o terminal ou o prompt de comando e navegue at� a pasta raiz
3. Utilize o comando abaixo para restaurar as depend�ncias do projeto.

```
dotnet restore
```

4. Em seguida, compile a solu��o utilizando o comando:
   
```
dotnet build --configuration Release
```

5. Para executar o projeto compilando em tempo real
   
```
dotnet run --project JogoDosDados.ConsoleApp
```


## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compila��o e execu��o do projeto.