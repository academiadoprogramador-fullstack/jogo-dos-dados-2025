namespace JogoDosDados.ConsoleApp;

public class Jogador
{
    public int posicao;

    public void AvancarPosicao(int resultadoLancamento)
    {
        posicao += resultadoLancamento;
    }
}
