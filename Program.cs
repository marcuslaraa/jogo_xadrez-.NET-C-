using System.Runtime.InteropServices;
using SistemaJogoDeXadrez;
using SistemaJogoDeXadrez.tabuleiro;
using SistemaJogoDeXadrez.xadrez;

// PosicaoXadrez pos = new PosicaoXadrez('a', 1);

// System.Console.WriteLine(pos.toPosicao());
Tabuleiro tab = new Tabuleiro(8,8);

tab.ColocarPeca(new Torre(tab, Cor.Branca), new Posicao(0 , 5));
tab.ColocarPeca(new Torre(tab, Cor.Amarela), new Posicao(3 , 6));
Tela.ImprimirTabuleiro(tab);



