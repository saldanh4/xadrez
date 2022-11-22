using tabuleiro;

namespace xadrez
{
    class Rei : Peca
    {
        public Cor corRei { get; private set; }
        private PartidaDeXadrez partida;

        public Rei(Cor cor, Tabuleiro tab, PartidaDeXadrez partida) : base(cor, tab)
        {            
            this.partida = partida;
            corRei = cor;
        }

        public override string ToString()
        {
                 return " \x265A ";   
        }
        private bool testeTorreParaRoque(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p != null && p is Torre && p.cor == cor && p.qtdMovimentos == 0;
        }
        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao pos = new Posicao(0, 0);
            
            //acima
            pos.definirValores(posicao.linha - 1, posicao.coluna);
            if(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //nordeste
            pos.definirValores(posicao.linha - 1, posicao.coluna + 1);
            if(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //leste
            pos.definirValores(posicao.linha, posicao.coluna + 1);
            if(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //sudeste
            pos.definirValores(posicao.linha + 1, posicao.coluna + 1);
            if(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //sul
            pos.definirValores(posicao.linha + 1, posicao.coluna);
            if(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //sudoeste
            pos.definirValores(posicao.linha + 1, posicao.coluna - 1);
            if(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //oeste
            pos.definirValores(posicao.linha, posicao.coluna - 1);
            if(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //noroeste
            pos.definirValores(posicao.linha - 1, posicao.coluna - 1);
            if(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //#especial roque
            if(qtdMovimentos==0 && !partida.xeque)
            {
                // #especial roque pequeno
                Posicao posTorreDireita = new Posicao(posicao.linha, posicao.coluna + 3);
                if(testeTorreParaRoque(posTorreDireita))
                {
                    Posicao casaLivre1 = new Posicao(posicao.linha, posicao.coluna + 1);
                    Posicao casaLivre2 = new Posicao(posicao.linha, posicao.coluna + 2);
                    if(tab.peca(casaLivre1) == null && tab.peca(casaLivre2)==null)
                    {
                        mat[posicao.linha, posicao.coluna+2] = true;
                    }
                }
                //#especial roque grande
                Posicao posTorreEsquerda = new Posicao(posicao.linha, posicao.coluna - 4);
                if(testeTorreParaRoque(posTorreEsquerda))
                {
                    Posicao casaLivre1 = new Posicao(posicao.linha, posicao.coluna - 1);
                    Posicao casaLivre2 = new Posicao(posicao.linha, posicao.coluna - 2);
                    Posicao casaLivre3 = new Posicao(posicao.linha, posicao.coluna - 3);
                    if(tab.peca(casaLivre1) == null && tab.peca(casaLivre2) == null && tab.peca(casaLivre3) == null)
                    {
                        mat[posicao.linha, posicao.coluna - 2] = true;
                    }
                }
            }

            
            return mat;
        }

    }
}