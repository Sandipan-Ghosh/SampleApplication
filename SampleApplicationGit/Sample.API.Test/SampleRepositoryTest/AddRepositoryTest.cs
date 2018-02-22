using Sample.API.Add;
using Xunit;

namespace Sample.API.Test.SampleRepositoryTest
{
    public class AddRepositoryTest
    {
        [Fact]
        public void AddTwoNumbersTest()
        {
            AddRepository addRepository = new AddRepository();
            int firstNumber = 2;
            int secondNumber = 2;
            int result = addRepository.AddTwoNumbers(firstNumber, secondNumber);
            Assert.True(result == 4);
        }
    }
}
