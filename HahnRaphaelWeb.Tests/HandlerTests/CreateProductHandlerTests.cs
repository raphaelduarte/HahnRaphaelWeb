using HahnRaphaelWeb.Domain.Commands;
using HahnRaphaelWeb.Domain.Handlers;
using HahnRaphaelWeb.Tests.Repositories;

namespace HahnRaphaelWeb.Tests.HandlerTests
{
    [TestClass ]
    public class CreateProductHandlerTests
    {
        public CreateProductHandlerTests() { }
        private readonly CreateProductCommand  _InvalidCommand = new CreateProductCommand("", "", 0);
        private readonly CreateProductCommand _ValidCommand = new CreateProductCommand("banana", "That's a normal test", 1);
        private readonly ProductHandler _handler = new ProductHandler(new FakeProductRepository());
        private GenericCommandResult _result = new GenericCommandResult();

        [TestMethod]
        public void CreateProduct_Handler_invalid()
        {
            _result = (GenericCommandResult)_handler.Handle(_InvalidCommand);
            Assert.AreEqual(_result.Success, false);
        }

        [TestMethod]
        public void CreateProduct_Handler_valid()
        {
            _result = (GenericCommandResult)_handler.Handle(_ValidCommand);
            Assert.AreEqual(_result.Success, true);
        }
    }
}
