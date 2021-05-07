using System;
using System.Collections.Generic;
using System.Text;

namespace Xadrez.tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; set; }
        public int qteMoviventos { get; protected set; }
        public Tabuleiro tabuleiro { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.tabuleiro = tab;
            this.cor = cor;
            this.qteMoviventos = 0;
        }

        public abstract bool[,] movimentosPossiveis();


        public void incrementarQteMovimentos()
        {
            qteMoviventos++;
        }

    }
}
