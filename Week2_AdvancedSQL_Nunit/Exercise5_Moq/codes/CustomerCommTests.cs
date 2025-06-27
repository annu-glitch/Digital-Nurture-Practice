using NUnit.Framework;
using Moq;
using CustomerCommLib;

namespace CustomerComm.Tests
{
    [TestFixture]
    public class CustomerCommTests
    {
        private Mock<IMailSender> _mockMailSender;    
        private CustomerComm1 _customerComm;

        [SetUp]
        public void Setup()
        {
            _mockMailSender = new Mock<IMailSender>();   //create mock controller

            _mockMailSender
                .Setup(m => m.SendMail("2205448@kiit.ac.in", "Welcome to our service!"))       //setup rules: to always return true
                .Returns(true);

            _customerComm = new CustomerComm1(_mockMailSender.Object);         //create mock object
        }

        [Test]
        public void SendMailToCustomer_ReturnsTrue_WhenMailSentSuccessfully()
        {
            var result = _customerComm.SendMailToCustomer();

            Assert.IsTrue(result);

            _mockMailSender.Verify(              //verify how many times the method was called
                m => m.SendMail("2205448@kiit.ac.in", "Welcome to our service!"),
                Times.Once);
        }
    }
}
