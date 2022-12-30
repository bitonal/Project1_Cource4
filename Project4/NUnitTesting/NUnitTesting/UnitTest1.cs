using NUnit.Framework;
using DataAccessLogicLayer;
namespace NUnitTesting
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void Test1()
        {
            //Assign or Arrange
            int pid = 101;
            string ptype = "Chicken Pizza";

            //Act
            string acname = PizzaHelper.GetENameById(pid);

            //Assert

            Assert.AreEqual(ptype, acname);
            Assert.Pass();
        }
        [Test]
        public void Test2()
        {
            //Assign or Arrange
            int pid = 102;
            string ptype = "Margherita";

            //Act
            string acname = PizzaHelper.GetENameById(pid);

            //Assert

            Assert.AreEqual(ptype, acname);
            Assert.Pass();
        }
        [Test]
        public void Test3()
        {
            //Assign or Arrange
            int pid = 102;
            string ptype = "Margherita";

            //Act
            string acname = PizzaHelper.GetENameById(pid);

            //Assert

            Assert.AreEqual(ptype, acname);
            Assert.Pass();
        }



    }
}