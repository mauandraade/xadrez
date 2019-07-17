using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.colocarPeca(new Torre(tab, Cor.Preta),new Position(0, 0));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Position(1, 3));
            tab.colocarPeca(new Rei(tab, Cor.Branca), new Position(2, 4));
           

            Tela.imprmirTabuleiro(tab);


            Console.ReadLine();
        }
    }
}
