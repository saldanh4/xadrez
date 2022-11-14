﻿using tabuleiro;
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
                try
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);
                    System.Console.WriteLine("\nTurno: " + partida.turno);
                    System.Console.WriteLine("Aguardando jogada: " + partida.jogadorAtual);

                    Console.Write("\nOrigem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    partida.validarPoscaoDeOrigem(origem);

                    bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

                    Console.Write("\nDestino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                    partida.validarPosicaoDeDestino(origem, destino);

                    partida.realizaJogada(origem, destino);
                    Console.Clear();
                }
                catch(TabuleiroException e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                }
                
            }

            
        }
        catch(TabuleiroException e)
        {
            Console.WriteLine(e.Message);
            Console.ReadLine();
        }
        
    }
}