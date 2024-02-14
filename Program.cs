using System.Runtime.InteropServices;
using SistemaJogoDeXadrez;
using SistemaJogoDeXadrez.tabuleiro;
using SistemaJogoDeXadrez.xadrez;

try 
{
    Tabuleiro tab = new Tabuleiro(8,8);


    tab.ColocarPeca( new Torre(tab, Cor.Preta),new Posicao(0,0));
    tab.ColocarPeca( new Torre(tab, Cor.Preta),new Posicao(1,3));
    tab.ColocarPeca( new Rei(tab, Cor.Preta),new Posicao(2,4));
    tab.ColocarPeca( new Rei(tab, Cor.Preta),new Posicao(0,0));

    Tela.ImprimirTabuleiro(tab);

}
catch(TabuleiroException e)
{
    System.Console.WriteLine(e.Message);
}

