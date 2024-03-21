using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Customer Data")]
public class CustomerData : ScriptableObject
{
    public float peopleSpeedForSpend = 1f;

    public float movementSpeedMultiplier = 1f;

    public int customersGoingToStores;

    public int customersGoingToSausageShop = 0;
    public int customersGoingToSausage2 = 0;
    public int customersGoingToSausage3 = 0;
    public int customersGoingToSausage4 = 0;
}
