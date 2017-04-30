using System;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace PedraPapelTesoura.Jogo.Tests
{
    [TestFixture]
    public class JogadaTests
    {
        JogadorBatalha jogo;
        Jogador jogadorPedra = new Jogador("PEDRA", Opcao.PEDRA);
        Jogador jogadorPapel = new Jogador("PAPEL", Opcao.PAPEL);
        Jogador jogadorTesoura = new Jogador("TESOURA", Opcao.TESOURA);
        [SetUp]
        public void SetUp()
        {
            jogo = new JogadorBatalha();
        }

        [Test]
        public void Deve_quebrar_se_a_jogada_for_invalida()
        {
            var throwException = Assert.Throws<ArgumentException>(() => new Jogador("João", Opcao.NENHUMA));
            Assert.AreEqual("Opção inválida.", throwException.Message);
        }

        [Test]
        public void Deve_quebrar_avisando_jogadores_empatados()
        {
            var throwException = Assert.Throws<Exception>(() => jogo.Vencedor(jogadorPedra, jogadorPedra));
            Assert.AreEqual("Houve um empate.", throwException.Message);
        }

        [Test]
        public void Deve_retornar_jogador_pedra_sobre_tesoura()
        {
            Jogador vencedor = jogo.Vencedor(jogadorPedra, jogadorTesoura);
            Assert.AreEqual(jogadorPedra, vencedor);
        }

        [Test]
        public void Deve_retornar_jogador_papel_sobre_pedra()
        {
            Jogador vencedor = jogo.Vencedor(jogadorPapel, jogadorPedra);
            Assert.AreEqual(jogadorPapel, vencedor);
        }

        [Test]
        public void Deve_retornar_jogador_tesoura_sobre_papel()
        {
            Jogador vencedor = jogo.Vencedor(jogadorTesoura, jogadorPapel);
            Assert.AreEqual(jogadorTesoura, vencedor);
        }

        [Test]
        public void Deve_retornar_jogador_inverso_pedra_sobre_tesoura()
        {
            Jogador vencedor = jogo.Vencedor(jogadorTesoura, jogadorPedra);
            Assert.AreEqual(jogadorPedra, vencedor);
        }

        [Test]
        public void Deve_retornar_jogador_inverso_papel_sobre_pedra()
        {
            Jogador vencedor = jogo.Vencedor(jogadorPedra, jogadorPapel);
            Assert.AreEqual(jogadorPapel, vencedor);
        }

        [Test]
        public void Deve_retornar_jogador_inverso_tesoura_sobre_papel()
        {
            Jogador vencedor = jogo.Vencedor(jogadorPapel, jogadorTesoura);
            Assert.AreEqual(jogadorTesoura, vencedor);
        }
    }
}
