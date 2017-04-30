using System;

namespace PedraPapelTesoura.Jogo
{
    public class Jogador
    {
        private string NomeJogador;
        private Opcao Opcao;

        public Jogador(string nomeJogador, Opcao opcao)
        {
            NomeJogador = nomeJogador;
            Opcao = opcao;
            if (!EhPedra() && !EhPapel() && !EhTesoura())
                throw new ArgumentException("Opção inválida.");
        }

        public bool EhPedra()
        {
            return Opcao == Opcao.PEDRA;
        }

        public bool EhPapel()
        {
            return Opcao == Opcao.PAPEL;
        }

        public bool EhTesoura()
        {
            return Opcao == Opcao.TESOURA;
        }

        public Opcao GetOpcao()
        {
            return Opcao;
        }

        internal string Imprimir()
        {
            return string.Format("{0} ({1})", NomeJogador, Opcao);
        }
    }
}
