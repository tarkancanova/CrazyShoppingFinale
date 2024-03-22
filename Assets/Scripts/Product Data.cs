using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Product Data")]
public class ProductData : ScriptableObject
{
    public double productQuantity = 0;

    //Upgradables of product itself
    public double productSpentPerService = 1f;
    public int productCapacity;

}
