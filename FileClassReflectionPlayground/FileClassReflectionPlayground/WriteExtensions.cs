using System.Linq.Expressions;
using System.Reflection;

namespace FileClassReflectionPlayground;

internal static class WriteExtensions
{
    public static void Write(this Type t)
    {
        Console.WriteLine($"Type: {t.Name}");
        t.Write(t => t.IsPublic);
        t.Write(t => t.IsNotPublic);
        t.Write(t => t.IsNested);
        t.Write(t => t.IsVisible);
        Console.WriteLine();
    }

    public static void Write<T>(this Type t, Expression<Func<Type, T>> s)
    {
        var p = (PropertyInfo)((MemberExpression)s.Body).Member;
        var v = p.GetValue(t);

        Console.WriteLine($"{p.Name} = {v}");
    }
}