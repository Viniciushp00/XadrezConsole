using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace tabuleiro
{
    internal abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimento { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            Posicao = null;
            Cor = cor;
            Tab = tab;
            QteMovimento = 0;
        }

        public void incrementarQteMovimento()
        {
            QteMovimento++;
        }

        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = movimentosPossiveis();
            for (int i = 0; i < Tab.Linhas; i++)
            {
                for (int j = 0; j < Tab.Colunas; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool podeMoverPara(Posicao pos)
        {
            return movimentosPossiveis()[pos.Linha, pos.Coluna];
        }

        /*
         * Como a classe peça e muito generica para definir os movimentos de cada peça, será necessário tornar esse metódo
         * e a classe em abstratos, para que as classes das peças consigam utilizar ela.
        */
        public abstract bool[,] movimentosPossiveis();
    }
}
