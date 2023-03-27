using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(TireCode))]
public class TireCodeDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        EditorGUI.BeginProperty(position, label, property);

        SerializedProperty width = property.FindPropertyRelative("Width");
        SerializedProperty aspectRatio = property.FindPropertyRelative("AspectRatio");
        SerializedProperty diameter = property.FindPropertyRelative("Diameter");

        Rect labelPosition = new(position.x, position.y, position.width, position.height);

        position = EditorGUI.PrefixLabel(
            labelPosition,
            GUIUtility.GetControlID(FocusType.Passive),
            label
        );

        int indent = EditorGUI.indentLevel;
        EditorGUI.indentLevel = 0;

        const float offset = 15;
        float widthSize = position.width / 3 - offset * 1.5f;

        Rect position1 = new(position.x, position.y, widthSize, position.height);
        Rect position2 = new(position.x + offset, position.y, widthSize, position.height);
        Rect position3 = new(position.x + widthSize + offset * 1.75f, position.y, widthSize, position.height);
        Rect position4 = new(position.x + widthSize + offset * 2.75f, position.y, widthSize, position.height);
        Rect position5 = new(position.x + widthSize * 2 + offset * 3.35f, position.y, widthSize, position.height);
        Rect position6 = new(position.x + widthSize * 2 + offset * 4.5f, position.y, widthSize , position.height);

        EditorGUI.PrefixLabel(position1, new GUIContent("P"));
        EditorGUI.PropertyField(position2, width, GUIContent.none);
        EditorGUI.PrefixLabel(position3, new GUIContent("/"));
        EditorGUI.PropertyField(position4, aspectRatio, GUIContent.none);
        EditorGUI.PrefixLabel(position5, new GUIContent("R"));
        EditorGUI.PropertyField(position6, diameter, GUIContent.none);

        EditorGUI.indentLevel = indent;

        EditorGUI.EndProperty();
    }
}