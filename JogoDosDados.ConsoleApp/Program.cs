﻿namespace JogoDosDados.ConsoleApp
{
    // Versão 5 - Implementação Orientada a Objetos
    internal class Program
    {
        static void Main(string[] args)
        {
            const int limiteLinhaChegada = 30;

            while (true)
            {
                int posicaoUsuario = 0;
                int posicaoComputador = 0;

                bool jogoEmAndamento = true;

                while (jogoEmAndamento)
                {
                    Menu menu = new Menu();

                    menu.ExibirCabecalho();

                    int resultadoUsuario = SortearDado();

                    menu.ExibirResultadoSorteio(resultadoUsuario);

                    posicaoUsuario += resultadoUsuario;

                    menu.ExibirPosicaoJogador(limiteLinhaChegada, posicaoUsuario);

                    if (posicaoUsuario == 5 || posicaoUsuario == 10 || posicaoUsuario == 15 || posicaoUsuario == 25)
                    {
                        menu.ExibirMensagemAvancoEspecial();

                        posicaoUsuario += 3;

                        menu.ExibirPosicaoAvancoEspecial(posicaoUsuario);

                    }
                    else if (posicaoUsuario == 7 || posicaoUsuario == 13 || posicaoUsuario == 20)
                    {
                        menu.ExibirMensagemRecuoEspecial();

                        posicaoUsuario -= 2;

                        menu.ExibirPosicaoRecuoEspecial(posicaoUsuario);
                    }

                    if (posicaoUsuario >= limiteLinhaChegada)
                    {
                        menu.ExibirMensagemVitoria();

                        jogoEmAndamento = false;
                        continue;
                    }

                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("Rodada do Computador");
                    Console.WriteLine("----------------------------------");
                    Console.Write("Pressione ENTER para visualizar a rodada do computador...");
                    Console.ReadLine();

                    int resultadoComputador = SortearDado();

                    Console.WriteLine("----------------------------------");
                    Console.WriteLine($"O valor sorteado foi: {resultadoComputador}!");
                    Console.WriteLine("----------------------------------");

                    posicaoComputador += resultadoComputador;

                    Console.WriteLine($"O computador está na posição: {posicaoComputador} de {limiteLinhaChegada}!");

                    if (posicaoComputador == 5 || posicaoComputador == 10 || posicaoComputador == 15 || posicaoComputador == 25)
                    {
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("EVENTO ESPECIAL: Avanço extra de 3 casas!");

                        posicaoComputador += 3;

                        Console.WriteLine("----------------------------------");
                        Console.WriteLine($"O computador avançou para a posição: {posicaoComputador}!");
                        Console.WriteLine("----------------------------------");

                    }
                    else if (posicaoComputador == 7 || posicaoComputador == 13 || posicaoComputador == 20)
                    {
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("EVENTO ESPECIAL: Recuo de 2 casas!");

                        posicaoComputador -= 2;

                        Console.WriteLine("----------------------------------");
                        Console.WriteLine($"O computador recuou para a posição: {posicaoComputador}!");
                        Console.WriteLine("----------------------------------");
                    }

                    if (posicaoComputador >= limiteLinhaChegada)
                    {
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("Que pena! O computador alcançou a linha de chegada, tente novamente!");
                        Console.WriteLine("----------------------------------");

                        jogoEmAndamento = false;
                        continue;
                    }

                    Console.ReadLine();
                }

                Console.Write("Deseja continuar? (s/N) ");
                string opcaoContinuar = Console.ReadLine()!.ToUpper();

                if (opcaoContinuar != "S")
                    break;
            }
        }

        static int SortearDado()
        {
            Random geradorDeNumeros = new Random();

            int resultado = geradorDeNumeros.Next(1, 7);

            return resultado;
        }
    }
}
