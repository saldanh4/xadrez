using tabuleiro;
using xadrez;

class Program
{
    static void Main(string[] args)
    {

        try
        {
            PartidaDeXadrez partida = new PartidaDeXadrez();
            while(!partida.terminada)
            {
                Console.Clear();
                Tela.imprimirTabuleiro(partida.tab);

                Console.Write("\nOrigem: ");
                Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();
                Console.Clear();
                Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

                Console.Write("\nDestino: ");
                Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                partida.executaMovimento(origem, destino);
                Console.Clear();
            }

            
        }
        catch(TabuleiroException e)
        {
            Console.WriteLine(e.Message);
        }
        
    }
}