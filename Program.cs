using System.Runtime.InteropServices;
using SistemaJogoDeXadrez;
using SistemaJogoDeXadrez.tabuleiro;
using SistemaJogoDeXadrez.xadrez;

// PosicaoXadrez pos = new PosicaoXadrez('a', 1);

// System.Console.WriteLine(pos.toPosicao());
try
{
    PartidaDeXadrez partida = new PartidaDeXadrez();

    while(!partida.Terminada)
    {
        Console.Clear();
        Tela.ImprimirTabuleiro(partida.Tab);

        System.Console.WriteLine("Origem: ");
        Posicao origem = Tela.LerPosicaoXadrez().toPosicao();
        System.Console.WriteLine("Destino: ");
        Posicao destino = Tela.LerPosicaoXadrez().toPosicao();

        partida.ExecutaMovimento(origem, destino);
    }

}
catch(TabuleiroException e)
{
    System.Console.WriteLine(e.Message);
}



