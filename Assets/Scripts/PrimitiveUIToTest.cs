using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PrimitiveUIToTest : MonoBehaviour
{
    //Scriptable Object references
    [SerializeField] private PlayerData _playerData;
    [SerializeField] private ProductData _productData;
    //Variables for Top-Left part of UI showing products and money owned by Player
    [SerializeField] private TMP_Text _moneyOwnedText;
    [SerializeField] private TMP_Text _productOwnedText;
    //Variables for Top-Right part of UI for customer and store upgrades
    [SerializeField] private GameObject _storeTab;
    [SerializeField] private GameObject _customerTab;
    //Variables for Vehicles
    [SerializeField] private TMP_Text _vehicleOneText;
    [SerializeField] private TMP_Text _vehicleTwoText;
    [SerializeField] private TMP_Text _vehicleThreeText;
    [SerializeField] private TMP_Text _vehicleFourText;
    [SerializeField] private GameObject _vehicleOne;
    [SerializeField] private GameObject _vehicleTwo;
    [SerializeField] private GameObject _vehicleThree;
    [SerializeField] private GameObject _vehicleFour;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _moneyOwnedText.text = "Money: " + _playerData.Money;
        _productOwnedText.text = "Product Owned: " + _productData.productQuantity;
        _vehicleOneText.text = "Owned Vehicle: " + _vehicleOne.GetComponent<Vehicle>().vehicleName;
        _vehicleTwoText.text = "Owned Vehicle: " + _vehicleTwo.GetComponent<Vehicle>().vehicleName;
        _vehicleThreeText.text = "Owned Vehicle: " + _vehicleThree.GetComponent<Vehicle>().vehicleName;
        _vehicleFourText.text = "Owned Vehicle: " + _vehicleFour.GetComponent<Vehicle>().vehicleName;
    }
}
