using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Product Data")]
public class ProductData : ScriptableObject
{
    public double productQuantity = 0;

    public string mainProduct;

    public void MainProductAssigner()
    {
        mainProduct = "Sausage"; // Default product type
    }

    //Upgradables of product itself
    public double productSpentPerService = 1f;
    public int productCapacity;
    public double productPerSec;

}
