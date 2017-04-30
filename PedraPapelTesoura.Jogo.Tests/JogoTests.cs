using NUnit.Framework;
using System;

namespace PedraPapelTesoura.Jogo.Tests
{
    [TestFixture]
    public class JogoTests
    {

        Jogo jogo;
        [SetUp]
        public void SetUp()
        {
            jogo = new Jogo();
        }

        [Test]
        public void Deve_quebrar_quantidade_impar_jogador()
        {
            var throwException = Assert.Throws<Exception>(() => jogo.BuscarCampeao());
            Assert.AreEqual("Quantidade jogadores inválida.", throwException.Message);
        }

        [Test]
        public void Deve_retornar_jogador_campeao()
        {
            var campeao = new Jogador("Richard", Opcao.PEDRA);
            jogo.IncluirJogador("Armando", Opcao.PAPEL);
            jogo.IncluirJogador("Dave", Opcao.TESOURA);
            jogo.IncluirJogador(campeao);
            jogo.IncluirJogador("Michael", Opcao.TESOURA);
            jogo.IncluirJogador("Allen", Opcao.TESOURA);
            jogo.IncluirJogador("Omer", Opcao.PAPEL);
            jogo.IncluirJogador("David E.", Opcao.PEDRA);
            jogo.IncluirJogador("Richard X.", Opcao.PAPEL);

            var resultado = jogo.BuscarCampeao();
            Assert.AreEqual(campeao, resultado);
        }
    }
}
