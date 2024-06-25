using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace LibreriaUnitTest
{
    [TestFixture]
    public class ClienteNUnitTest
    {
        private Cliente cliente;

        [SetUp]
        public void Setup()
        {
            cliente = new Cliente();
        }

        [Test]
        public void CrearNombreCompleto_InputNombreApellido_ReturnNombreCompleto()
        {
            //Arreange
            //Cliente cliente = new();

            //Act
            //string nombreCompleto = cliente.CrearNombreCompleto("David", "Logacho");

            cliente.CrearNombreCompleto("David", "Logacho");

            //Assert
            //Assert.That(nombreCompleto, Is.EqualTo("David Logacho"));
            //ClassicAssert.AreEqual(nombreCompleto, "David Logacho");
            //Assert.That(nombreCompleto, Does.Contain("Logacho"));
            //Assert.That(nombreCompleto, Does.Contain("logacho").IgnoreCase);
            //Assert.That(nombreCompleto, Does.StartWith("David"));
            //Assert.That(nombreCompleto, Does.EndWith("Logacho"));


            Assert.Multiple(() =>
            {
                Assert.That(cliente.ClienteNombre, Is.EqualTo("David Logacho"));
                ClassicAssert.AreEqual(cliente.ClienteNombre, "David Logacho");
                Assert.That(cliente.ClienteNombre, Does.Contain("Logacho"));
                Assert.That(cliente.ClienteNombre, Does.Contain("logacho").IgnoreCase);
                Assert.That(cliente.ClienteNombre, Does.StartWith("David"));
                Assert.That(cliente.ClienteNombre, Does.EndWith("Logacho"));

            });

           
        }

        [Test]
        public void ClientNombre_NoValues_ReturnNull()
        {
            //Cliente cliente = new();
            //cliente.CrearNombreCompleto("David", "Logacho");
            ClassicAssert.IsNull(cliente.ClienteNombre); //Evaluar cuando la propiedad es nula, recorda que la propieda no toma hasta el metodo
        }

        [Test]
        public void DescuentoEvaluacion_DefaultCliente_ReturnDescuentoIntervalo()
        {
            int descuento = cliente.Descuento;
            Assert.That(descuento, Is.InRange(5,24));
        }

        [Test]
        public void CrearNombreCompleto_InputNombre_ReturnsNotNull()
        {
            cliente.CrearNombreCompleto("David", "");
            ClassicAssert.IsNotNull(cliente.ClienteNombre);
            ClassicAssert.IsFalse(string.IsNullOrEmpty(cliente.ClienteNombre));
        }

        [Test]
        public void ClienteNombre_InputNombreEnBlanco_ThrowsException()
        {
            var exceptionDetalle = Assert.Throws<ArgumentException>(() => cliente.CrearNombreCompleto("", "Logacho"));

            ClassicAssert.AreEqual("El nombre esta en blanco", exceptionDetalle.Message);
            Assert.That(() => cliente.CrearNombreCompleto("", "Logacho"), Throws.ArgumentException.With.Message.EqualTo("El nombre esta en blanco"));

            Assert.Throws<ArgumentException>(() => cliente.CrearNombreCompleto("", "Logacho"));
            Assert.That(() => cliente.CrearNombreCompleto("", "Logacho"), Throws.ArgumentException);

        }

        [Test]
        public void GetClienteDetalle_CrearClienteConMenos500TotalOrder_ReturnsClienteBasico()
        {
            cliente.OrderTotal = 150;
            var result = cliente.GetClienteDetalle();

            Assert.That(result, Is.TypeOf<ClienteBasico>());
        }

        [Test]
        public void GetClienteDetalle_CrearClienteConMas500TotalOrder_ReturnsClientePremium()
        {
            cliente.OrderTotal = 700;
            var result = cliente.GetClienteDetalle();

            Assert.That(result, Is.TypeOf<ClientePremium>());
        }
    }
}
