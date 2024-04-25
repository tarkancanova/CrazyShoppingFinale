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
    [SerializeField] private TMP_Text _productPerSecUpgradeText;
    [SerializeField] private TMP_Text _pizzaProductTabText;
    [SerializeField] private TMP_Text _barberProductTabText;
    [SerializeField] private TMP_Text _marketProductTabText;
    [SerializeField] private TMP_Text _cafeProductTabText;
    [SerializeField] private TMP_Text _hamburgerProductTabText;
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

    private void Start()
    {
        UpdateStoreTabTexts();
        UpdateCustomerUpgradeTabTexts();
        ProductPerSecUpgradeTabText();
        ChangeProductTabText();
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


    public void UpdateCustomerUpgradeTabTexts()
    {
        if (_customerData.movementSpeedMultiplier * 100 - 100 < 400)
            _movementSpeedUpgradeText.text = "Click here to increase movement speed by %10.";
        else
            _movementSpeedUpgradeText.text = "Already at max level.";
        _spentProductDecraseText.text = "Click here to decrease spent product by %5.";
        _serveTimeDecreaseText.text = "Click here to decrease the serve time by %10.";
    }

    public void ProductPerSecUpgradeTabText()
    {
        _productPerSecUpgradeText.text = "Click here to increase product per second. Current product per second: " + _productData.productPerSec + "\n" + "Price: " + 10;
    }

    public void UpdateTopMostUI()
    {
        _playerMoneyText.text = "Money: " + _playerData.Money;
        _productText.text = "Product Owned: " + _productData.productQuantity;
    }

    public void ChangeProductTabText()
    {
        if (!_storeData.boughtBarber)
        {
            switch (_productData.mainProduct)
            {
                case "Hamburger":
                    _hamburgerProductTabText.text = "You already own hamburger shops.";
                    _barberProductTabText.text = "locked.";
                    _pizzaProductTabText.text = "Click here to sell your stores and open a pizza store.";
                    _marketProductTabText.text = "locked.";
                    _cafeProductTabText.text = "locked.";
                    break;
                case "Pizza":
                    _hamburgerProductTabText.text = "Click here to sell all your stores and open a hamburger shop.";
                    _barberProductTabText.text = "Click here to sell your stores and open a barber shop.";
                    _marketProductTabText.text = "locked.";
                    _pizzaProductTabText.text = "You already own a pizza store.";
                    _cafeProductTabText.text = "locked.";
                    break;
                case "Barber":
                    _hamburgerProductTabText.text = "Click here to sell all your stores and open a hamburger shop.";
                    _marketProductTabText.text = "Click here to sell your stores and open a market store.";
                    _pizzaProductTabText.text = "Click here to sell your stores and open a pizza store.";
                    _barberProductTabText.text = "You already own a barber shop.";
                    _cafeProductTabText.text = "locked.";
                    break;
                case "Market":
                    _hamburgerProductTabText.text = "Click here to sell all your stores and open a hamburger shop.";
                    _marketProductTabText.text = "You already own a market store.";
                    _pizzaProductTabText.text = "Click here to sell your stores and open a pizza store.";
                    _barberProductTabText.text = "Click here to sell your stores and open a barber shop.";
                    _cafeProductTabText.text = "Click here to sell your stores and open a coffee shop.";
                    break;
                case "Cafe":
                    _hamburgerProductTabText.text = "Click here to sell all your stores and open a hamburger shop.";
                    _marketProductTabText.text = "Click here to sell your stores and open a market store..";
                    _pizzaProductTabText.text = "Click here to sell your stores and open a pizza store.";
                    _barberProductTabText.text = "Click here to sell your stores and open a barber shop.";
                    _cafeProductTabText.text = "You already own a coffee shop.";
                    break;
            }
        }
        else if (_storeData.boughtBarber && !_storeData.boughtMarket && !_storeData.boughtCafe)
        {
            switch (_productData.mainProduct)
            {
                case "Hamburger":
                    _hamburgerProductTabText.text = "You already own hamburger shops.";
                    _barberProductTabText.text = "Click here to sell your stores and open a barber shop.";
                    _pizzaProductTabText.text = "Click here to sell your stores and open a pizza store.";
                    _marketProductTabText.text = "locked.";
                    _cafeProductTabText.text = "locked";
                    break;
                case "Pizza":
                    _hamburgerProductTabText.text = "Click here to sell all your stores and open a hamburger shop.";
                    _barberProductTabText.text = "Click here to sell your stores and open a barber shop.";
                    _marketProductTabText.text = "locked.";
                    _pizzaProductTabText.text = "You already own a pizza store.";
                    _cafeProductTabText.text = "locked";
                    break;
                case "Barber":
                    _hamburgerProductTabText.text = "Click here to sell all your stores and open a hamburger shop.";
                    _marketProductTabText.text = "Click here to sell your stores and open a market store.";
                    _pizzaProductTabText.text = "Click here to sell your stores and open a pizza store.";
                    _barberProductTabText.text = "You already own a barber shop.";
                    _cafeProductTabText.text = "locked";
                    break;
                case "Market":
                    _hamburgerProductTabText.text = "Click here to sell all your stores and open a hamburger shop.";
                    _marketProductTabText.text = "You already own a market store.";
                    _pizzaProductTabText.text = "Click here to sell your stores and open a pizza store.";
                    _barberProductTabText.text = "Click here to sell your stores and open a barber shop.";
                    _cafeProductTabText.text = "Click here to sell your stores and open a coffee shop.";
                    break;
                case "Cafe":
                    _hamburgerProductTabText.text = "Click here to sell all your stores and open a hamburger shop.";
                    _marketProductTabText.text = "Click here to sell your stores and open a market store..";
                    _pizzaProductTabText.text = "Click here to sell your stores and open a pizza store.";
                    _barberProductTabText.text = "Click here to sell your stores and open a barber shop.";
                    _cafeProductTabText.text = "You already own a coffee shop.";
                    break;
            }
        }
        else if (_storeData.boughtMarket && !_storeData.boughtCafe)
        {
            switch (_productData.mainProduct)
            {
                case "Hamburger":
                    _hamburgerProductTabText.text = "You already own hamburger shops.";
                    _barberProductTabText.text = "Click here to sell your stores and open a barber shop.";
                    _pizzaProductTabText.text = "Click here to sell your stores and open a pizza store.";
                    _marketProductTabText.text = "Click here to sell your stores and open a market store.";
                    _cafeProductTabText.text = "locked";
                    break;
                case "Pizza":
                    _hamburgerProductTabText.text = "Click here to sell all your stores and open a hamburger shop.";
                    _barberProductTabText.text = "Click here to sell your stores and open a barber shop.";
                    _marketProductTabText.text = "Click here to sell your stores and open a market store.";
                    _pizzaProductTabText.text = "You already own a pizza store.";
                    _cafeProductTabText.text = "locked";
                    break;
                case "Barber":
                    _hamburgerProductTabText.text = "Click here to sell all your stores and open a hamburger shop.";
                    _marketProductTabText.text = "Click here to sell your stores and open a market store.";
                    _pizzaProductTabText.text = "Click here to sell your stores and open a pizza store.";
                    _barberProductTabText.text = "You already own a barber shop.";
                    _cafeProductTabText.text = "locked";
                    break;
                case "Market":
                    _hamburgerProductTabText.text = "Click here to sell all your stores and open a hamburger shop.";
                    _marketProductTabText.text = "You already own a market store.";
                    _pizzaProductTabText.text = "Click here to sell your stores and open a pizza store.";
                    _barberProductTabText.text = "Click here to sell your stores and open a barber shop.";
                    _cafeProductTabText.text = "Click here to sell your stores and open a coffee shop.";
                    break;
                case "Cafe":
                    _hamburgerProductTabText.text = "Click here to sell all your stores and open a hamburger shop.";
                    _marketProductTabText.text = "Click here to sell your stores and open a market store..";
                    _pizzaProductTabText.text = "Click here to sell your stores and open a pizza store.";
                    _barberProductTabText.text = "Click here to sell your stores and open a barber shop.";
                    _cafeProductTabText.text = "You already own a coffee shop.";
                    break;
            }
        }
        else if (_storeData.boughtCafe )
        {
            switch (_productData.mainProduct)
            {
                case "Hamburger":
                    _hamburgerProductTabText.text = "You already own hamburger shops.";
                    _barberProductTabText.text = "Click here to sell your stores and open a barber shop.";
                    _pizzaProductTabText.text = "Click here to sell your stores and open a pizza store.";
                    _marketProductTabText.text = "Click here to sell your stores and open a market store.";
                    _cafeProductTabText.text = "Click here to sell your stores and open a coffee shop.";
                    break;
                case "Pizza":
                    _hamburgerProductTabText.text = "Click here to sell all your stores and open a hamburger shop.";
                    _barberProductTabText.text = "Click here to sell your stores and open a barber shop.";
                    _marketProductTabText.text = "Click here to sell your stores and open a market store.";
                    _pizzaProductTabText.text = "You already own a pizza store.";
                    _cafeProductTabText.text = "Click here to sell your stores and open a coffee shop.";
                    break;
                case "Barber":
                    _hamburgerProductTabText.text = "Click here to sell all your stores and open a hamburger shop.";
                    _marketProductTabText.text = "Click here to sell your stores and open a market store.";
                    _pizzaProductTabText.text = "Click here to sell your stores and open a pizza store.";
                    _barberProductTabText.text = "You already own a barber shop.";
                    _cafeProductTabText.text = "Click here to sell your stores and open a coffee shop.";
                    break;
                case "Market":
                    _hamburgerProductTabText.text = "Click here to sell all your stores and open a hamburger shop.";
                    _marketProductTabText.text = "You already own a market store.";
                    _pizzaProductTabText.text = "Click here to sell your stores and open a pizza store.";
                    _barberProductTabText.text = "Click here to sell your stores and open a barber shop.";
                    _cafeProductTabText.text = "Click here to sell your stores and open a coffee shop.";
                    break;
                case "Cafe":
                    _hamburgerProductTabText.text = "Click here to sell all your stores and open a hamburger shop.";
                    _marketProductTabText.text = "Click here to sell your stores and open a market store.";
                    _pizzaProductTabText.text = "Click here to sell your stores and open a pizza store.";
                    _barberProductTabText.text = "Click here to sell your stores and open a barber shop.";
                    _cafeProductTabText.text = "You already own a coffee shop.";
                    break;
            }
        }

    }
}
