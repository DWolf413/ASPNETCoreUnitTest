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
    }
}
