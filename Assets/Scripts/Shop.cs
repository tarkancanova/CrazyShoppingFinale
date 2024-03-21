using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] private PlayerData _playerData;
    [SerializeField] private ProductData _productData;
    public float serveTime;
    public float price;

    private void Start()
    {
        serveTime = 1f;
        price = 1f;
    }

    public IEnumerator ServeProduct()
    {
        while (true)
        {
            while (_productData.productQuantity > 0)
            {
                yield return new WaitForSeconds(serveTime);
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

