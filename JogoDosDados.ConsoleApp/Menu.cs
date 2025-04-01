namespace JogoDosDados.ConsoleApp;

// Responsável por apresentar interações com o usuário
public class Menu
{
    public void ExibirCabecalho(string nomeJogador)
    {
        Console.Clear();
        Console.WriteLine("----------------------------------");
        Console.WriteLine("Jogo dos Dados");
        Console.WriteLine("----------------------------------");
        Console.WriteLine($"Rodada do {nomeJogador}");
        Console.WriteLine("----------------------------------");
        Console.Write("Pressione ENTER para lançar o dado...");
        Console.ReadLine();
    }

    public void ExibirResultadoSorteio(int resultadoUsuario)
    {
        Console.WriteLine("----------------------------------");
        Console.WriteLine($"O valor sorteado foi: {resultadoUsuario}!");
        Console.WriteLine("----------------------------------");
    }

    public void ExibirPosicaoJogador(int posicaoUsuario, int limiteLinhaChegada)
    {
        Console.WriteLine($"O jogador está na posição: {posicaoUsuario} de {limiteLinhaChegada}!");
    }

    public void ExibirMensagemAvancoEspecial()
    {
        Console.WriteLine("----------------------------------");
        Console.WriteLine("EVENTO ESPECIAL: Avanço extra de 3 casas!");
    }

    public void ExibirPosicaoAvancoEspecial(int posicaoUsuario)
    {
        Console.WriteLine($"O jogador avançou para a posição: {posicaoUsuario}!");
        Console.WriteLine("----------------------------------");
    }

    public void ExibirMensagemRecuoEspecial()
    {
        Console.WriteLine("----------------------------------");
        Console.WriteLine("EVENTO ESPECIAL: Recuo de 2 casas!");
    }

    public void ExibirPosicaoRecuoEspecial(int posicaoUsuario)
    {
        Console.WriteLine($"O jogador recuou para a posição: {posicaoUsuario}!");
        Console.WriteLine("----------------------------------");
    }

    public void ExibirMensagemVitoria(string nomeUsuario)
    {
        Console.WriteLine($"{nomeUsuario} alcançou a linha de chegada!");
    }
}
