using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(PotionSelectorAttribute))]

public class Lista : PropertyDrawer {
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        int index = 0;
        string[] potions = new string[PotionDB.Instance.potions.Length];
        for (int i = 0;  i < PotionDB.Instance.potions.Length; i++)
        {
            potions[i] = PotionDB.Instance.potions[i].name;
            if (potions[i] == property.stringValue)
            {
                index = i;
            }

        }
        index = EditorGUI.Popup(position, index, potions);
        property.stringValue =  potions[index];
    }

}
