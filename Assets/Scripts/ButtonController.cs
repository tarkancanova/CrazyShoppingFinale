using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    [SerializeField] private GameObject _vehicleTab;
    [SerializeField] private GameObject _vehicle1Tab;
    [SerializeField] private GameObject _vehicle2Tab;
    [SerializeField] private GameObject _vehicle3Tab;
    [SerializeField] private GameObject _vehicle4Tab;
    [SerializeField] private GameObject _vehicle1;
    [SerializeField] private GameObject _vehicle2;
    [SerializeField] private GameObject _vehicle3;
    [SerializeField] private GameObject _vehicle4;
    [SerializeField] private VehicleData _vehicle1Data;
    [SerializeField] private VehicleData _vehicle2Data;
    [SerializeField] private VehicleData _vehicle3Data;
    [SerializeField] private VehicleData _vehicle4Data;
    [SerializeField] private VehicleData _vehicle5Data;
    [SerializeField] private VehicleData _vehicle6Data;
    [SerializeField] private VehicleData _vehicle7Data;
    [SerializeField] private VehicleData _vehicle8Data;

    [SerializeField] private GameObject _updateForData;

    [SerializeField] ProductData _productData;
    [SerializeField] CustomerData _customerData;
    [SerializeField] StoreData _storeData;
    [SerializeField] PlayerData _playerData;

    [SerializeField] private GameObject _upgradeTab;
    [SerializeField] private GameObject _storeUpgradesTab;
    [SerializeField] private GameObject _customerUpgradesTab;
    [SerializeField] private GameObject _productTab;
    [SerializeField] private GameObject _hamburgerProductButton;
    [SerializeField] private GameObject _pizzaProductButton;
    [SerializeField] private GameObject _unknownProductButton;


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

    public void ChangeProductToPizza()
    {
        if (_productData.mainProduct == "Hamburger")
        {
            _productData.mainProduct = "Pizza";
            _playerData.restartButton = false;
            SceneManager.LoadScene("SampleScene");
        }
        else
            return;
    }    
    public void ChangeProductToBarber()
    {
        if (_productData.mainProduct == "Pizza")
        {
            _productData.mainProduct = "Barber";
            SceneManager.LoadScene("SampleScene");
        }
        else
            return;
    }       
    public void ChangeProductToCafe()
    {
        if (_productData.mainProduct == "Market")
        {
            _productData.mainProduct = "Cafe";
            SceneManager.LoadScene("SampleScene");
        }
        else
            return;
    }    
    public void ChangeProductToMarket()
    {
        if (_productData.mainProduct == "Barber")
        {
            _productData.mainProduct = "Market";
            SceneManager.LoadScene("SampleScene");
        }
        else 
            return;
    }

    public void RestartGame()
    {
        _playerData.restartButton = true;
        SceneManager.LoadScene("SampleScene");
    }


    public void OpenCloseProductTab()
    {
        if (_productTab.activeSelf)
        {
            _productTab.SetActive(false);
        }
        else if (!_productTab.activeSelf)
        {
            _productTab.SetActive(true);
        }
    }
    public void OpenCloseVehiclesTab()
    {
        if (_vehicleTab.activeSelf)
        {
            _vehicleTab.SetActive(false);
        }        
        else if (!_vehicleTab.activeSelf)
        {
            _vehicleTab.SetActive(true);
        }
    }

    public void OpenCloseUpgradesTab()
    {
        if (_upgradeTab.activeSelf)
        {
            _upgradeTab.SetActive(false);
        }
        else if (!_upgradeTab.activeSelf)
        {
            _upgradeTab.SetActive(true);
        }
    }    
    
    public void OpenCloseCustomerUpgradesTab()
    {
        if (_customerUpgradesTab.activeSelf)
        {
            _customerUpgradesTab.SetActive(false);
        }
        else if (!_customerUpgradesTab.activeSelf)
        {
            _customerUpgradesTab.SetActive(true);
        }
    }    
    
    public void OpenCloseStoreUpgradesTab()
    {
        if (_storeUpgradesTab.activeSelf)
        {
            _storeUpgradesTab.SetActive(false);
        }
        else if (!_storeUpgradesTab.activeSelf)
        {
            _storeUpgradesTab.SetActive(true);
        }
    }

    public void OpenCloseVehicle1Tab()
    {
        if (_vehicle1Tab.activeSelf)
        {
            _vehicle1Tab.SetActive(false);
        }        
        else if (!_vehicle1Tab.activeSelf)
        {
            _vehicle1Tab.SetActive(true);
        }
    }    
    public void OpenCloseVehicle2Tab()
    {
        if (_vehicle2Tab.activeSelf)
        {
            _vehicle2Tab.SetActive(false);
        }        
        else if (!_vehicle2Tab.activeSelf)
        {
            _vehicle2Tab.SetActive(true);
        }
    }    
    public void OpenCloseVehicle3Tab()
    {
        if (_vehicle3Tab.activeSelf)
        {
            _vehicle3Tab.SetActive(false);
        }        
        else if (!_vehicle3Tab.activeSelf)
        {
            _vehicle3Tab.SetActive(true);
        }
    } 
    public void OpenCloseVehicle4Tab()
    {
        if (_vehicle4Tab.activeSelf)
        {
            _vehicle4Tab.SetActive(false);
        }        
        else if (!_vehicle4Tab.activeSelf)
        {
            _vehicle4Tab.SetActive(true);
        }
    }//Open Close Tabs

    public void BuyVehicle1For1()
    {
        if (!_vehicle1.activeSelf)
        {
            _vehicle1.SetActive(true);
            Vehicle vehicle = _vehicle1.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle1Data;
        }
        else
        {
            return;
        }
    }    
    public void BuyVehicle2For1()
    {
        if (!_vehicle1.activeSelf)
        {
            _vehicle1.SetActive(true);
            Vehicle vehicle = _vehicle1.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle2Data;
        }
        else if (_vehicle1.GetComponent<Vehicle>()._vehicleData.vehicleTier < 2)
        {
            Vehicle vehicle = _vehicle1.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle2Data;
        }
        else { return; }
    }    
    public void BuyVehicle3For1()
    {
        if (!_vehicle1.activeSelf)
        {
            _vehicle1.SetActive(true);
            Vehicle vehicle = _vehicle1.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle3Data;
        }
        else if (_vehicle1.GetComponent<Vehicle>()._vehicleData.vehicleTier < 3)
        {
            Vehicle vehicle = _vehicle1.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle3Data;
        }
        else { return; }
    }    
    public void BuyVehicle4For1()
    {
        if (!_vehicle1.activeSelf)
        {
            _vehicle1.SetActive(true);
            Vehicle vehicle = _vehicle1.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle4Data;
        }
        else if (_vehicle1.GetComponent<Vehicle>()._vehicleData.vehicleTier < 4)
        {
            Vehicle vehicle = _vehicle1.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle4Data;
        }
        else { return; }
    }    
    public void BuyVehicle5For1()
    {
        if (!_vehicle1.activeSelf)
        {
            _vehicle1.SetActive(true);
            Vehicle vehicle = _vehicle1.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle5Data;
        }
        else if (_vehicle1.GetComponent<Vehicle>()._vehicleData.vehicleTier < 5)
        {
            Vehicle vehicle = _vehicle1.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle5Data;
        }
        else { return; }
    }
    public void BuyVehicle6For1()
    {
        if (!_vehicle1.activeSelf)
        {
            _vehicle1.SetActive(true);
            Vehicle vehicle = _vehicle1.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle6Data;
        }
        else if (_vehicle1.GetComponent<Vehicle>()._vehicleData.vehicleTier < 6)
        {
            Vehicle vehicle = _vehicle1.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle6Data;
        }
        else { return; }
    }
    public void BuyVehicle7For1()
    {
        if (!_vehicle1.activeSelf)
        {
            _vehicle1.SetActive(true);
            Vehicle vehicle = _vehicle1.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle7Data;
        }
        else if (_vehicle1.GetComponent<Vehicle>()._vehicleData.vehicleTier < 7)
        {
            Vehicle vehicle = _vehicle1.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle7Data;
        }
        else { return; }
    }
    public void BuyVehicle8For1()
    {
        if (!_vehicle1.activeSelf)
        {
            _vehicle1.SetActive(true);
            Vehicle vehicle = _vehicle1.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle8Data;
        }
        else if (_vehicle1.GetComponent<Vehicle>()._vehicleData.vehicleTier < 8)
        {
            Vehicle vehicle = _vehicle1.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle8Data;
        }
        else { return; }
    }//vehicle slot 1 buy vehicle tabs

    public void BuyVehicle1For2()
    {
        if (!_vehicle2.activeSelf)
        {
            _vehicle2.SetActive(true);
            Vehicle vehicle = _vehicle2.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle1Data;
        }
        else
        {
            return;
        }
    }
    public void BuyVehicle2For2()
    {
        if (!_vehicle2.activeSelf)
        {
            _vehicle2.SetActive(true);
            Vehicle vehicle = _vehicle2.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle2Data;
        }
        else if (_vehicle2.GetComponent<Vehicle>()._vehicleData.vehicleTier < 2)
        {
            Vehicle vehicle = _vehicle2.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle2Data;
        }
        else { return; }
    }
    public void BuyVehicle3For2()
    {
        if (!_vehicle2.activeSelf)
        {
            _vehicle2.SetActive(true);
            Vehicle vehicle = _vehicle2.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle3Data;
        }
        else if (_vehicle2.GetComponent<Vehicle>()._vehicleData.vehicleTier < 3)
        {
            Vehicle vehicle = _vehicle2.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle3Data;
        }
        else { return; }
    }
    public void BuyVehicle4For2()
    {
        if (!_vehicle2.activeSelf)
        {
            _vehicle2.SetActive(true);
            Vehicle vehicle = _vehicle2.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle4Data;
        }
        else if (_vehicle2.GetComponent<Vehicle>()._vehicleData.vehicleTier < 4)
        {
            Vehicle vehicle = _vehicle2.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle4Data;
        }
        else { return; }
    }
    public void BuyVehicle5For2()
    {
        if (!_vehicle2.activeSelf)
        {
            _vehicle2.SetActive(true);
            Vehicle vehicle = _vehicle2.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle5Data;
        }
        else if (_vehicle2.GetComponent<Vehicle>()._vehicleData.vehicleTier < 5)
        {
            Vehicle vehicle = _vehicle2.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle5Data;
        }
        else { return; }
    }
    public void BuyVehicle6For2()
    {
        if (!_vehicle2.activeSelf)
        {
            _vehicle2.SetActive(true);
            Vehicle vehicle = _vehicle2.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle6Data;
        }
        else if (_vehicle2.GetComponent<Vehicle>()._vehicleData.vehicleTier < 6)
        {
            Vehicle vehicle = _vehicle2.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle6Data;
        }
        else { return; }
    }
    public void BuyVehicle7For2()
    {
        if (!_vehicle2.activeSelf)
        {
            _vehicle2.SetActive(true);
            Vehicle vehicle = _vehicle2.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle7Data;
        }
        else if (_vehicle2.GetComponent<Vehicle>()._vehicleData.vehicleTier < 7)
        {
            Vehicle vehicle = _vehicle2.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle7Data;
        }
        else { return; }
    }
    public void BuyVehicle8For2()
    {
        if (!_vehicle2.activeSelf)
        {
            _vehicle2.SetActive(true);
            Vehicle vehicle = _vehicle2.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle8Data;
        }
        else if (_vehicle2.GetComponent<Vehicle>()._vehicleData.vehicleTier < 8)
        {
            Vehicle vehicle = _vehicle2.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle8Data;
        }
        else { return; }
    }//vehicle slot 2 buy vehicle tabs

    public void BuyVehicle1For3()
    {
        if (!_vehicle3.activeSelf)
        {
            _vehicle3.SetActive(true);
            Vehicle vehicle = _vehicle3.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle1Data;
        }
        else
        {
            return;
        }
    }
    public void BuyVehicle2For3()
    {
        if (!_vehicle3.activeSelf)
        {
            _vehicle3.SetActive(true);
            Vehicle vehicle = _vehicle3.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle2Data;
        }
        else if (_vehicle3.GetComponent<Vehicle>()._vehicleData.vehicleTier < 2)
        {
            Vehicle vehicle = _vehicle3.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle2Data;
        }
        else { return; }
    }
    public void BuyVehicle3For3()
    {
        if (!_vehicle3.activeSelf)
        {
            _vehicle3.SetActive(true);
            Vehicle vehicle = _vehicle3.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle3Data;
        }
        else if (_vehicle3.GetComponent<Vehicle>()._vehicleData.vehicleTier < 3)
        {
            Vehicle vehicle = _vehicle3.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle3Data;
        }
        else { return; }
    }
    public void BuyVehicle4For3()
    {
        if (!_vehicle3.activeSelf)
        {
            _vehicle3.SetActive(true);
            Vehicle vehicle = _vehicle3.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle4Data;
        }
        else if (_vehicle3.GetComponent<Vehicle>()._vehicleData.vehicleTier < 4)
        {
            Vehicle vehicle = _vehicle3.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle4Data;
        }
        else { return; }
    }
    public void BuyVehicle5For3()
    {
        if (!_vehicle3.activeSelf)
        {
            _vehicle3.SetActive(true);
            Vehicle vehicle = _vehicle3.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle5Data;
        }
        else if (_vehicle3.GetComponent<Vehicle>()._vehicleData.vehicleTier < 5)
        {
            Vehicle vehicle = _vehicle3.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle5Data;
        }
        else { return; }
    }
    public void BuyVehicle6For3()
    {
        if (!_vehicle3.activeSelf)
        {
            _vehicle3.SetActive(true);
            Vehicle vehicle = _vehicle3.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle6Data;
        }
        else if (_vehicle3.GetComponent<Vehicle>()._vehicleData.vehicleTier < 6)
        {
            Vehicle vehicle = _vehicle3.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle6Data;
        }
        else { return; }
    }
    public void BuyVehicle7For3()
    {
        if (!_vehicle3.activeSelf)
        {
            _vehicle3.SetActive(true);
            Vehicle vehicle = _vehicle3.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle7Data;
        }
        else if (_vehicle3.GetComponent<Vehicle>()._vehicleData.vehicleTier < 7)
        {
            Vehicle vehicle = _vehicle3.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle7Data;
        }
        else { return; }
    }
    public void BuyVehicle8For3()
    {
        if (!_vehicle3.activeSelf)
        {
            _vehicle3.SetActive(true);
            Vehicle vehicle = _vehicle3.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle8Data;
        }
        else if (_vehicle3.GetComponent<Vehicle>()._vehicleData.vehicleTier < 8)
        {
            Vehicle vehicle = _vehicle3.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle8Data;
        }
        else { return; }
    }//vehicle slot 3 buy vehicle tabs

    public void BuyVehicle1For4()
    {
        if (!_vehicle4.activeSelf)
        {
            _vehicle4.SetActive(true);
            Vehicle vehicle = _vehicle4.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle1Data;
        }
        else
        {
            return;
        }
    }
    public void BuyVehicle2For4()
    {
        if (!_vehicle4.activeSelf)
        {
            _vehicle4.SetActive(true);
            Vehicle vehicle = _vehicle4.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle2Data;
        }
        else if (_vehicle4.GetComponent<Vehicle>()._vehicleData.vehicleTier < 2)
        {
            Vehicle vehicle = _vehicle4.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle2Data;
        }
        else { return; }
    }
    public void BuyVehicle3For4()
    {
        if (!_vehicle4.activeSelf)
        {
            _vehicle4.SetActive(true);
            Vehicle vehicle = _vehicle4.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle3Data;
        }
        else if (_vehicle4.GetComponent<Vehicle>()._vehicleData.vehicleTier < 3)
        {
            Vehicle vehicle = _vehicle4.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle3Data;
        }
        else { return; }
    }
    public void BuyVehicle4For4()
    {
        if (!_vehicle4.activeSelf)
        {
            _vehicle4.SetActive(true);
            Vehicle vehicle = _vehicle4.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle4Data;
        }
        else if (_vehicle4.GetComponent<Vehicle>()._vehicleData.vehicleTier < 4)
        {
            Vehicle vehicle = _vehicle4.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle4Data;
        }
        else { return; }
    }
    public void BuyVehicle5For4()
    {
        if (!_vehicle4.activeSelf)
        {
            _vehicle4.SetActive(true);
            Vehicle vehicle = _vehicle4.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle5Data;
        }
        else if (_vehicle4.GetComponent<Vehicle>()._vehicleData.vehicleTier < 5)
        {
            Vehicle vehicle = _vehicle4.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle5Data;
        }
        else { return; }
    }
    public void BuyVehicle6For4()
    {
        if (!_vehicle4.activeSelf)
        {
            _vehicle4.SetActive(true);
            Vehicle vehicle = _vehicle4.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle6Data;
        }
        else if (_vehicle4.GetComponent<Vehicle>()._vehicleData.vehicleTier < 6)
        {
            Vehicle vehicle = _vehicle4.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle6Data;
        }
        else { return; }
    }
    public void BuyVehicle7For4()
    {
        if (!_vehicle4.activeSelf)
        {
            _vehicle4.SetActive(true);
            Vehicle vehicle = _vehicle4.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle7Data;
        }
        else if (_vehicle4.GetComponent<Vehicle>()._vehicleData.vehicleTier < 7)
        {
            Vehicle vehicle = _vehicle4.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle7Data;
        }
        else { return; }
    }
    public void BuyVehicle8For4()
    {
        if (!_vehicle4.activeSelf)
        {
            _vehicle4.SetActive(true);
            Vehicle vehicle = _vehicle4.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle8Data;
        }
        else if (_vehicle4.GetComponent<Vehicle>()._vehicleData.vehicleTier < 8)
        {
            Vehicle vehicle = _vehicle4.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle8Data;
        }
        else { return; }
    }//vehicle slot 4 buy vehicle tabs

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
}
