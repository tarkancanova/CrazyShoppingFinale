using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Store Data")]
public class StoreData : ScriptableObject
{
    //Checking if stores are open or not
    public bool sausage2Open = false;
    public bool sausage3Open = false;
    public bool sausage4Open = false;

    //Maximum store capacities
    public int sausageMaxStoreCapacity = 5;
    public int sausage2MaxStoreCapacity = 0;
    public int sausage3MaxStoreCapacity = 0;
    public int sausage4MaxStoreCapacity = 0;

    public int totalStoreCapacity;

    public bool boughtCafe;
    public bool boughtMarket;
    public bool boughtBarber;


}
