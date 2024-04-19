using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductChange : MonoBehaviour
{
    [SerializeField] private ProductData _productData;

    [SerializeField] private GameObject _barber;
    [SerializeField] private GameObject _pizza;
    [SerializeField] private GameObject _cafe;
    [SerializeField] private GameObject _market;
    [SerializeField] private GameObject _burger;

    private void Awake()
    {
    }

    private void Start()
    {
        switch (_productData.mainProduct)
        {
            case "Barber":
                _barber.SetActive(true);
                _pizza.SetActive(false);
                _cafe.SetActive(false);
                _market.SetActive(false);
                _burger.SetActive(false);
                break;
            case "Pizza":
                _barber.SetActive(false);
                _pizza.SetActive(true);
                _cafe.SetActive(false);
                _market.SetActive(false);
                _burger.SetActive(false);
                break;  
            case "Cafe":
                _barber.SetActive(false);
                _pizza.SetActive(false);
                _cafe.SetActive(true);
                _market.SetActive(false);
                _burger.SetActive(false);
                break; 
            case "Hamburger":
                _barber.SetActive(false);
                _pizza.SetActive(false);
                _cafe.SetActive(false);
                _market.SetActive(false);
                _burger.SetActive(true);
                break; 
            case "Market":
                _barber.SetActive(false);
                _pizza.SetActive(false);
                _cafe.SetActive(false);
                _market.SetActive(true);
                _burger.SetActive(false);
                break;

        }
    }
}
