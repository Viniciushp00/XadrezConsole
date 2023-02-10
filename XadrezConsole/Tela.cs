using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;
using xadrez;

namespace XadrezConsole
{
    internal class Tela
    {
        //Classe estatica criada para imprimir o tabuleiro
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            //Implementando o For para passar por todas as casas do tabuleiro
            for (int i = 0; i < tab.Linhas; i++)
            {
                Console.Write(8 - i + " ");

                for (int j = 0; j < tab.Colunas; j++)
                {
                    imprimirPeca(tab.peca(i, j));
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void imprimirTabuleiro(Tabuleiro tab, bool[,] posicoesPossiveis)
        {
            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGray;

            //Implementando o For para passar por todas as casas do tabuleiro
            for (int i = 0; i < tab.Linhas; i++)
            {
                Console.Write(8 - i + " ");

                for (int j = 0; j < tab.Colunas; j++)
                {
                    //Se for possivel mover irá mudar o fundo.
                    if (posicoesPossiveis[i,j])
                    {
                        Console.BackgroundColor = fundoAlterado;
                    }
                    else
                    {
                        Console.BackgroundColor = fundoOriginal;
                    }
                    imprimirPeca(tab.peca(i, j));
                    Console.BackgroundColor = fundoOriginal;
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");

            //Fazendo o fundo voltar ao normal
            Console.BackgroundColor = fundoOriginal;
        }


        public static void imprimirPeca(Peca peca)
        {
            //If para testar se existe alguma peça naquela casa do tabuleiro
            if (peca == null)
            {
                Console.Write("- ");
            }
            else
            {
                if (peca.Cor == Cor.Branca)
                {
                    Console.Write(peca);
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(peca);
                    Console.ForegroundColor = aux;
                }

                Console.Write(" ");
            }
        }

        public static PosicaoXadrez lerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");

            return new PosicaoXadrez(coluna, linha);
        }
    }
}
