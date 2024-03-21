using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Product Data")]
public class ProductData : ScriptableObject
{
    public float productQuantity = 0;

    //Upgradables of product itself
    public float productSpentPerService = 1f;
    public int productCapacity;

}
