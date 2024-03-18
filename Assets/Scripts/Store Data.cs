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

    //Store levels
    public int sausageStore1Level = 1;
    public int sausageStore2Level = 0;
    public int sausageStore3Level = 0;
    public int sausageStore4Level = 0;


}
