using tabuleiro;

namespace xadrez_console
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for(int i = 0; i < tab.linhas; i++)
            {
                System.Console.Write(tab.linhas - i + " ");
                for (int j = 0; j < tab.colunas; j++)
                {
                    System.Console.Write(" - ");
                }
                System.Console.WriteLine();
                System.Console.Write(" A ");
            }
        }
    }
}