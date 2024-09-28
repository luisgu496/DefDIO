using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewTalentConsole;
using NuGet.Frameworks;

namespace Teste
{
    public class CalculadoraTeste
    {
        Calculadora calc = new Calculadora();

        [Theory]
        [InlineData(5, 2, 7)]
        public void TesteSomar(int num1, int num2, int resultado)
        {

            int resultadoCalculadora = calc.somar(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);       
        }

                [Theory]
        [InlineData(7, 5, 2)]
        public void TesteSubtrair(int num1, int num2, int resultado)
        {

            int resultadoCalculadora = calc.subtrair(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);       
        }

                [Theory]
        [InlineData(7, 5, 35)]
        public void TesteMultiplicar(int num1, int num2, int resultado)
        {

            int resultadoCalculadora = calc.multiplicar(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);       
        }

                [Theory]
        [InlineData(10, 2, 5)]
        public void TesteDividir(int num1, int num2, int resultado)
        {

            int resultadoCalculadora = calc.dividir(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);       
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Assert.Throws<DivideByZeroException>(
                () => calc.dividir(3,0)
            );
        }

        [Fact]
        public void TestarHistorico()           //RETORNA AS ÚLTIMAS 3 OPERAÇÕES QUE VOC~E FEZ
        {
            calc.somar(1, 2);
            calc.subtrair(2, 3);
            calc.multiplicar(3, 2);
            calc.dividir(4, 1);

            var lista = calc.historico();
            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}