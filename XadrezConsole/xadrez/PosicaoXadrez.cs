using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace xadrez
{
    //Classe criada para ajustar a indexação da matriz para ficar no padrão de um tabuleiro
    internal class PosicaoXadrez
    {
        public char Coluna { get; set; }
        public int Linha { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            Coluna = coluna;
            Linha = linha;
        }

        //Metodo que irá tranformar uma posição do tipo PosicaoXadrez em uma Posicao
        public Posicao toPosicao()
        {
            /*
             *Logica da linha : Como as linhas no tabuleiro de xadrez são vista de cima pra baixo, ou seja, a
             *primeira linha de cima para baixo em um tabuleiro real e representado pelo número 1, e na matriz é
             *o contrario ou seja 7.
             *Então para transformamos a linha do tabuleiro em uma posição de matriz iremos subtrair o valor que da
             *PosicaoXadrez por 8.
             *
             *Logica da coluna: Colocamos (Coluna - 'a'), pois o caracter "a" possui um código que é um numéro inteiro, ou seja,
             *caso a letra digitada seja "a", essa logica irá pegar o código do letra a digitada e substrair pelo código da letra
             *"a" que inserimos, que no final irá dar 0, e como as demais letras seguem uma sequencia de números, o código de 
             *"b" é o codigo de "a"-1, então caso seja digitado a letra "b", sabemos que estamos nós referindo a posição, 1
             *da matriz.
            */

            return new Posicao(8 - Linha,Coluna - 'a');

        }

        public override string ToString()
        {
            // "" foi utilizado para forçar que o retorno seja uma string
            return "" + Coluna + Linha;
        }
    }
}
