
using System;
using System.Collections.Generic;

namespace PedraPapelTesoura.Jogo
{
    public class Jogo
    {
        List<Jogador> jogadores;
        JogadorBatalha jogadorBatalha;
        int numeroJogada;
        public Jogo()
        {
            jogadorBatalha = new JogadorBatalha();
            jogadores = new List<Jogador>();
            numeroJogada = 0;
        }

        public void IncluirJogador(Jogador jogador)
        {
            jogadores.Add(jogador);
        }

        public void IncluirJogador(string nomeJogador, Opcao opcao)
        {
            jogadores.Add(new Jogador(nomeJogador,opcao));
        }

        public Jogador BuscarCampeao()
        {
            var quantidadeJogadores = jogadores.Count;
            if (quantidadeJogadores == 0 || (quantidadeJogadores % 2) == 1)
                throw new Exception("Quantidade jogadores inválida.");

            Console.WriteLine("Início de jogo: {0} jogadores...", quantidadeJogadores);

            var rodada = 0;

            List<Jogador> vencedores = jogadores;
            while (vencedores.Count > 1)
            {
                Console.WriteLine("===++ Rodada {0} ++===", ++rodada);
                vencedores = BatalharRodada(vencedores);
                Console.WriteLine();
            }
            var campeao = vencedores[0];
            Console.WriteLine();
            Console.WriteLine("Grande Vencedor:" + campeao.Imprimir());

            return campeao;
        }

        private List<Jogador> BatalharRodada(List<Jogador> atuaisJogadores)
        {
            var vencedores = new List<Jogador>();

            var enumJogadores = atuaisJogadores.GetEnumerator();

            while (enumJogadores.MoveNext())
            {
                Console.WriteLine("== Jogada {0} ==", ++numeroJogada);
                var jogador1 = enumJogadores.Current;

                if(!enumJogadores.MoveNext())
                {
                    vencedores.Add(jogador1);
                    Console.WriteLine(string.Format("Vencedor: {0} *W.O.", jogador1.Imprimir()));
                    break;
                }
                var jogador2 = enumJogadores.Current;
                Console.WriteLine(string.Format("Batalha: {0} x {1}", jogador1.Imprimir(), jogador2.Imprimir()));
                var vencedor = jogadorBatalha.Vencedor(jogador1, jogador2);
                vencedores.Add(vencedor);
                Console.WriteLine(string.Format("Vencedor: {0}", vencedor.Imprimir()));
            }
            
            return vencedores;
        }

    }
}
