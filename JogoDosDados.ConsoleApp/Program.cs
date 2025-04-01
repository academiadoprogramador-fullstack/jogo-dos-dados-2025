namespace JogoDosDados.ConsoleApp
{
    // Versão 5 - Implementação Orientada a Objetos
    internal class Program
    {
        static void Main(string[] args)
        {
            const int limiteLinhaChegada = 30;

            while (true)
            {
                Menu menu = new Menu();
                LancadorDados lancadorDados = new LancadorDados();

                Jogador usuario = new Jogador("Usuário");

                Jogador computador = new Jogador("ChatGPT");

                Jogador[] jogadores = [usuario, computador];

                bool jogoEmAndamento = true;

                while (jogoEmAndamento)
                {
                    for (int contadorJogador = 0; contadorJogador < jogadores.Length; contadorJogador++)
                    {
                        Jogador jogadorAtual = jogadores[contadorJogador];

                        menu.ExibirCabecalho(jogadorAtual.nome);

                        int resultadoSorteio = lancadorDados.Sortear();

                        menu.ExibirResultadoSorteio(resultadoSorteio);

                        jogadorAtual.AvancarPosicao(resultadoSorteio);

                        menu.ExibirPosicaoJogador(limiteLinhaChegada, jogadorAtual.posicao);

                        if (jogadorAtual.EstaNaPosicaoAvancoEspecial())
                        {
                            menu.ExibirMensagemAvancoEspecial();

                            jogadorAtual.AvancarPosicaoEspecial();

                            menu.ExibirPosicaoAvancoEspecial(jogadorAtual.posicao);
                        }

                        else if (jogadorAtual.EstaNaPosicaoRecuoEspecial())
                        {
                            menu.ExibirMensagemRecuoEspecial();

                            jogadorAtual.RecuarPosicaoEspecial();

                            menu.ExibirPosicaoRecuoEspecial(jogadorAtual.posicao);
                        }

                        if (jogadorAtual.UltrapassouLinhaChegada(limiteLinhaChegada))
                        {
                            menu.ExibirMensagemVitoria();

                            jogoEmAndamento = false;
                            continue;
                        }

                        Console.ReadLine();
                    }
                }

                Console.Write("Deseja continuar? (s/N) ");
                string opcaoContinuar = Console.ReadLine()!.ToUpper();

                if (opcaoContinuar != "S")
                    break;
            }
        }

       
    }
}
