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
        serveTime = 1f;

        if (_playerData.firstLoad)
        {
            _productData.mainProduct = "Sausage";
        }

        switch (_productData.mainProduct)
        {
            case "Sausage":
                price = 1f; break;
            case "Hamburger":
                price = 4f; break;
            case "Pizza":
                price = 10f; break;
            case "Unknown":
                price = 15f; break;
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

