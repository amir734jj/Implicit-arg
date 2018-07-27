using ImplicitArg;

namespace ImplicitArgs.Tests.Models
{
    public class DummyCallee : ImplicitArg<DummyCallee>
    {
        public string Foo() => GetCalleThis<DummyCaller>().DummyProperty;
    }
}