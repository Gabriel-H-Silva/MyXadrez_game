using System;
using tabuleiro;
using xadrez;

namespace Xadrez
{
    class Program
    {
        // incompleto
        public static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                    Console.Write("Destinho: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(origem, destino);
                }
                


                Tela.imprimirTabuleiro(partida.tab);
            }
            catch (TabuleiroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine(); 
        }
    }
}