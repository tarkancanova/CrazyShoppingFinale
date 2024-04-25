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
    public GameObject vehicleModel;

    private void Awake()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        vehicleCapacity = _vehicleData.vehicleCapacity;
        vehicleName = _vehicleData.vehicleName;
        vehicleModel = _vehicleData.vehicleObject;
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

    //private void VehicleModelAssignment()
    //{
    //    if (_vehicleData.vehicleTier == 1)
    //    {
    //        this.transform.GetChild(0).gameObject.SetActive(true);
    //    }
    //    else if (_vehicleData.vehicleTier == 2)
    //    {
    //        this.transform.GetChild(0).gameObject.SetActive(false);
    //        this.transform.GetChild(1).gameObject.SetActive(true);
    //    }
    //    else if (_vehicleData.vehicleTier == 3)
    //    {
    //        this.transform.GetChild(0).gameObject.SetActive(false);
    //        this.transform.GetChild(1).gameObject.SetActive(false);
    //        this.transform.GetChild(2).gameObject.SetActive(true);
    //    }
    //    else if (_vehicleData.vehicleTier == 4)
    //    {
    //        this.transform.GetChild(0).gameObject.SetActive(false);
    //        this.transform.GetChild(1).gameObject.SetActive(false);
    //        this.transform.GetChild(2).gameObject.SetActive(false);
    //        this.transform.GetChild(3).gameObject.SetActive(true);
    //    }
    //    else if (_vehicleData.vehicleTier == 5)
    //    {
    //        this.transform.GetChild(0).gameObject.SetActive(false);
    //        this.transform.GetChild(1).gameObject.SetActive(false);
    //        this.transform.GetChild(2).gameObject.SetActive(false);
    //        this.transform.GetChild(3).gameObject.SetActive(false);
    //        this.transform.GetChild(4).gameObject.SetActive(true);
    //    }
    //    else
    //        return;
    //}
}
