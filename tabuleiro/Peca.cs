using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaJogoDeXadrez.tabuleiro
{
    public abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdeMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            Posicao = null;
            Tab = tab;
            Cor = cor;
            QtdeMovimentos = 0;
        }

        public void IncrementarQtdeMovimentos()
        {
            QtdeMovimentos++;
        }

        public bool ExisteMovimentoPossiveis()
        {
            bool[,] mat = MovimentosPossiveis();
            for(int i = 0; i < Tab.Linhas; i++)
            {
                for(int j = 0; j < Tab.Colunas; j++)
                {
                    if(mat[i,j])
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool PodeMoverPara(Posicao pos)
        {
            return MovimentosPossiveis()[pos.Linha, pos.Coluna];

        }

        public abstract bool[,] MovimentosPossiveis();     

    }
}