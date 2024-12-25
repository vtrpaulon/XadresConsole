using XadresConsole.tabuleiro;

namespace XadresConsole.xadres;

class Rei : Peca
{
    public Rei(Tabuleiro tabuleiro, Cor cor) : base (tabuleiro, cor)
    {
            
    }
    public override string ToString()
    {
        return "R";
    }
}