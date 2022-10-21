using System;
using xadrez;
using tabuleiro;

namespace xadrez_console {
    internal class Program {
        static void Main(string[] args) {

            PosicaoXadrez pos = new PosicaoXadrez('c', 7);

            pos.toPosicao();

            Console.WriteLine(pos.toPosicao());

            Console.ReadLine();
        }
    }
}