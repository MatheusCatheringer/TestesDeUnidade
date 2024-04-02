using CalculadoraCientifica;

namespace CalculadoraCientificaTests
{
    [TestClass]
    public class Calculadora4OperaçõesTests
    {
        [TestMethod]
        public void Test_soma_dois_numeros()
        {
            //cenario
            int num1 = 20;
            int num2 = 22;
            int resultadoEsperado = 42;
            Calculadora4Operacoes calc = new Calculadora4Operacoes();

            //acão
            int resultadoObitido= calc.Somar(num1, num2 );

            // verificação

            Assert.AreEqual(resultadoObitido, resultadoEsperado, 0, "Falha na realização da soma");
            
        }

        [TestMethod]
        public void Teste_divisao_dois_numeros()
        {
            //cenario
            int num1 = 20;
            int num2 = 2;
            int resultadoEsperado = 10;
            Calculadora4Operacoes calc = new Calculadora4Operacoes();

            //acão
            int resultadoObitido = calc.dividir(num1, num2);

            // verificação

            Assert.AreEqual(resultadoObitido, resultadoEsperado, 0, "Falha na realização da Divisão");

        }
    }

}