using System;
using XadresConsole.tabuleiro;
using XadresConsole.xadres;


namespace XadresConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadres pos = new PosicaoXadres('a', 1);

            /*
            try
             {
                 Tabuleiro tabuleiro = new Tabuleiro(8, 8);

                 tabuleiro.colocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(0,0));
                 tabuleiro.colocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(1,3));
                 tabuleiro.colocarPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(2,4));

                 Tela.imprimirTabuleiro(tabuleiro);
             }
             catch (TabuleiroException e)
             {
                 Console.WriteLine(e.Message);

        }
            Console.ReadLine();
        }
        */
            Console.WriteLine(pos);
            Console.WriteLine(pos.toPosicao());
            Console.ReadLine();
        }
    }
}