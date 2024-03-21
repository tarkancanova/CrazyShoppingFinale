using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class ClickHandler : MonoBehaviour
{
    [SerializeField] private GameObject _customerCreator;
    [SerializeField] private CustomerData _customerData;
    [SerializeField] private StoreData _storeData;
    [SerializeField] private ProductData _productData;


    private void Awake()
    {
    }

    private void Update()
    {
        OnClick();
    }

    private void OnClick()
    {
        if (Input.GetMouseButtonDown(0))
        {

            RaycastHit hit;
            Ray mouseClick = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(mouseClick, out hit) && hit.collider.CompareTag("Customer Creator") && _customerData.customersGoingToStores < _storeData.totalStoreCapacity && _productData.productQuantity > 0)
            {
                _productData.productQuantity -= 1 * _productData.productSpentPerService;
                _customerData.customersGoingToStores += 1;
                GameObject customer = CustomersObject.SharedInstance.GetPooledObject();
                if (customer != null)
                {
                    customer.transform.position = new Vector3(_customerCreator.transform.position.x, _customerCreator.transform.position.y, _customerCreator.transform.position.z + 1);
                    customer.SetActive(true);
                }
            }
            else
                return;
        }


    }
}
