﻿//HintName: Mapper.g.cs
// <auto-generated />
#nullable enable
public partial class Mapper
{
    [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
    private partial global::B Map(global::A source)
    {
        var target = new global::B();
        target.Value = MapToD(source.Value);
        return target;
    }

    [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
    private global::D MapToD(global::C source)
    {
        return source switch
        {
            global::C.Value1 => global::D.Value1,
            global::C.Value2 => global::D.Value2,
            _ => throw new global::System.ArgumentOutOfRangeException(nameof(source), source, "The value of enum C is not supported"),
        };
    }
}