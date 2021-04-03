using NUnit.Framework;
using ArrayProcessor;

namespace TestArrayProcessor
{
    public class Tests
    {
        private ArrayObject _arrayObject;
        [SetUp]
        public void Setup()
        {
            _arrayObject = new ArrayObject(new []{1, 2, 3, 4, 5, 6, 7});
        }

        [Test]
        public void Test_GetSumOfElements_()
        {
            Assert.IsTrue(_arrayObject.GetSumOfElements() == 28);
        }
        
        [Test]
        public void Test_GetMaxValue_()
        {
            Assert.IsTrue(_arrayObject.GetMaxValue() == 7);
        }
    }
}