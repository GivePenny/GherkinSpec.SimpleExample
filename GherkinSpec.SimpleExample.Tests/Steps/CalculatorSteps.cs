using GherkinSpec.TestModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GherkinSpec.SimpleExample.Tests.Steps
{
    [Steps]
    public class CalculatorSteps
    {
        readonly Calculator calculator = new Calculator();

        [Given(@"I have (\d+) apples")]
        public void GivenIHaveSomeApples(int number)
        {
            calculator.Store(number);
        }

        [When(@"I add (\d+) more")]
        public void WhenIAddSomeMore(int number)
        {
            calculator.Add(number);
        }

        [Then(@"the result should be (\d+)")]
        public void ThenTheResultShouldBe(int expectedResult)
        {
            Assert.AreEqual(
                expectedResult,
                calculator.Result);
        }
    }
}
