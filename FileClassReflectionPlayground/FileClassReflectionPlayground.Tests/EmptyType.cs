using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace FileClassReflectionPlayground.Tests;

internal class EmptyType : Type
{
    public override object[] GetCustomAttributes(bool inherit) => [];

    public override object[] GetCustomAttributes(Type attributeType, bool inherit) => [];

    public override bool IsDefined(Type attributeType, bool inherit) => false;

    public override Module Module => null!;
    public override string? Namespace => string.Empty;
    public override string Name => nameof(EmptyType);
    protected override TypeAttributes GetAttributeFlagsImpl() => TypeAttributes.Class;

    protected override ConstructorInfo? GetConstructorImpl(
        BindingFlags bindingAttr,
        Binder? binder,
        CallingConventions callConvention,
        Type[] types, ParameterModifier[]? modifiers)
        => null;

    public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) => [];

    public override Type? GetElementType() => null;

    public override EventInfo? GetEvent(string name, BindingFlags bindingAttr) => null;

    public override EventInfo[] GetEvents(BindingFlags bindingAttr) => [];

    public override FieldInfo? GetField(string name, BindingFlags bindingAttr) => null;


    public override FieldInfo[] GetFields(BindingFlags bindingAttr) => [];

    public override MemberInfo[] GetMembers(BindingFlags bindingAttr) => [];

    protected override MethodInfo? GetMethodImpl(
        string name,
        BindingFlags bindingAttr,
        Binder? binder,
        CallingConventions callConvention,
        Type[]? types,
        ParameterModifier[]? modifiers)
        => null;

    public override MethodInfo[] GetMethods(BindingFlags bindingAttr) => [];

    public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) => [];

    public override object? InvokeMember(
        string name,
        BindingFlags invokeAttr,
        Binder? binder,
        object? target,
        object?[]? args,
        ParameterModifier[]? modifiers,
        CultureInfo? culture,
        string[]? namedParameters)
        => null;

    public override Type UnderlyingSystemType => this;

    protected override bool IsArrayImpl() => false;

    protected override bool IsByRefImpl() => false;

    protected override bool IsCOMObjectImpl() => false;

    protected override bool IsPointerImpl() => false;

    protected override bool IsPrimitiveImpl() => false;

    public override Assembly Assembly => Assembly;
    public override string? AssemblyQualifiedName => null;
    public override Type? BaseType => null;
    public override string? FullName => null;
    public override Guid GUID => Guid.Empty;

    protected override PropertyInfo? GetPropertyImpl(
        string name,
        BindingFlags bindingAttr,
        Binder? binder,
        Type? returnType,
        Type[]? types,
        ParameterModifier[]? modifiers)
        => null;

    protected override bool HasElementTypeImpl() => false;

    public override Type? GetNestedType(string name, BindingFlags bindingAttr) => null;

    public override Type[] GetNestedTypes(BindingFlags bindingAttr) => [];

    public override Type? GetInterface(string name, bool ignoreCase) => null;

    public override Type[] GetInterfaces() => [];
}