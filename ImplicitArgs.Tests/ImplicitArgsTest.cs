using Xunit;
using ImplicitArgs.Tests.Models;

namespace ImplicitArgs.Tests
{
    public class ImplicitArgsTest
    {
        [Fact]
        public void Test__Basic()
        {
            // Arrange
            var caller = new DummyCaller();
            
            var callee = new DummyCallee()
                .SetCalleThis(caller)
                .Self();

            // Act, Assert
           Assert.Equal(caller.DummyProperty, callee.Foo());
        }
    }
}