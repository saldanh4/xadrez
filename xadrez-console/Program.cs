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
                    Tela.imprimirPartida(partida);

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
            Console.Clear();
            Tela.imprimirPartida(partida);
        }
        catch(TabuleiroException e)
        {
            Console.WriteLine(e.Message);
            Console.ReadLine();
        }
        
    }
}