using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaJogoDeXadrez.tabuleiro;
using SistemaJogoDeXadrez.xadrez;

namespace SistemaJogoDeXadrez
{
    public class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
   
            for(int i = 0; i < tab.Linhas; i++)
            {
                System.Console.Write(8 - i + " ");
                for(int j = 0; j < tab.Colunas; j++)
                {      
                    Tela.ImprimirPeca(tab.Peca(i, j));
                }

                System.Console.WriteLine();
            }
            System.Console.WriteLine("  a b c d e f g h");
        }

        public static void ImprimirTabuleiro(Tabuleiro tab, bool[,] posicoesPossiveis)
        {
   
            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGray;
            for(int i = 0; i < tab.Linhas; i++)
            {
                System.Console.Write(8 - i + " ");
                for(int j = 0; j < tab.Colunas; j++)
                {      
                    if(posicoesPossiveis[i,j])
                    {
                        Console.BackgroundColor = fundoAlterado;
                    }
                    else 
                    {
                        Console.BackgroundColor = fundoOriginal;
                    }
                    Tela.ImprimirPeca(tab.Peca(i, j));
                }

                System.Console.WriteLine();
            }
            System.Console.WriteLine("  a b c d e f g h");
            Console.BackgroundColor = fundoOriginal;
        }



        public static PosicaoXadrez LerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }

        public static void ImprimirPeca(Peca peca)
        {
            if(peca == null)
            {
                System.Console.Write("- ");
            }
            else 
            {
                if(peca.Cor == Cor.Branca)
                {
                    System.Console.Write(peca);
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    System.Console.Write(peca);
                    Console.ForegroundColor = aux;
                }
                System.Console.Write(" ");
            }
        }
    }
}