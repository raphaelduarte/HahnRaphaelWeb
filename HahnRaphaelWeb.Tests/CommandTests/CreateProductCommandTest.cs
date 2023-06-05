using HahnRaphaelWeb.Domain;
using HahnRaphaelWeb.Domain.Commands;

namespace HahnRaphaelWeb.Tests.CommandTests
{
    [TestClass]
    public class CreateProductCommandTest
    {
        private readonly CreateProductCommand _invalidCommand = new CreateProductCommand("","",0);

        private readonly CreateProductCommand _validCommand = new CreateProductCommand("banana", "that`s a normal description", 1);


        [TestMethod]
        public void Command_invalid()
        {
            CreateProductValidator validator = new CreateProductValidator();
            var resultInvalid = validator.Validate(_invalidCommand).IsValid;
            Assert.AreEqual(false, resultInvalid);
            
        }

        [TestMethod]
        public void Command_valid()
        {
            CreateProductValidator validator = new CreateProductValidator();
            var resultValid = validator.Validate(_validCommand).IsValid;
            Assert.AreEqual(true, resultValid);
        }
    }
}