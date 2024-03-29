﻿using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace xadrez
{
    class PosicaoXadrez
    {
        public char coluna { get; set; }
        public int linha { get; set; }
        public PosicaoXadrez(char coluna, int linha)
        {
            this.coluna = coluna;
            this.linha = linha;
        }

        public Position toPosicao()
        {
            return new Position(8 - linha, coluna - 'a');
        }
        public override string ToString()
        {
            return ""+ coluna + linha;
        }
    }
}
