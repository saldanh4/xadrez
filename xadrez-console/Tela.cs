using tabuleiro;

namespace xadrez
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGray;
            
                
            
            Console.BackgroundColor = fundoOriginal;
            int x = 0;
            for(int i = 0; i < tab.linhas; i++)
            {
                System.Console.Write(tab.linhas - i + " ");
                for (int j = 0; j < tab.colunas; j++)
                {
                    if(x%2 == 0)
                    {
                        Console.BackgroundColor = fundoAlterado;
                    }
                    else
                    {
                        Console.BackgroundColor = fundoOriginal;
                    }
                    
                    if (tab.peca(i, j) == null)
                    {
                        System.Console.Write("   ");
                    }
                    else
                    {
                        imprimirPeca(tab.peca(i, j));
                    }
                    x++;
                }
                x--;
                Console.BackgroundColor = fundoOriginal;
                System.Console.WriteLine();
                
            }
            System.Console.WriteLine("   A  B  C  D  E  F  G  H");
        }

        public static PosicaoXadrez lerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }
        public static void imprimirPeca(Peca peca)
        {
            if(peca.cor == Cor.Branca)
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }
    }
}