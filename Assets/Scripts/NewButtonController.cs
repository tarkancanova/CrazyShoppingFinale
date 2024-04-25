using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewButtonController : MonoBehaviour
{
    [SerializeField] private GameObject _storeTab;
    [SerializeField] private GameObject _upgradeTab;
    [SerializeField] private GameObject _vehicleTab;
    [SerializeField] private StoreData _storeData;
    [SerializeField] private VehicleData _vehicleData;
    [SerializeField] private CustomerData _customerData;
    [SerializeField] private ProductData _productData;
    [SerializeField] private GameObject _sausageStore2;
    [SerializeField] private GameObject _pizzaStore2;
    [SerializeField] private GameObject _marketStore2;
    [SerializeField] private GameObject _marketStore3;
    [SerializeField] private GameObject _marketStore4;
    [SerializeField] private GameObject _cafeStore2;
    [SerializeField] private GameObject _cafeStore3;
    [SerializeField] private GameObject _cafeStore4;
    [SerializeField] private GameObject _barberStore2;
    [SerializeField] private GameObject _barberStore3;
    [SerializeField] private GameObject _barberStore4;
    [SerializeField] private GameObject _sausageStore3;
    [SerializeField] private GameObject _pizzaStore3;
    [SerializeField] private GameObject _sausageStore4;
    [SerializeField] private GameObject _pizzaStore4;

    public void CloseStoreTab()
    {
        _storeTab.SetActive(false);
    }    
    public void CloseUpgradeTab()
    {
        _upgradeTab.SetActive(false);
    }
    public void OpenVehicleTab()
    {
        _vehicleTab.SetActive(true);
    }
    public void CloseVehicleTab()
    {
        _vehicleTab.SetActive(false);
    }

    public void IncreaseStore1Cap()
    {
        _storeData.sausageMaxStoreCapacity += 10;
    }

    public void BuyStore2OrIncreaseStore2Cap()
    {
        if (!_storeData.sausage2Open)
        {
            _storeData.sausage2MaxStoreCapacity += 5;
            _storeData.sausage2Open = true;
            if (_productData.mainProduct == "Hamburger")
            {
                _sausageStore2.SetActive(true);
            }
            else if (_productData.mainProduct == "Pizza")
            {
                _pizzaStore2.SetActive(true);
            }
            else if (_productData.mainProduct == "Cafe")
            {
                _cafeStore2.SetActive(true);
            }
            else if (_productData.mainProduct == "Market")
            {
                _marketStore2.SetActive(true);
            }
            else if (_productData.mainProduct == "Barber")
            {
                _barberStore2.SetActive(true);
            }
        }
        else
            _storeData.sausage2MaxStoreCapacity += 10;
    }

    public void BuyStore3OrIncreaseStore3Cap()
    {
        if (!_storeData.sausage3Open)
        {
            _storeData.sausage3Open = true;
            _storeData.sausage3MaxStoreCapacity += 5;
            if (_productData.mainProduct == "Hamburger")
            {
                _sausageStore3.SetActive(true);
            }
            else if (_productData.mainProduct == "Pizza")
            {
                _pizzaStore3.SetActive(true);
            }
            else if (_productData.mainProduct == "Cafe")
            {
                _cafeStore3.SetActive(true);
            }
            else if (_productData.mainProduct == "Market")
            {
                _marketStore3.SetActive(true);
            }
            else if (_productData.mainProduct == "Barber")
            {
                _barberStore3.SetActive(true);
            }
        }
        else
            _storeData.sausage3MaxStoreCapacity += 10;
    }

    public void BuyStore4OrIncreaseStore4Cap()
    {
        if (!_storeData.sausage4Open)
        {
            _storeData.sausage4Open = true;
            _storeData.sausage4MaxStoreCapacity += 5;
            if (_productData.mainProduct == "Hamburger")
            {
                _sausageStore4.SetActive(true);
            }
            else if (_productData.mainProduct == "Pizza")
            {
                _pizzaStore4.SetActive(true);
            }
            else if (_productData.mainProduct == "Cafe")
            {
                _cafeStore4.SetActive(true);
            }
            else if (_productData.mainProduct == "Market")
            {
                _marketStore4.SetActive(true);
            }
            else if (_productData.mainProduct == "Barber")
            {
                _barberStore4.SetActive(true);
            }
        }
        else
            _storeData.sausage4MaxStoreCapacity += 10;
    }

    public void ReduceProductSpent()
    {
        _productData.productSpentPerService *= 0.95f;
    }

    public void IncreaseMovementSpeed()
    {
        _customerData.movementSpeedMultiplier *= 1.1f;
    }

    public void DecreaseSpendDuration()
    {
        _customerData.peopleSpendDurationMultiplier *= 0.95f;
    }

}
