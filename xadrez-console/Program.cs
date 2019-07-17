using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                

                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprmirTabuleiro(partida.tab);
                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Position origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.Write("Destino: ");
                    Position destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(origem, destino);
                }
            }
            catch(TabuleiroException e) {
                Console.WriteLine(e.Message);
            
            }
            Console.ReadLine();
        }
    }
}
