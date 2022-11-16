using tabuleiro;

namespace xadrez
{
    class Tela
    {

        public static void imprimirPartida(PartidaDeXadrez partida)
        {
            imprimirTabuleiro(partida.tab);
            imprimirPecasCapturadas(partida);
            System.Console.WriteLine("\nTurno: " + partida.turno);
            if (!partida.terminada)
            {
                System.Console.WriteLine("Aguardando jogada: " + partida.jogadorAtual);
                if(partida.xeque)
                { 
                    System.Console.WriteLine("Xeque!");
                }
            }
            else
            {
                System.Console.WriteLine("XEQUE MATE!");
                System.Console.WriteLine("Vencedor: " + partida.jogadorAtual);
            }
        }

        public static void imprimirPecasCapturadas(PartidaDeXadrez partida)
        {
            Console.WriteLine("\nPeças capturadas:");
            Console.Write("Brancas: ");
            imprimirConjunto(partida.pecasCapturadas(Cor.Branca));
            Console.Write("\nPretas : ");
            ConsoleColor aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            imprimirConjunto(partida.pecasCapturadas(Cor.Preta));
            Console.ForegroundColor = aux;
        }

        public static void imprimirConjunto(HashSet<Peca> conjunto)
        {
            Console.Write("[");
            foreach(Peca x in conjunto)
            {
                Console.Write(x);
            }
            Console.Write("]");
        }
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
                        imprimirPeca(tab.peca(i, j));
                        x++;
                }
                x--;
                Console.BackgroundColor = fundoOriginal;
                System.Console.WriteLine();
                
            }
            System.Console.WriteLine("   A  B  C  D  E  F  G  H");
        }

        public static void imprimirTabuleiro(Tabuleiro tab, bool[,] posicoesPossiveis)
        {
            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGray;
            ConsoleColor fundoMovimento = ConsoleColor.Gray;
            
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
                        if(posicoesPossiveis[i, j])
                        {
                            Console.BackgroundColor = fundoMovimento;
                        }
                    }
                    else
                    {
                        Console.BackgroundColor = fundoOriginal;
                        if(posicoesPossiveis[i, j])
                        {
                            Console.BackgroundColor = fundoMovimento;
                        }
                    }
                        imprimirPeca(tab.peca(i, j));
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
            if (peca == null)
            {
                System.Console.Write("   ");
            }
            else
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
}