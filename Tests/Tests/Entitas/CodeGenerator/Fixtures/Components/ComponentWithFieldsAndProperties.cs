#pragma warning disable
using Entitas;
using Entitas.CodeGenerator;

[Pool("Core")]
public class ComponentWithFieldsAndProperties : IComponent {

    // Has one public field

    public string publicField;
    public static bool publicStaticField;
    bool _privateField;
    static bool _privateStaticField;

    // Has one public property

    public string publicProperty { get; set; }
    public static bool publicStaticProperty { get; set; }
    bool _privateProperty { get; set; }
    static bool _privateStaticProperty { get; set; }
}
