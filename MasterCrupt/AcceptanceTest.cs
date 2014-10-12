using NUnit.Framework;

namespace MasterCrupt
{
    [TestFixture]
    public class AcceptanceTest
    {
        [Test]
        public void TestSecret()
        {
            UI ui = new UI();
            Assert.That(ui.EncryptMessage("Secret"), Is.EqualTo("Leeted: S3cr3t"));
        }
    }
}
