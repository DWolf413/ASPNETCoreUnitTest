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
    }
}
