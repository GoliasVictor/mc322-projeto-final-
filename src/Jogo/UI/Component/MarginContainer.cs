using System.Numerics;

class MarginContainer : UnitaryContainer  {
    float Margin;
    public override Vector2 Size => Component.Size + Vector2.One*Margin*2;
    public MarginContainer(float margin, UIComponent component, Container? parent = null) : base(component, parent)
    {
        Margin = margin;
    }

    public override Vector2 GetPosition(UIComponent component)
    {
        var origin = Parent?.GetPosition(this) ?? Vector2.Zero;
        return Vector2.One*Margin + origin ;
    }

}