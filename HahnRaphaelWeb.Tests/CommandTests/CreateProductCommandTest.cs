using HahnRaphaelWeb.Domain.Commands;

namespace HahnRaphaelWeb.Tests.CommandTests
{
    [TestClass]
    public class CreateProductCommandTest
    {
        [TestMethod]
        public void Command_invalid()
        {
            var commandInvalid = new CreateProductCommand("", "",0);
            commandInvalid.Validate();
            Assert.AreEqual(commandInvalid.Validate(commandInvalid).IsValid,false);
        }

        [TestMethod]
        public void Command_valid()
        {
            var commandValid = new CreateProductCommand("banana", "that`s a normal description", 1);
            Assert.AreEqual(commandValid.Validate(commandValid).IsValid, true);
        }
    }
}