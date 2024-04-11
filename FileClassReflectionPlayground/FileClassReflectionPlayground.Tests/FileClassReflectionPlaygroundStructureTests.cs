using System.Reflection;
using System.Text.RegularExpressions;
using FluentAssertions;

namespace FileClassReflectionPlayground.Tests;

public class FileClassReflectionPlaygroundStructureTests
{
    [Theory]
    [MemberData(nameof(PublicImplementationTypes), DisableDiscoveryEnumeration = false)]
    public void ImplementationDetail_IsNotPublic(Type type)
    {
        type.Should().Be(typeof(EmptyType));
    }

    [Theory]
    [MemberData(nameof(VisibleNonPublicTypes), DisableDiscoveryEnumeration = false)]
    public void VisibleContract_IsPublic(Type type)
    {
        type.Should().Be(typeof(EmptyType));
    }

    public static TheoryData<Type> PublicImplementationTypes = new (
        AssemblyHelper
            .GetAllTypes()
            .Where(type =>
                type.ShouldBeImplementationDetail()
                && type.IsPublic)
            .Union(new[] { typeof(EmptyType) })
            .ToArray());

    public static TheoryData<Type> VisibleNonPublicTypes = new(
        AssemblyHelper
            .GetAllTypes()
            .Where(type =>
                type.ShouldBeVisibleToOthers()
                && type.IsNotPublic
                && !type.IsFileScoped()
                && !type.IsNested)
            .Union(new[] { typeof(EmptyType) })
            .ToArray());
}

file static class AssemblyHelper
{
    private static ICollection<Assembly> assemblies = new []
    {
        typeof(Program).Assembly,
    };

    public static ICollection<Type> GetAllTypes()
        => assemblies
            .SelectMany(assembly => assembly
                .GetTypes()
                .Where(type => type.Namespace?.Contains("FileClassReflection") ?? false))
            .ToArray();
}

file static class TypeExtensions
{
    public static bool ShouldBeVisibleToOthers(this Type type)
        => !type.ShouldBeImplementationDetail();

    public static bool ShouldBeImplementationDetail(this Type type)
        => type.Namespace?.Contains("implementation.detail") ?? false;

    public static bool IsFileScoped(this Type type)
        => Regex.IsMatch(type.Name, "^<[a-zA-Z]+>[A-F0-9]+__.*$");
}