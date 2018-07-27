## Implicit-arg

This an attempt to bring implicit arguments (currently only available in Scala) to C#. To use it, just extend the abstract class `class DummyCallee : ImplicitArg<DummyCallee>`, then call the `SetCalleThis(caller or some other instance)` on callee, all done.


```csharp
// Arrange
var caller = new DummyCaller();

var callee = new DummyCallee()
    .SetCalleThis(caller)
    .Self();

// Act, Assert
Assert.Equal(caller.DummyProperty, callee.Foo());
```
