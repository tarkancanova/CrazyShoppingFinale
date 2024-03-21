using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Vehicle : MonoBehaviour
{
    [SerializeField] private GameObject _startPoint;
    [SerializeField] private GameObject _deliveryPoint;
    [SerializeField] public VehicleData _vehicleData;
    public int vehicleCapacity;
    private float _deliveryInterval = 5f;
    private NavMeshAgent _navMeshAgent;
    public string vehicleName;

    private void Awake()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        vehicleCapacity = _vehicleData.vehicleCapacity;
        vehicleName = _vehicleData.vehicleName;
    }

    private void OnEnable()
    {
        StartCoroutine(DeliveryDrive());
    }


    IEnumerator DeliveryDrive()
    {
        yield return new WaitForSeconds(_deliveryInterval);
        this.transform.position = _startPoint.transform.position;
        _navMeshAgent.destination = _deliveryPoint.transform.position;
    }
}
