using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestesUnitarios.Services;

namespace TestesUnitariosTests;
{
    public class ValidacoesListaTeste
    {
        private ValidacoesLista _validacoes = new ValidacoesLista();

        [Fact]
        public void DeveRemoverNumerosNegativosDeUmaLista()
        {
            // Arrange
            var lista = new List<int> { 5, -1, -8, 9 };
            var resultadoEsperado = new List<int> { 5, 9 };

            // Act
            var resultado = _validacoes.RemoverNumerosNegativos(lista);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void DeveConterONumero9NaLista()
        {
            // Arrange
            var lista = new List<int> { 5, -1, -8, 9 };
            var numeroParaProcurar = 9;

            // Act
            var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

            // Assert
            Assert.True(resultado);
        }

        [Fact]
        public void NaoDeveConterONumero10NaLista()
        {
            // Arrange
            var lista = new List<int> { 5, -1, -8, 9 };
            var numeroParaProcurar = 10;

            // Act
            var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

            // Assert
            Assert.False(resultado); // Como o número 10 não está na lista, o resultado deve ser falso
        }

        [Fact] // Corrigido para [Fact]
        public void DeveMultiplicarOsElementosDaListaPor2()
        {
            // Arrange
            var lista = new List<int> { 5, 7, 8, 9 };
            var resultadoEsperado = new List<int> { 10, 14, 16, 18 };
            
            // Act
            var resultado = _validacoes.MultiplicarNumerosLista(lista, 2);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void DeveRetornar9ComoMaiorNumeroDaLista()
        {
            // Arrange
            var lista = new List<int> { 5, -1, -8, 9 };

            // Act
            var resultado = _validacoes.RetornarMaiorNumeroLista(lista);

            // Assert
            Assert.Equal(9, resultado); // O maior número da lista é 9
        }

        [Fact]
        public void DeveRetornarOitoNegativoComoMenorNumeroDaLista()
        {
            // Arrange
            var lista = new List<int> { 5, -1, -8, 9 };

            // Act
            var resultado = _validacoes.RetornarMenorNumeroLista(lista);

            // Assert
            Assert.Equal(-8, resultado); // O menor número da lista é -8
        }
    }
}