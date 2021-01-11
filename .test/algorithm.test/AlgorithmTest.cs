using Shouldly;
using Xunit;

namespace algorithm.test
{
    public class AlgorithmTest
    {
        [Fact]
        public void BalancedBrackets()
        {
            var result = StackProblem.IsBalanced("[()]{}{[()()]()}");
            result.ShouldBe(true);

            result = StackProblem.IsBalanced("[(])");
            result.ShouldBe(false);

            result = StackProblem.IsBalanced("([])(){}(())()()");
            result.ShouldBe(true);

            result = StackProblem.IsBalanced("[([])]");
            result.ShouldBe(true);

            result = StackProblem.IsBalanced("{[[]]}[]");
            result.ShouldBe(true);
        }
    }
}
