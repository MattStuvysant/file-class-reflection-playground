using System.Text;
using FluentAssertions;
using FluentAssertions.Execution;

namespace FileClassReflectionPlayground.Tests;

public class WriteExtensionsTests
{
    [Fact]
    public void Write_Type_Writes()
    {
        var builder = new StringBuilder();
        var writer = new StringWriter(builder);
        Console.SetOut(writer);

        GetType().Write();

        var consoleOutput = builder.ToString();
        using (new AssertionScope())
        {
            consoleOutput.Should().Contain(nameof(WriteExtensionsTests));
            consoleOutput.Should().EndWith($"{Environment.NewLine}{Environment.NewLine}");
        }
    }
}