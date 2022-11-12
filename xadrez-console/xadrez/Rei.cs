using tabuleiro;

namespace xadrez
{
    class Rei : Peca
    {
        public Cor corRei { get; private set; }
        public Rei(Cor cor, Tabuleiro tab) : base(cor, tab)
        {            
            corRei = cor;
        }

        public override string ToString()
        {
            // if(corRei == Cor.Branca)
            // {
            //     return " \x2654 ";
            // }
            // else
            // {
                 return " \x265A ";
            // }
            
        }

    }
}