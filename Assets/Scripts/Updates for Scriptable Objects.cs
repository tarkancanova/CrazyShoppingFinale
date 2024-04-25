using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdatesforScriptableObjects : MonoBehaviour
{
    [SerializeField] private PlayerData _playerData;
    [SerializeField] private CustomerData _customerData;
    [SerializeField] private StoreData _storeData;
    [SerializeField] private ProductData _productData;

    // Start is called before the first frame update
    void Awake()
    {
        ResetValues();
    }

    private void Update()
    {
        UpdateTotalStoreCapacity();
        if (_productData.productQuantity < 0)
            _productData.productQuantity = 0;
    }


    private void UpdateTotalStoreCapacity()
    {
        _storeData.totalStoreCapacity = _storeData.sausage2MaxStoreCapacity + _storeData.sausage3MaxStoreCapacity + _storeData.sausage4MaxStoreCapacity + _storeData.sausageMaxStoreCapacity;
    }

    public void ResetValues()
    {
        _playerData.Money = 0;

        _productData.productQuantity = 0;
        _productData.productSpentPerService = 1;
        _productData.productPerSec = 0;

        _customerData.customersGoingToStores = 0;
        _customerData.customersGoingToSausageShop = 0;
        _customerData.customersGoingToSausage4 = 0;
        _customerData.customersGoingToSausage3 = 0;
        _customerData.customersGoingToSausage2 = 0;
        _customerData.peopleSpendDurationMultiplier = 1f;
        _customerData.movementSpeedMultiplier = 1f;
        _customerData.serveTimeMultiplier = 1f;

        _storeData.sausage4MaxStoreCapacity = 0;
        _storeData.sausage3MaxStoreCapacity = 0;
        _storeData.sausage2MaxStoreCapacity = 0;
        _storeData.sausageMaxStoreCapacity = 5;
        _storeData.sausage2Open = false;
        _storeData.sausage3Open = false;
        _storeData.sausage4Open = false;
    }
}
