using HahnRaphaelWeb.Domain.Commands;

namespace HahnRaphaelWeb.Tests.CommandTests
{
    [TestClass]
    public class CreateProductCommandTest
    {
        private readonly CreateProductCommand _invalidCommand = new CreateProductCommand("a","a",0);

        private readonly CreateProductCommand _validCommand = new CreateProductCommand("banana", "that`s a normal description", 1);


        [TestMethod]
        public void Command_invalid()
        {
            _invalidCommand.Validate();
            Assert.AreEqual(false, _invalidCommand.Validate(_invalidCommand).IsValid);
            
        }

        [TestMethod]
        public void Command_valid()
        {
            _validCommand.Validate();
            Assert.AreEqual(true, _validCommand.Validate(_validCommand).IsValid);
        }
    }
}