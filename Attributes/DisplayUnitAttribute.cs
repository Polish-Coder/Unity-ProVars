using UnityEngine;

public class DisplayUnitAttribute : PropertyAttribute
{
    public readonly string Unit;

    public DisplayUnitAttribute(string unit)
    {
        Unit = unit;
    }
}