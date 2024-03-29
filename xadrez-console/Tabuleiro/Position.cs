﻿namespace tabuleiro
{
    class Position
    {
        public int linha { get; set; }
        public int coluna { get; set; }

        public Position(int linha, int coluna)
        {
            this.linha = linha; // palavra this autoreferencia
            this.coluna = coluna;
        }

        public override string ToString()
        {
            return linha+", "+coluna;
        }
    }
}
