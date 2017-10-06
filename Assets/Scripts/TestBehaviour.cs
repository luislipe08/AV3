using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.AttributeUsage(System.AttributeTargets.Field)]
public class PotionSelectorAttribute : PropertyAttribute
{
}
public class TestBehaviour : MonoBehaviour
{
	[PotionSelector]
	public string potion;
    public void Update()
    {
        for (int i = 0; i < PotionDB.Instance.potions.Length; i++ )
        {
            if (PotionDB.Instance.potions[i].name == potion)
            {
                Debug.Log(PotionDB.Instance.potions[i].heal);

            }
            
            }
    }
}
//Dudu que me ajudou
   

