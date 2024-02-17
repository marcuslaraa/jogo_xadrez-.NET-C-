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
        try 
        {
            Console.Clear();
            Tela.ImprimirTabuleiro(partida.Tab);
            System.Console.WriteLine();
            System.Console.WriteLine("Turno: " + partida.Turno);
            System.Console.WriteLine("Aguardando jogada: " + partida.JogadorAtual);


            System.Console.WriteLine("Origem: ");
            Posicao origem = Tela.LerPosicaoXadrez().toPosicao();
            partida.ValidarPosicaoDeOrigem(origem);

            bool[,] posicoesPossiveis = partida.Tab.Peca(origem).MovimentosPossiveis();

            Console.Clear();
            Tela.ImprimirTabuleiro(partida.Tab, posicoesPossiveis);


            System.Console.WriteLine("Destino: ");
            Posicao destino = Tela.LerPosicaoXadrez().toPosicao();
            partida.ValidarPosicaoDeDestino(origem, destino);

            partida.RealizaJogada(origem, destino);
        }
        catch(TabuleiroException e)
        {
            System.Console.WriteLine(e.Message);
            Console.ReadLine();
        }
        
    }

}
catch(TabuleiroException e)
{
    System.Console.WriteLine(e.Message);
}

Console.ReadLine();





