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
    public class ProductsTest
    {
        private Mock<IProductsRepository> _mockRepositorio;
        private ProductsServices _ProductsServicio;

        [SetUp]
        public void SetUp()
        {
            _mockRepositorio = new Mock<IProductsRepository>();
            _ProductsServicio = new ProductsServices(_mockRepositorio.Object);
        }

        [Test]
        public void ObtenerClientePorId_DeberiaRetornarClienteExistente()
        {
            // Arrange: 
            var ProductEsperado = new List<Products> {
                new Products { productid = 1, productname = "product1"}
            };
            _mockRepositorio.Setup(r => r.ObtenerTodos()).Returns(ProductEsperado);

            // Act: 
            var resultado = _ProductsServicio.GetAllUsers();

            // Assert
            Assert.AreEqual(ProductEsperado.Count, resultado.Count);
            Assert.AreEqual(ProductEsperado[0].productid, resultado[0].productid);

        }
    }
}