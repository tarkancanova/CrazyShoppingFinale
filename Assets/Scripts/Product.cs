using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Product : MonoBehaviour
{
    [SerializeField] private ProductData _productData;
    private double _productPerSec;

    private void Update()
    {
        _productPerSec = _productData.productPerSec;
    }

    private void Start()
    {
        StartCoroutine(IncreaseProduct(_productData));
    }

    public IEnumerator IncreaseProduct(ProductData productData)
    {
        while (true)
        {
            productData.productQuantity += _productPerSec;
            yield return new WaitForSeconds(1f);
        }
    }



}
