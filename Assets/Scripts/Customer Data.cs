using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Customer Data")]
public class CustomerData : ScriptableObject
{
    public float sausageServeTimeMultiplier = 1f;
    public float sausage2ServeTimeMultiplier = 1f;
    public float sausage3ServeTimeMultiplier = 1f;
    public float sausage4ServeTimeMultiplier = 1f;

    public float adamSmith = 1f;

    public int sausageMaxStoreCapacity = 5;
    public int sausage2MaxStoreCapacity = 0;
    public int sausage3MaxStoreCapacity = 0;
    public int sausage4MaxStoreCapacity = 0;

    public int customersGoingToStores;

    public int customersGoingToSausageShop = 0;
    public int customersGoingToSausage2 = 0;
    public int customersGoingToSausage3 = 0;
    public int customersGoingToSausage4 = 0;
}
