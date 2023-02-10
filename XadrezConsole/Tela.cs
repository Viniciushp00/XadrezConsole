using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

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

                    //If para testar se existe alguma peça naquela casa do tabuleiro
                    if (tab.peca(i, j) is null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        imprimirPeca(tab.peca(i, j));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void imprimirPeca(Peca peca)
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
        }
    }
}
