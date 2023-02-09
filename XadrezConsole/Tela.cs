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
            for(int i=0;i<tab.Linhas;i++)
            {
                for(int j = 0; j < tab.Colunas; j++)
                {
                    //If para testar se existe alguma peça naquela casa do tabuleiro
                    if (tab.peca(i, j) is null)
                    {
                        Console.Write("- ");
                    }
                    else
                        Console.Write(tab.peca(i,j) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
