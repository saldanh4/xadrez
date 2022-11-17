using tabuleiro;

namespace xadrez
{
    class Rainha : Peca
    {
        public Rainha (Cor cor, Tabuleiro tab) : base(cor, tab)
        {
        }

        public override string  ToString()
        {
            return " \x265B ";
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];
            Posicao pos = new Posicao(0, 0);

            //Norte
            pos.definirValores(posicao.linha -1, posicao.coluna);
            while(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if(tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirValores(pos.linha -1, pos.coluna);
            }

            //Nordeste
            pos.definirValores(posicao.linha -1, posicao.coluna +1);
            while(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if(tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirValores(pos.linha -1, pos.coluna +1);
            }

            //Leste
            pos.definirValores(posicao.linha, posicao.coluna +1);
            while(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if(tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirValores(pos.linha, pos.coluna +1);
            }

            //Sudeste
            pos.definirValores(posicao.linha +1, posicao.coluna +1);
            while(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if(tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirValores(pos.linha +1, pos.coluna +1);
            }

            //Sul
            pos.definirValores(posicao.linha +1, posicao.coluna);
            while(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if(tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirValores(pos.linha +1, pos.coluna);
            }

            //Sudoeste
            pos.definirValores(posicao.linha +1, posicao.coluna -1);
            while(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if(tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirValores(pos.linha +1, pos.coluna -1);
            }

            //Oeste
            pos.definirValores(posicao.linha, posicao.coluna -1);
            while(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if(tab.peca(pos) != null && tab.peca(pos).cor != cor)
                { 
                    break;
                }
                pos.definirValores(pos.linha, pos.coluna -1);
            }

            //Noroeste
            pos.definirValores(pos.linha -1, posicao.coluna -1);
            while(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if(tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirValores(pos.linha -1, pos.coluna -1);
            }
            
            return mat;
        }

        
    }
}