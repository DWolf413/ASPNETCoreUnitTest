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

            Assert.That(cliente.ClienteNombre, Is.EqualTo("David Logacho"));
            ClassicAssert.AreEqual(cliente.ClienteNombre, "David Logacho");
            Assert.That(cliente.ClienteNombre, Does.Contain("Logacho"));
            Assert.That(cliente.ClienteNombre, Does.Contain("logacho").IgnoreCase);
            Assert.That(cliente.ClienteNombre, Does.StartWith("David"));
            Assert.That(cliente.ClienteNombre, Does.EndWith("Logacho"));
        }

        [Test]
        public void ClientNombre_NoValues_ReturnNull()
        {
            //Cliente cliente = new();
            //cliente.CrearNombreCompleto("David", "Logacho");
            ClassicAssert.IsNull(cliente.ClienteNombre);
        }
    }
}
