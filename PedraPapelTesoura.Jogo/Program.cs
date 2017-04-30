
using System;

namespace PedraPapelTesoura.Jogo
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new Jogo();
            jogo.IncluirJogador("Armando", Opcao.PAPEL);
            jogo.IncluirJogador("Dave", Opcao.TESOURA);
            jogo.IncluirJogador("Richard", Opcao.PEDRA);
            jogo.IncluirJogador("Michael", Opcao.TESOURA);
            jogo.IncluirJogador("Allen", Opcao.TESOURA);
            jogo.IncluirJogador("Omer", Opcao.PAPEL);
            jogo.IncluirJogador("David E.", Opcao.PEDRA);
            jogo.IncluirJogador("Richard X.", Opcao.PAPEL);

            jogo.BuscarCampeao();

            Console.ReadKey();

        }
    }

    

    
}
