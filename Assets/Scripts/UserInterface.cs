using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UserInterface : MonoBehaviour
{
    [SerializeField] private TMP_Text _building1Text;
    [SerializeField] private TMP_Text _building2Text;
    [SerializeField] private TMP_Text _building3Text;
    [SerializeField] private TMP_Text _building4Text;
    [SerializeField] private TMP_Text _movementSpeedUpgradeText;
    [SerializeField] private TMP_Text _spentProductDecraseText;
    [SerializeField] private TMP_Text _serveTimeDecreaseText;
    [SerializeField] private TMP_Text _playerMoneyText;
    [SerializeField] private TMP_Text _productText;
    [SerializeField] private TMP_Text _vehicle1Capacity;
    [SerializeField] private TMP_Text _vehicle2Capacity;
    [SerializeField] private TMP_Text _vehicle3Capacity;
    [SerializeField] private TMP_Text _vehicle4Capacity;
    //----------------------------------------------------
    [SerializeField] private StoreData _storeData;
    [SerializeField] private CustomerData _customerData;
    [SerializeField] private ProductData _productData;
    [SerializeField] private PlayerData _playerData;
    //----------------------------------------------------
    [SerializeField] private GameObject _productChangeButton;
    [SerializeField] private GameObject _vehicle1;
    [SerializeField] private GameObject _vehicle2;
    [SerializeField] private GameObject _vehicle3;
    [SerializeField] private GameObject _vehicle4;

    private void Awake()
    {
        UpdateStoreTabTexts();
        UpdateCustomerUpgradeTabTexts();
        UpdateVehicleCapacityTexts();
    }

    private void Update()
    {
        UpdateTopMostUI();
    }

    public void UpdateStoreTabTexts()
    {
        _building1Text.text = "Click here to increase capacity.";
        if (!_storeData.sausage2Open)
        {
            _building2Text.text = "Click here to buy the 2nd shop.";
        }        
        else
        {
            _building2Text.text = "Click here to increase capacity.";
        }        
        if (!_storeData.sausage3Open)
        {
            _building3Text.text = "Click here to the 3rd shop.";
        }        
        else
        {
            _building3Text.text = "Click here to increase capacity.";
        }        
        if (!_storeData.sausage4Open)
        {
            _building4Text.text = "Click here to buy the 4th shop.";
        }        
        else
        {
            _building4Text.text = "Click here to increase capacity.";
        }

    }

    private void UpdateVehicleCapacityTexts()
    {
        _vehicle1Capacity.text = "Capacity: " + _vehicle1.GetComponent<Vehicle>().vehicleCapacity;
        _vehicle2Capacity.text = "Capacity: " + _vehicle2.GetComponent<Vehicle>().vehicleCapacity;
        _vehicle3Capacity.text = "Capacity: " + _vehicle3.GetComponent<Vehicle>().vehicleCapacity;
        _vehicle4Capacity.text = "Capacity: " + _vehicle4.GetComponent<Vehicle>().vehicleCapacity;
    }

    public void UpdateCustomerUpgradeTabTexts()
    {
        _movementSpeedUpgradeText.text = "Click here to increase movement speed by %10. Current movement speed increase: %" + "" + (_customerData.movementSpeedMultiplier * 100 - 100);
        _spentProductDecraseText.text = "Click here to decrease spent product by %5. Current decrease in spent product: %" + "" + (100 - _productData.productSpentPerService * 100);
        _serveTimeDecreaseText.text = "Click here to decrease the serve time. Current decrease in serve time: %" + "" + (100 - _customerData.peopleSpendDurationMultiplier * 100);
    }

    public void UpdateTopMostUI()
    {
        _playerMoneyText.text = "Money: " + _playerData.Money;
        _productText.text = "Product Owned: " + _productData.productQuantity;
    }
}
