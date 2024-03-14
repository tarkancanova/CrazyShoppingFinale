using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] private PlayerData _playerData;


    public void ServeProduct(float price)
    {
        _playerData.Money += price;
    }


}
