using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace xadrez
{
    class PosicaoXadrez 
    {
        public char Coluna { get; set; }
        public int Linha { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            Coluna = coluna;
            Linha = linha;
        }

        public Posicao ToPosicao()
        {
            return new Posicao(8 - Linha, Coluna - 'a');
            // o 'a' char tem valor de 97 na tabela ASCII e assim é possivel fazer a operação Coluna - 'a' para definir a coluna na matriz
        }

        public override string ToString()
        {
            return "" + Coluna + Linha; 
        }
    }
}
