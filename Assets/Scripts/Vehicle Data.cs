using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Vehicle Data")]
public class VehicleData : ScriptableObject
{
    //Upgradable for transportation of products
    public int vehicleCapacity;
    public string vehicleName;
    public int vehiclePrice;
    public int vehicleTier;


}
