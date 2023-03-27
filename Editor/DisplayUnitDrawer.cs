using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(DisplayUnitAttribute))]
public class DisplayUnitDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        var displayUnit = attribute as DisplayUnitAttribute;

        EditorGUI.BeginProperty(position, label, property);
        position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

        Rect valueRect = new Rect(position.position, new Vector2(position.width - 60f, position.height));
        Rect unitRect = new Rect(position.position + new Vector2(position.width - 50f, 0f), new Vector2(50f, position.height));

        EditorGUI.PropertyField(valueRect, property, GUIContent.none);
        EditorGUI.LabelField(unitRect, displayUnit?.Unit);

        EditorGUI.EndProperty();
    }
}