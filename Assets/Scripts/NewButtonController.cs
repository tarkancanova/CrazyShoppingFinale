using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class NewButtonController : MonoBehaviour
{
    [SerializeField] private GameObject _customerCreator;
    [SerializeField] private GameObject _storeTab;
    [SerializeField] private GameObject _upgradeTab;
    [SerializeField] private GameObject _productTab;
    [SerializeField] private StoreData _storeData;
    [SerializeField] private PlayerData _playerData;
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
    [SerializeField] private TMP_Text _pizzaProductTabText;
    [SerializeField] private TMP_Text _barberProductTabText;
    [SerializeField] private TMP_Text _marketProductTabText;
    [SerializeField] private TMP_Text _cafeProductTabText;
    [SerializeField] private TMP_Text _hamburgerProductTabText;



    public void CloseStoreTab()
    {
        _storeTab.SetActive(false);
    }    
    public void CloseUpgradeTab()
    {
        _upgradeTab.SetActive(false);
    }
    public void OpenProductTab()
    {
        _productTab.SetActive(true);
    }
    public void CloseProductTab()
    {
        _productTab.SetActive(false);
    }

    public void ChangeProductToPizza()
    {
        if (_pizzaProductTabText.text == "Click here to sell your stores and open a pizza store.")
        {
            _productData.mainProduct = "Pizza";
            SceneManager.LoadScene("SampleScene");
        }
        else
            return;
    }    
    public void ChangeProductToHamburger()
    {
        _productData.mainProduct = "Hamburger";
        SceneManager.LoadScene("SampleScene");

    }
    public void ChangeProductToBarber()
    {
        if (_barberProductTabText.text == "Click here to sell your stores and open a barber shop.")
        {
            _productData.mainProduct = "Barber";
            _storeData.boughtBarber = true;
            SceneManager.LoadScene("SampleScene");
        }
        else
            return;
    }
    public void ChangeProductToCafe()
    {
        if (_cafeProductTabText.text == "Click here to sell your stores and open a coffee shop.")
        {
            _productData.mainProduct = "Cafe";
            _storeData.boughtCafe = true;
            SceneManager.LoadScene("SampleScene");
        }
        else
            return;
    }

    public void ChangeProductToMarket()
    {
        if (_marketProductTabText.text == "Click here to sell your stores and open a market store.")
        {
            _productData.mainProduct = "Market";
            _storeData.boughtMarket = true;
            SceneManager.LoadScene("SampleScene");
        }
        else
            return;
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
        if (_customerData.movementSpeedMultiplier * 100 - 100 < 400)
        {
            _customerData.movementSpeedMultiplier *= 1.1f;
        }
        else
            return;
    }

    public void DecreaseSpendDuration()
    {
        _customerData.peopleSpendDurationMultiplier *= 0.95f;
    }

    public void IncreaseProductPerSec()
    {
        _productData.productPerSec += 5;
    }

    public void SendCustomers()
    {
        if (_customerData.customersGoingToStores < _storeData.totalStoreCapacity)
        {
            _customerData.customersGoingToStores += 1;
            GameObject customer = CustomersObject.SharedInstance.GetPooledObject();
            if (customer != null)
            {
                customer.transform.position = new Vector3(_customerCreator.transform.position.x, _customerCreator.transform.position.y, _customerCreator.transform.position.z + 1);
                customer.SetActive(true);
            }
        }
    }

}
