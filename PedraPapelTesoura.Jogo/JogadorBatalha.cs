using System;

namespace PedraPapelTesoura.Jogo
{
    public class JogadorBatalha
    {
        public Jogador Vencedor(Jogador jogador1, Jogador jogador2)
        {
            if (jogador1.GetOpcao() == jogador2.GetOpcao())
                throw new Exception("Houve um empate.");

            if (jogador1.EhPedra() && jogador2.EhTesoura())
                return jogador1;
            if (jogador1.EhPapel() && jogador2.EhPedra())
                return jogador1;
            if (jogador1.EhTesoura() && jogador2.EhPapel())
                return jogador1;

            return jogador2;
        }
    }
}
