using tabuleiro;

namespace xadrez
{
    class Torre : Peca
    {
        public Cor corTorre { get; private set; }   
        public Torre(Cor cor, Tabuleiro tab) : base(cor, tab)
        {
            corTorre = cor;            
        }

        public override string ToString()
        {
            if(corTorre == Cor.Preta)
            {
                return " \x2656 ";
            }
            return " \x265C ";
        }

    }
}