﻿using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            /*try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));*/
            /*tab.colocarPeca(???, new Posicao(6, 4));
            tab.colocarPeca(???, new Posicao(7, 0));
            tab.colocarPeca(???, new Posicao(7, 5));
            tab.colocarPeca(???, new Posicao(7, 7));
            */


            /*Tela.imprimirTabuleiro(tab);

        }
        catch (TabuleiroException e)
        {
            Console.WriteLine(e.Message);
        }*/
            PosicaoXadrez pos = new PosicaoXadrez('h', 5);
            Console.WriteLine(pos);
            Console.WriteLine(pos.toPosicao());
            
            Console.ReadLine();
        }
    }
}