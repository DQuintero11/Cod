namespace NUnitTest
{
    using Codifico.WebAPI.Interfaces;
    using Codifico.WebAPI.Interfaces.Business;
    using Codifico.WebAPI.Objects.BaseClass;
    using Codifico.WebAPI.Repository;
    using Codifico.WebAPI.Repository.Persistency;
    using Moq;
    using NUnit.Framework;

    [TestFixture]
    public class EmployeeTest
    {
        private Mock<IEmployeeRepository> _mockRepositorio;
        private EmployeeServices _employeeServicio;

        [SetUp]
        public void SetUp()
        {
            _mockRepositorio = new Mock<IEmployeeRepository>();
            _employeeServicio = new EmployeeServices(_mockRepositorio.Object);
        }

        [Test]
        public void ObtenerClientePorId_DeberiaRetornarClienteExistente()
        {
            // Arrange: 
            var EmployeeEsperado = new List<Employees> {
                new Employees { empid = 1, lastname = "Juan" , firstname= "Pepe"}
            };
            _mockRepositorio.Setup(r => r.ObtenerTodos()).Returns(EmployeeEsperado);

            // Act: 
            var resultado = _employeeServicio.GetAllUsers();

            // Assert
            Assert.AreEqual(EmployeeEsperado.Count, resultado.Count);
            Assert.AreEqual(EmployeeEsperado[0].empid, resultado[0].empid);
  
        }
    }
}