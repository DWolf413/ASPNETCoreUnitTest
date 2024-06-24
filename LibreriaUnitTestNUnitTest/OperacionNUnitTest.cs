using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace LibreriaUnitTest
{
    [TestFixture]
    public class OperacionNUnitTest
    {
        [Test]
        public void SumarNumeros_InputDosNumeros_GetValorCorrecto()
        {
            //1. Arrange: Inicializar las variables o componentes que ejecutaran el test
            Operacion op = new();
            int numero1Test = 50;
            int numeor2Test = 69;

            //2. Act: Ejecucion de la Operacion
            int resultado = op.SumarNumeros(numero1Test, numeor2Test);

            //3. Assert: Comparacion de resultado, propio de UNIT TEST
            ClassicAssert.AreEqual(119, resultado);

        }

        [Test]
        public void IsValorPar_InputNumeroPar_ReturnFalse()
        {
            Operacion op = new();
            int numeroImpar = 7;

            bool isPar = op.IsValorPar(numeroImpar);
            ClassicAssert.IsFalse(isPar); //Assert.That(isPar, Is.EqualTo(false))
        }

        [Test]
        public void IsValorPar_InputNumeroPar_ReturnTrue()
        {
            Operacion op = new();
            int numeroPar = 8;

            bool isPar = op.IsValorPar(numeroPar);
            Assert.That(isPar, Is.EqualTo(true));
        }

        [Test]
        [TestCase(4, 4)] //Poner coma para mas parametros
        [TestCase(6, 100)]
        [TestCase(20, 100)]
        public void IsValorPar_InputNumeroParParm_ReturnTrue(int numeroPar, int numeroX)
        {
            Operacion op = new();

            bool isPar = op.IsValorPar(numeroPar);
            Assert.That(isPar, Is.EqualTo(true));
        }

        [Test]
        [TestCase(3, ExpectedResult = false)]
        [TestCase(5, ExpectedResult = true)]
        [TestCase(7, ExpectedResult = false)]
        public bool IsValorPar_InputNumeroParParam_ReturnFalse(int numeroImpar)
        {
           Operacion op = new();

           return op.IsValorPar(numeroImpar);
          
        }

        [Test]
        [TestCase(2.2, 1.2)] //Resultado debe ser 3.4
        [TestCase(2.23, 1.24)] // resultado 3.47
        [TestCase(2.23, 2.24)] // resultado 4.47
        public void SumarDecimal_InputDosNumeros_GetValorCorrecto(double decimal1Test, double decimal2Test)
        {
            
            Operacion op = new();

            
            double resultado = op.SumarDecimal(decimal1Test, decimal2Test);

            //3.3 -> 3.5
            ClassicAssert.AreEqual(3.4, resultado, 2);

        }

    }
}
