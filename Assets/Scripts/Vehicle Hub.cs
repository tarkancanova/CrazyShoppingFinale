using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class VehicleHub : MonoBehaviour
{
    [SerializeField] private ProductData _productData;
    [SerializeField] private GameObject _finishObject;
    [SerializeField] private GameObject _startObject;
    [SerializeField] private VehicleData _vehicleData;
    private float _productDeliveryDuration = 2f;
    private int _productsWillBeDelivered;

    private void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Vehicle") && this.gameObject.CompareTag("Deliver"))
        {
            
            StartCoroutine(DeliverProducts(other));
            
            
        }

        else if (other.CompareTag("Vehicle") && this.gameObject.CompareTag("Disappear"))
        {
            other.gameObject.SetActive(false);
            other.transform.position = _startObject.transform.position;
            other.gameObject.SetActive(true);
        }
    }

    IEnumerator DeliverProducts(Collider other)
    {
        yield return new WaitForSeconds(_productDeliveryDuration);
        _productData.productQuantity += other.GetComponent<Vehicle>().vehicleCapacity;
        other.GetComponent<NavMeshAgent>().destination = _finishObject.transform.position;
    }
}
