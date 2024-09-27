using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestesUnitarios.Services;

namespace TestesUnitariosTests
{
    public class ValidacoesStringTeste
    {
        private ValidacoesString _validacoes = new ValidacoesString();

        [Fact]
        public void DeveRetornarQuantidadeDeCaracteresCorreta()
        {
            // Arrange
            var texto = "Teste";
            var quantidadeEsperada = 5;

            // Act
            var resultado = _validacoes.RetornarQuantidadeCaracteres(texto);

            // Assert
            Assert.Equal(quantidadeEsperada, resultado);
        }

        [Fact]
        public void DeveConterCaractereNoTexto()
        {
            // Arrange
            var texto = "Teste de validação";
            var textoProcurado = "de";

            // Act
            var resultado = _validacoes.ContemCaractere(texto, textoProcurado);

            // Assert
            Assert.True(resultado); // O texto contém "de"
        }

        [Fact]
        public void NaoDeveConterCaractereNoTexto()
        {
            // Arrange
            var texto = "Teste de validação";
            var textoProcurado = "abc";

            // Act
            var resultado = _validacoes.ContemCaractere(texto, textoProcurado);

            // Assert
            Assert.False(resultado); // O texto não contém "abc"
        }

        [Fact]
        public void DeveTerminarComDeterminadoTexto()
        {
            // Arrange
            var texto = "Teste de validação";
            var textoProcurado = "validação";

            // Act
            var resultado = _validacoes.TextoTerminaCom(texto, textoProcurado);

            // Assert
            Assert.True(resultado); // O texto termina com "validação"
        }

        [Fact]
        public void NaoDeveTerminarComDeterminadoTexto()
        {
            // Arrange
            var texto = "Teste de validação";
            var textoProcurado = "Teste";

            // Act
            var resultado = _validacoes.TextoTerminaCom(texto, textoProcurado);

            // Assert
            Assert.False(resultado); // O texto não termina com "Teste"
        }
    }
}