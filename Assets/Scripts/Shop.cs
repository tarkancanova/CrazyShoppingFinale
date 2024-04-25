using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] private PlayerData _playerData;
    [SerializeField] private CustomerData _customerData;
    [SerializeField] private ProductData _productData;
    public float serveTime;
    public float price;

    private void Start()
    {
        gameObject.tag = "Shop";
        serveTime = 1f;

        if (_playerData.restartButton)
        {
            _productData.mainProduct = "Hamburger";
        }

        switch (_productData.mainProduct)
        {
            case "Hamburger":
                price = 1f; break;
            case "Pizza":
                price = 4f; break;
            case "Barber":
                price = 10f; break;
            case "Market":
                price = 15f; break;
            case "Cafe":
                price = 20f; break;
        }
    }

    public IEnumerator ServeProduct()
    {
        while (true)
        {
            while (_productData.productQuantity > 0)
            {
                yield return new WaitForSeconds(serveTime * _customerData.peopleSpendDurationMultiplier);
                _playerData.Money += price;
                _productData.productQuantity -= 1 * _productData.productSpentPerService;
            }
            yield return new WaitUntil(() => _productData.productQuantity > 0);
        }
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Customer"))
        {
            StartCoroutine(ServeProduct());
            other.gameObject.SetActive(false);
        }
    }


}

