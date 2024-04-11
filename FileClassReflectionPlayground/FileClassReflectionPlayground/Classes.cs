namespace FileClassReflectionPlayground;

using static D;

public class A;

internal class B;

file class C;

public class D
{
    public static Type HType => typeof(H);
    public static Type Type => typeof(I);

    public class E;
    internal class F;
    protected internal class G;
    protected class H;
    private class I;
}

public static class ClassTypes
{
    public static Type A => typeof(A);
    public static Type B => typeof(B);
    public static Type C => typeof(C);
    public static Type D => typeof(D);
    public static Type E => typeof(E);
    public static Type F => typeof(F);
    public static Type G => typeof(G);
    public static Type H => HType;
    public static Type I => Type;
}