using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PrimitiveUIToTest : MonoBehaviour
{
    //Scriptable Object references
    [SerializeField] private PlayerData _playerData;
    [SerializeField] private ProductData _productData;
    [SerializeField] private CustomerData _customerData;
    [SerializeField] private StoreData _storeData;
    //Variables for Top-Left part of UI showing products and money owned by Player
    [SerializeField] private TMP_Text _moneyOwnedText;
    [SerializeField] private TMP_Text _productOwnedText;
    //Variables for Top-Right part of UI for customer and store upgrades
    [SerializeField] private GameObject _storeTab;
    [SerializeField] private GameObject _customerTab;
    //Variables for Vehicles
    [SerializeField] private TMP_Text _vehicleOneText;
    [SerializeField] private TMP_Text _vehicleOneVehicle1Text;
    [SerializeField] private TMP_Text _vehicleOneVehicle2Text;
    [SerializeField] private TMP_Text _vehicleOneVehicle3Text;
    [SerializeField] private TMP_Text _vehicleOneVehicle4Text;
    [SerializeField] private TMP_Text _vehicleOneVehicle5Text;
    [SerializeField] private TMP_Text _vehicleOneVehicle6Text;
    [SerializeField] private TMP_Text _vehicleOneVehicle7Text;
    [SerializeField] private TMP_Text _vehicleOneVehicle8Text;
    [SerializeField] private TMP_Text _vehicleTwoVehicle1Text;
    [SerializeField] private TMP_Text _vehicleTwoVehicle2Text;
    [SerializeField] private TMP_Text _vehicleTwoVehicle3Text;
    [SerializeField] private TMP_Text _vehicleTwoVehicle4Text;
    [SerializeField] private TMP_Text _vehicleTwoVehicle5Text;
    [SerializeField] private TMP_Text _vehicleTwoVehicle6Text;
    [SerializeField] private TMP_Text _vehicleTwoVehicle7Text;
    [SerializeField] private TMP_Text _vehicleTwoVehicle8Text;
    [SerializeField] private TMP_Text _vehicleThreeVehicle1Text;
    [SerializeField] private TMP_Text _vehicleThreeVehicle2Text;
    [SerializeField] private TMP_Text _vehicleThreeVehicle3Text;
    [SerializeField] private TMP_Text _vehicleThreeVehicle4Text;
    [SerializeField] private TMP_Text _vehicleThreeVehicle5Text;
    [SerializeField] private TMP_Text _vehicleThreeVehicle6Text;
    [SerializeField] private TMP_Text _vehicleThreeVehicle7Text;
    [SerializeField] private TMP_Text _vehicleThreeVehicle8Text;
    [SerializeField] private TMP_Text _vehicleFourVehicle1Text;
    [SerializeField] private TMP_Text _vehicleFourVehicle2Text;
    [SerializeField] private TMP_Text _vehicleFourVehicle3Text;
    [SerializeField] private TMP_Text _vehicleFourVehicle4Text;
    [SerializeField] private TMP_Text _vehicleFourVehicle5Text;
    [SerializeField] private TMP_Text _vehicleFourVehicle6Text;
    [SerializeField] private TMP_Text _vehicleFourVehicle7Text;
    [SerializeField] private TMP_Text _vehicleFourVehicle8Text;
    [SerializeField] private TMP_Text _vehicleTwoText;
    [SerializeField] private TMP_Text _vehicleThreeText;
    [SerializeField] private TMP_Text _vehicleFourText;
    [SerializeField] private GameObject _vehicleOne;
    [SerializeField] private GameObject _vehicleTwo;
    [SerializeField] private GameObject _vehicleThree;
    [SerializeField] private GameObject _vehicleFour;
    [SerializeField] private TMP_Text _movementSpeedUpgradeText;
    [SerializeField] private TMP_Text _spentProductDecraseText;
    [SerializeField] private TMP_Text _serveTimeDecreaseText;
    [SerializeField] private TMP_Text _storeUpgradesFirstButtonText;
    [SerializeField] private TMP_Text _storeUpgradesSecondButtonText;
    [SerializeField] private TMP_Text _storeUpgradesThirdButtonText;
    [SerializeField] private TMP_Text _storeUpgradesFourthButtonText;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Independent();
        Vehicle1BuyTabTexts();
        Vehicle2BuyTabTexts();
        Vehicle3BuyTabTexts();
        Vehicle4BuyTabTexts();
        Store4BuyUpgrade();
        Store3BuyUpgrade();
        Store2BuyUpgrade();
    }

    private void Independent()
    {
        _moneyOwnedText.text = "Money: " + _playerData.Money;
        _productOwnedText.text = "Product Owned: " + _productData.productQuantity;
        _vehicleOneText.text = "Owned Vehicle: " + _vehicleOne.GetComponent<Vehicle>().vehicleName;
        _vehicleTwoText.text = "Owned Vehicle: " + _vehicleTwo.GetComponent<Vehicle>().vehicleName;
        _vehicleThreeText.text = "Owned Vehicle: " + _vehicleThree.GetComponent<Vehicle>().vehicleName;
        _vehicleFourText.text = "Owned Vehicle: " + _vehicleFour.GetComponent<Vehicle>().vehicleName;
        _movementSpeedUpgradeText.text = "Click here to increase movement speed by %10. Current movement speed increase: %" + "" + (_customerData.movementSpeedMultiplier * 100 - 100);
        _spentProductDecraseText.text = "Click here to decrease spent prdouct by %5. Current decrease in product spent: %" + "" + (100 - _productData.productSpentPerService * 100);
        _serveTimeDecreaseText.text = "Click here to decrease the serve time. Current decrease in serve time: %" + "" + (100 - _customerData.peopleSpendDurationMultiplier * 100);
        _storeUpgradesFirstButtonText.text = "Click here to increase the capacity of Store 1. Current max cap: " + (_storeData.sausageMaxStoreCapacity);
    }

    private void Vehicle1BuyTabTexts()
    {
        if (!_vehicleOne.activeSelf)
        {
            _vehicleOneVehicle1Text.text = "Press here to buy.";
            _vehicleOneVehicle2Text.text = "Press here to buy.";
            _vehicleOneVehicle3Text.text = "Press here to buy.";
            _vehicleOneVehicle4Text.text = "Press here to buy.";
            _vehicleOneVehicle5Text.text = "Press here to buy.";
            _vehicleOneVehicle6Text.text = "Press here to buy.";
            _vehicleOneVehicle7Text.text = "Press here to buy.";
            _vehicleOneVehicle8Text.text = "Press here to buy.";
        }

        else
        {
            switch (_vehicleOne.GetComponent<Vehicle>()._vehicleData?.vehicleTier)
            {
                case 1:
                    _vehicleOneVehicle1Text.text = "Already bought.";
                    _vehicleOneVehicle2Text.text = "Press here to buy.";
                    _vehicleOneVehicle3Text.text = "Press here to buy.";
                    _vehicleOneVehicle4Text.text = "Press here to buy.";
                    _vehicleOneVehicle5Text.text = "Press here to buy.";
                    _vehicleOneVehicle6Text.text = "Press here to buy.";
                    _vehicleOneVehicle7Text.text = "Press here to buy.";
                    _vehicleOneVehicle8Text.text = "Press here to buy.";
                    return;
                case 2:
                    _vehicleOneVehicle1Text.text = "You have a higher tier vehicle.";
                    _vehicleOneVehicle2Text.text = "Already bought.";
                    _vehicleOneVehicle3Text.text = "Press here to buy.";
                    _vehicleOneVehicle4Text.text = "Press here to buy.";
                    _vehicleOneVehicle5Text.text = "Press here to buy.";
                    _vehicleOneVehicle6Text.text = "Press here to buy.";
                    _vehicleOneVehicle7Text.text = "Press here to buy.";
                    _vehicleOneVehicle8Text.text = "Press here to buy.";
                    return;
                case 3:
                    _vehicleOneVehicle1Text.text = "You have a higher tier vehicle.";
                    _vehicleOneVehicle2Text.text = "You have a higher tier vehicle.";
                    _vehicleOneVehicle3Text.text = "Already bought.";
                    _vehicleOneVehicle4Text.text = "Press here to buy.";
                    _vehicleOneVehicle5Text.text = "Press here to buy.";
                    _vehicleOneVehicle6Text.text = "Press here to buy.";
                    _vehicleOneVehicle7Text.text = "Press here to buy.";
                    _vehicleOneVehicle8Text.text = "Press here to buy.";
                    return;
                case 4:
                    _vehicleOneVehicle1Text.text = "You have a higher tier vehicle.";
                    _vehicleOneVehicle2Text.text = "You have a higher tier vehicle.";
                    _vehicleOneVehicle3Text.text = "You have a higher tier vehicle.";
                    _vehicleOneVehicle4Text.text = "Already bought.";
                    _vehicleOneVehicle5Text.text = "Press here to buy.";
                    _vehicleOneVehicle6Text.text = "Press here to buy.";
                    _vehicleOneVehicle7Text.text = "Press here to buy.";
                    _vehicleOneVehicle8Text.text = "Press here to buy.";
                    return;
                case 5:
                    _vehicleOneVehicle1Text.text = "You have a higher tier vehicle.";
                    _vehicleOneVehicle2Text.text = "You have a higher tier vehicle.";
                    _vehicleOneVehicle3Text.text = "You have a higher tier vehicle.";
                    _vehicleOneVehicle4Text.text = "You have a higher tier vehicle.";
                    _vehicleOneVehicle5Text.text = "Already bought.";
                    _vehicleOneVehicle6Text.text = "Press here to buy.";
                    _vehicleOneVehicle7Text.text = "Press here to buy.";
                    _vehicleOneVehicle8Text.text = "Press here to buy.";
                    return;
                case 6:
                    _vehicleOneVehicle1Text.text = "You have a higher tier vehicle.";
                    _vehicleOneVehicle2Text.text = "You have a higher tier vehicle.";
                    _vehicleOneVehicle3Text.text = "You have a higher tier vehicle.";
                    _vehicleOneVehicle4Text.text = "You have a higher tier vehicle.";
                    _vehicleOneVehicle5Text.text = "You have a higher tier vehicle.";
                    _vehicleOneVehicle6Text.text = "Already bought.";
                    _vehicleOneVehicle7Text.text = "Press here to buy.";
                    _vehicleOneVehicle8Text.text = "Press here to buy.";
                    return;
                case 7:
                    _vehicleOneVehicle1Text.text = "You have a higher tier vehicle.";
                    _vehicleOneVehicle2Text.text = "You have a higher tier vehicle.";
                    _vehicleOneVehicle3Text.text = "You have a higher tier vehicle.";
                    _vehicleOneVehicle4Text.text = "You have a higher tier vehicle.";
                    _vehicleOneVehicle5Text.text = "You have a higher tier vehicle.";
                    _vehicleOneVehicle6Text.text = "You have a higher tier vehicle.";
                    _vehicleOneVehicle7Text.text = "Already bought.";
                    _vehicleOneVehicle8Text.text = "Press here to buy.";
                    return;
                case 8:
                    _vehicleOneVehicle1Text.text = "You have a higher tier vehicle.";
                    _vehicleOneVehicle2Text.text = "You have a higher tier vehicle.";
                    _vehicleOneVehicle3Text.text = "You have a higher tier vehicle.";
                    _vehicleOneVehicle4Text.text = "You have a higher tier vehicle.";
                    _vehicleOneVehicle5Text.text = "You have a higher tier vehicle.";
                    _vehicleOneVehicle6Text.text = "You have a higher tier vehicle.";
                    _vehicleOneVehicle7Text.text = "You have a higher tier vehicle.";
                    _vehicleOneVehicle8Text.text = "Already bought.";
                    return;
            }

        }

    }

    private void Vehicle2BuyTabTexts()
    {
        if (!_vehicleTwo.activeSelf)
        {
            _vehicleTwoVehicle1Text.text = "Press here to buy.";
            _vehicleTwoVehicle2Text.text = "Press here to buy.";
            _vehicleTwoVehicle3Text.text = "Press here to buy.";
            _vehicleTwoVehicle4Text.text = "Press here to buy.";
            _vehicleTwoVehicle5Text.text = "Press here to buy.";
            _vehicleTwoVehicle6Text.text = "Press here to buy.";
            _vehicleTwoVehicle7Text.text = "Press here to buy.";
            _vehicleTwoVehicle8Text.text = "Press here to buy.";
        }

        else
        {
            switch (_vehicleTwo.GetComponent<Vehicle>()._vehicleData?.vehicleTier)
            {
                case 1:
                    _vehicleTwoVehicle1Text.text = "Already bought.";
                    _vehicleTwoVehicle2Text.text = "Press here to buy.";
                    _vehicleTwoVehicle3Text.text = "Press here to buy.";
                    _vehicleTwoVehicle4Text.text = "Press here to buy.";
                    _vehicleTwoVehicle5Text.text = "Press here to buy.";
                    _vehicleTwoVehicle6Text.text = "Press here to buy.";
                    _vehicleTwoVehicle7Text.text = "Press here to buy.";
                    _vehicleTwoVehicle8Text.text = "Press here to buy.";
                    return;
                case 2:
                    _vehicleTwoVehicle1Text.text = "You have a higher tier vehicle.";
                    _vehicleTwoVehicle2Text.text = "Already bought.";
                    _vehicleTwoVehicle3Text.text = "Press here to buy.";
                    _vehicleTwoVehicle4Text.text = "Press here to buy.";
                    _vehicleTwoVehicle5Text.text = "Press here to buy.";
                    _vehicleTwoVehicle6Text.text = "Press here to buy.";
                    _vehicleTwoVehicle7Text.text = "Press here to buy.";
                    _vehicleTwoVehicle8Text.text = "Press here to buy.";
                    return;
                case 3:
                    _vehicleTwoVehicle1Text.text = "You have a higher tier vehicle.";
                    _vehicleTwoVehicle2Text.text = "You have a higher tier vehicle.";
                    _vehicleTwoVehicle3Text.text = "Already bought.";
                    _vehicleTwoVehicle4Text.text = "Press here to buy.";
                    _vehicleTwoVehicle5Text.text = "Press here to buy.";
                    _vehicleTwoVehicle6Text.text = "Press here to buy.";
                    _vehicleTwoVehicle7Text.text = "Press here to buy.";
                    _vehicleTwoVehicle8Text.text = "Press here to buy.";
                    return;
                case 4:
                    _vehicleTwoVehicle1Text.text = "You have a higher tier vehicle.";
                    _vehicleTwoVehicle2Text.text = "You have a higher tier vehicle.";
                    _vehicleTwoVehicle3Text.text = "You have a higher tier vehicle.";
                    _vehicleTwoVehicle4Text.text = "Already bought.";
                    _vehicleTwoVehicle5Text.text = "Press here to buy.";
                    _vehicleTwoVehicle6Text.text = "Press here to buy.";
                    _vehicleTwoVehicle7Text.text = "Press here to buy.";
                    _vehicleTwoVehicle8Text.text = "Press here to buy.";
                    return;
                case 5:
                    _vehicleTwoVehicle1Text.text = "You have a higher tier vehicle.";
                    _vehicleTwoVehicle2Text.text = "You have a higher tier vehicle.";
                    _vehicleTwoVehicle3Text.text = "You have a higher tier vehicle.";
                    _vehicleTwoVehicle4Text.text = "You have a higher tier vehicle.";
                    _vehicleTwoVehicle5Text.text = "Already bought.";
                    _vehicleTwoVehicle6Text.text = "Press here to buy.";
                    _vehicleTwoVehicle7Text.text = "Press here to buy.";
                    _vehicleTwoVehicle8Text.text = "Press here to buy.";
                    return;
                case 6:
                    _vehicleTwoVehicle1Text.text = "You have a higher tier vehicle.";
                    _vehicleTwoVehicle2Text.text = "You have a higher tier vehicle.";
                    _vehicleTwoVehicle3Text.text = "You have a higher tier vehicle.";
                    _vehicleTwoVehicle4Text.text = "You have a higher tier vehicle.";
                    _vehicleTwoVehicle5Text.text = "You have a higher tier vehicle.";
                    _vehicleTwoVehicle6Text.text = "Already bought.";
                    _vehicleTwoVehicle7Text.text = "Press here to buy.";
                    _vehicleTwoVehicle8Text.text = "Press here to buy.";
                    return;
                case 7:
                    _vehicleTwoVehicle1Text.text = "You have a higher tier vehicle.";
                    _vehicleTwoVehicle2Text.text = "You have a higher tier vehicle.";
                    _vehicleTwoVehicle3Text.text = "You have a higher tier vehicle.";
                    _vehicleTwoVehicle4Text.text = "You have a higher tier vehicle.";
                    _vehicleTwoVehicle5Text.text = "You have a higher tier vehicle.";
                    _vehicleTwoVehicle6Text.text = "You have a higher tier vehicle.";
                    _vehicleTwoVehicle7Text.text = "Already bought.";
                    _vehicleTwoVehicle8Text.text = "Press here to buy.";
                    return;
                case 8:
                    _vehicleTwoVehicle1Text.text = "You have a higher tier vehicle.";
                    _vehicleTwoVehicle2Text.text = "You have a higher tier vehicle.";
                    _vehicleTwoVehicle3Text.text = "You have a higher tier vehicle.";
                    _vehicleTwoVehicle4Text.text = "You have a higher tier vehicle.";
                    _vehicleTwoVehicle5Text.text = "You have a higher tier vehicle.";
                    _vehicleTwoVehicle6Text.text = "You have a higher tier vehicle.";
                    _vehicleTwoVehicle7Text.text = "You have a higher tier vehicle.";
                    _vehicleTwoVehicle8Text.text = "Already bought.";
                    return;
            }
        }
    }

    private void Vehicle4BuyTabTexts()
    {
        if (!_vehicleFour.activeSelf)
        {
            _vehicleFourVehicle1Text.text = "Press here to buy.";
            _vehicleFourVehicle2Text.text = "Press here to buy.";
            _vehicleFourVehicle3Text.text = "Press here to buy.";
            _vehicleFourVehicle4Text.text = "Press here to buy.";
            _vehicleFourVehicle5Text.text = "Press here to buy.";
            _vehicleFourVehicle6Text.text = "Press here to buy.";
            _vehicleFourVehicle7Text.text = "Press here to buy.";
            _vehicleFourVehicle8Text.text = "Press here to buy.";
        }

        else
        {
            switch (_vehicleFour.GetComponent<Vehicle>()._vehicleData?.vehicleTier)
            {
                case 1:
                    _vehicleFourVehicle1Text.text = "Already bought.";
                    _vehicleFourVehicle2Text.text = "Press here to buy.";
                    _vehicleFourVehicle3Text.text = "Press here to buy.";
                    _vehicleFourVehicle4Text.text = "Press here to buy.";
                    _vehicleFourVehicle5Text.text = "Press here to buy.";
                    _vehicleFourVehicle6Text.text = "Press here to buy.";
                    _vehicleFourVehicle7Text.text = "Press here to buy.";
                    _vehicleFourVehicle8Text.text = "Press here to buy.";
                    return;
                case 2:
                    _vehicleFourVehicle1Text.text = "You have a higher tier vehicle.";
                    _vehicleFourVehicle2Text.text = "Already bought.";
                    _vehicleFourVehicle3Text.text = "Press here to buy.";
                    _vehicleFourVehicle4Text.text = "Press here to buy.";
                    _vehicleFourVehicle5Text.text = "Press here to buy.";
                    _vehicleFourVehicle6Text.text = "Press here to buy.";
                    _vehicleFourVehicle7Text.text = "Press here to buy.";
                    _vehicleFourVehicle8Text.text = "Press here to buy.";
                    return;
                case 3:
                    _vehicleFourVehicle1Text.text = "You have a higher tier vehicle.";
                    _vehicleFourVehicle2Text.text = "You have a higher tier vehicle.";
                    _vehicleFourVehicle3Text.text = "Already bought.";
                    _vehicleFourVehicle4Text.text = "Press here to buy.";
                    _vehicleFourVehicle5Text.text = "Press here to buy.";
                    _vehicleFourVehicle6Text.text = "Press here to buy.";
                    _vehicleFourVehicle7Text.text = "Press here to buy.";
                    _vehicleFourVehicle8Text.text = "Press here to buy.";
                    return;
                case 4:
                    _vehicleFourVehicle1Text.text = "You have a higher tier vehicle.";
                    _vehicleFourVehicle2Text.text = "You have a higher tier vehicle.";
                    _vehicleFourVehicle3Text.text = "You have a higher tier vehicle.";
                    _vehicleFourVehicle4Text.text = "Already bought.";
                    _vehicleFourVehicle5Text.text = "Press here to buy.";
                    _vehicleFourVehicle6Text.text = "Press here to buy.";
                    _vehicleFourVehicle7Text.text = "Press here to buy.";
                    _vehicleFourVehicle8Text.text = "Press here to buy.";
                    return;
                case 5:
                    _vehicleFourVehicle1Text.text = "You have a higher tier vehicle.";
                    _vehicleFourVehicle2Text.text = "You have a higher tier vehicle.";
                    _vehicleFourVehicle3Text.text = "You have a higher tier vehicle.";
                    _vehicleFourVehicle4Text.text = "You have a higher tier vehicle.";
                    _vehicleFourVehicle5Text.text = "Already bought.";
                    _vehicleFourVehicle6Text.text = "Press here to buy.";
                    _vehicleFourVehicle7Text.text = "Press here to buy.";
                    _vehicleFourVehicle8Text.text = "Press here to buy.";
                    return;
                case 6:
                    _vehicleFourVehicle1Text.text = "You have a higher tier vehicle.";
                    _vehicleFourVehicle2Text.text = "You have a higher tier vehicle.";
                    _vehicleFourVehicle3Text.text = "You have a higher tier vehicle.";
                    _vehicleFourVehicle4Text.text = "You have a higher tier vehicle.";
                    _vehicleFourVehicle5Text.text = "You have a higher tier vehicle.";
                    _vehicleFourVehicle6Text.text = "Already bought.";
                    _vehicleFourVehicle7Text.text = "Press here to buy.";
                    _vehicleFourVehicle8Text.text = "Press here to buy.";
                    return;
                case 7:
                    _vehicleFourVehicle1Text.text = "You have a higher tier vehicle.";
                    _vehicleFourVehicle2Text.text = "You have a higher tier vehicle.";
                    _vehicleFourVehicle3Text.text = "You have a higher tier vehicle.";
                    _vehicleFourVehicle4Text.text = "You have a higher tier vehicle.";
                    _vehicleFourVehicle5Text.text = "You have a higher tier vehicle.";
                    _vehicleFourVehicle6Text.text = "You have a higher tier vehicle.";
                    _vehicleFourVehicle7Text.text = "Already bought.";
                    _vehicleFourVehicle8Text.text = "Press here to buy.";
                    return;
                case 8:
                    _vehicleFourVehicle1Text.text = "You have a higher tier vehicle.";
                    _vehicleFourVehicle2Text.text = "You have a higher tier vehicle.";
                    _vehicleFourVehicle3Text.text = "You have a higher tier vehicle.";
                    _vehicleFourVehicle4Text.text = "You have a higher tier vehicle.";
                    _vehicleFourVehicle5Text.text = "You have a higher tier vehicle.";
                    _vehicleFourVehicle6Text.text = "You have a higher tier vehicle.";
                    _vehicleFourVehicle7Text.text = "You have a higher tier vehicle.";
                    _vehicleFourVehicle8Text.text = "Already bought.";
                    return;
            }
        }
    }

    private void Vehicle3BuyTabTexts()
    {
        if (!_vehicleThree.activeSelf)
        {
            _vehicleThreeVehicle1Text.text = "Press here to buy.";
            _vehicleThreeVehicle2Text.text = "Press here to buy.";
            _vehicleThreeVehicle3Text.text = "Press here to buy.";
            _vehicleThreeVehicle4Text.text = "Press here to buy.";
            _vehicleThreeVehicle5Text.text = "Press here to buy.";
            _vehicleThreeVehicle6Text.text = "Press here to buy.";
            _vehicleThreeVehicle7Text.text = "Press here to buy.";
            _vehicleThreeVehicle8Text.text = "Press here to buy.";
        }

        else
        {
            switch (_vehicleThree.GetComponent<Vehicle>()._vehicleData?.vehicleTier)
            {
                case 1:
                    _vehicleThreeVehicle1Text.text = "Already bought.";
                    _vehicleThreeVehicle2Text.text = "Press here to buy.";
                    _vehicleThreeVehicle3Text.text = "Press here to buy.";
                    _vehicleThreeVehicle4Text.text = "Press here to buy.";
                    _vehicleThreeVehicle5Text.text = "Press here to buy.";
                    _vehicleThreeVehicle6Text.text = "Press here to buy.";
                    _vehicleThreeVehicle7Text.text = "Press here to buy.";
                    _vehicleThreeVehicle8Text.text = "Press here to buy.";
                    return;
                case 2:
                    _vehicleThreeVehicle1Text.text = "You have a higher tier vehicle.";
                    _vehicleThreeVehicle2Text.text = "Already bought.";
                    _vehicleThreeVehicle3Text.text = "Press here to buy.";
                    _vehicleThreeVehicle4Text.text = "Press here to buy.";
                    _vehicleThreeVehicle5Text.text = "Press here to buy.";
                    _vehicleThreeVehicle6Text.text = "Press here to buy.";
                    _vehicleThreeVehicle7Text.text = "Press here to buy.";
                    _vehicleThreeVehicle8Text.text = "Press here to buy.";
                    return;
                case 3:
                    _vehicleThreeVehicle1Text.text = "You have a higher tier vehicle.";
                    _vehicleThreeVehicle2Text.text = "You have a higher tier vehicle.";
                    _vehicleThreeVehicle3Text.text = "Already bought.";
                    _vehicleThreeVehicle4Text.text = "Press here to buy.";
                    _vehicleThreeVehicle5Text.text = "Press here to buy.";
                    _vehicleThreeVehicle6Text.text = "Press here to buy.";
                    _vehicleThreeVehicle7Text.text = "Press here to buy.";
                    _vehicleThreeVehicle8Text.text = "Press here to buy.";
                    return;
                case 4:
                    _vehicleThreeVehicle1Text.text = "You have a higher tier vehicle.";
                    _vehicleThreeVehicle2Text.text = "You have a higher tier vehicle.";
                    _vehicleThreeVehicle3Text.text = "You have a higher tier vehicle.";
                    _vehicleThreeVehicle4Text.text = "Already bought.";
                    _vehicleThreeVehicle5Text.text = "Press here to buy.";
                    _vehicleThreeVehicle6Text.text = "Press here to buy.";
                    _vehicleThreeVehicle7Text.text = "Press here to buy.";
                    _vehicleThreeVehicle8Text.text = "Press here to buy.";
                    return;
                case 5:
                    _vehicleThreeVehicle1Text.text = "You have a higher tier vehicle.";
                    _vehicleThreeVehicle2Text.text = "You have a higher tier vehicle.";
                    _vehicleThreeVehicle3Text.text = "You have a higher tier vehicle.";
                    _vehicleThreeVehicle4Text.text = "You have a higher tier vehicle.";
                    _vehicleThreeVehicle5Text.text = "Already bought.";
                    _vehicleThreeVehicle6Text.text = "Press here to buy.";
                    _vehicleThreeVehicle7Text.text = "Press here to buy.";
                    _vehicleThreeVehicle8Text.text = "Press here to buy.";
                    return;
                case 6:
                    _vehicleThreeVehicle1Text.text = "You have a higher tier vehicle.";
                    _vehicleThreeVehicle2Text.text = "You have a higher tier vehicle.";
                    _vehicleThreeVehicle3Text.text = "You have a higher tier vehicle.";
                    _vehicleThreeVehicle4Text.text = "You have a higher tier vehicle.";
                    _vehicleThreeVehicle5Text.text = "You have a higher tier vehicle.";
                    _vehicleThreeVehicle6Text.text = "Already bought.";
                    _vehicleThreeVehicle7Text.text = "Press here to buy.";
                    _vehicleThreeVehicle8Text.text = "Press here to buy.";
                    return;
                case 7:
                    _vehicleThreeVehicle1Text.text = "You have a higher tier vehicle.";
                    _vehicleThreeVehicle2Text.text = "You have a higher tier vehicle.";
                    _vehicleThreeVehicle3Text.text = "You have a higher tier vehicle.";
                    _vehicleThreeVehicle4Text.text = "You have a higher tier vehicle.";
                    _vehicleThreeVehicle5Text.text = "You have a higher tier vehicle.";
                    _vehicleThreeVehicle6Text.text = "You have a higher tier vehicle.";
                    _vehicleThreeVehicle7Text.text = "Already bought.";
                    _vehicleThreeVehicle8Text.text = "Press here to buy.";
                    return;
                case 8:
                    _vehicleThreeVehicle1Text.text = "You have a higher tier vehicle.";
                    _vehicleThreeVehicle2Text.text = "You have a higher tier vehicle.";
                    _vehicleThreeVehicle3Text.text = "You have a higher tier vehicle.";
                    _vehicleThreeVehicle4Text.text = "You have a higher tier vehicle.";
                    _vehicleThreeVehicle5Text.text = "You have a higher tier vehicle.";
                    _vehicleThreeVehicle6Text.text = "You have a higher tier vehicle.";
                    _vehicleThreeVehicle7Text.text = "You have a higher tier vehicle.";
                    _vehicleThreeVehicle8Text.text = "Already bought.";
                    return;
            }
        }
    }

    public void Store2BuyUpgrade()
    {
        if (!_storeData.sausage2Open)
        {
            _storeUpgradesSecondButtonText.text = "Buy the second store. Price: 10000";
        }
        else
            _storeUpgradesSecondButtonText.text = "Click here to increase the capacity of Store 2. Current max cap: " + (_storeData.sausage2MaxStoreCapacity);
    }    
    
    public void Store3BuyUpgrade()
    {
        if (!_storeData.sausage3Open)
        {
            _storeUpgradesThirdButtonText.text = "Buy the third store. Price: 10000";
        }
        else
            _storeUpgradesThirdButtonText.text = "Click here to increase the capacity of Store 3. Current max cap: " + (_storeData.sausage3MaxStoreCapacity);
    }    
    
    
    public void Store4BuyUpgrade()
    {
        if (!_storeData.sausage4Open)
        {
            _storeUpgradesFourthButtonText.text = "Buy the fourth store. Price: 10000";
        }
        else
            _storeUpgradesFourthButtonText.text = "Click here to increase the capacity of Store 4. Current max cap: " + (_storeData.sausage4MaxStoreCapacity);
    }




}
