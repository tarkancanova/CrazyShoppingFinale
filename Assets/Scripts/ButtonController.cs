using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    [SerializeField] private GameObject _vehicleTab;
    [SerializeField] private GameObject _vehicle1Tab;
    [SerializeField] private GameObject _vehicle2Tab;
    [SerializeField] private GameObject _vehicle3Tab;
    [SerializeField] private GameObject _vehicle4Tab;
    [SerializeField] private GameObject _vehicle1;
    [SerializeField] private VehicleData _vehicle1Data;
    [SerializeField] private VehicleData _vehicle2Data;
    [SerializeField] private VehicleData _vehicle3Data;
    [SerializeField] private VehicleData _vehicle4Data;
    [SerializeField] private VehicleData _vehicle5Data;
    [SerializeField] private VehicleData _vehicle6Data;
    [SerializeField] private VehicleData _vehicle7Data;
    [SerializeField] private VehicleData _vehicle8Data;

    public void OpenCloseVehiclesTab()
    {
        if (_vehicleTab.activeSelf)
        {
            _vehicleTab.SetActive(false);
        }        
        else if (!_vehicleTab.activeSelf)
        {
            _vehicleTab.SetActive(true);
        }
    }

    public void OpenCloseVehicle1Tab()
    {
        if (_vehicle1Tab.activeSelf)
        {
            _vehicle1Tab.SetActive(false);
        }        
        else if (!_vehicle1Tab.activeSelf)
        {
            _vehicle1Tab.SetActive(true);
        }
    }    
    public void OpenCloseVehicle2Tab()
    {
        if (_vehicle2Tab.activeSelf)
        {
            _vehicle2Tab.SetActive(false);
        }        
        else if (!_vehicle2Tab.activeSelf)
        {
            _vehicle2Tab.SetActive(true);
        }
    }    
    public void OpenCloseVehicle3Tab()
    {
        if (_vehicle3Tab.activeSelf)
        {
            _vehicle3Tab.SetActive(false);
        }        
        else if (!_vehicle3Tab.activeSelf)
        {
            _vehicle3Tab.SetActive(true);
        }
    } 
    public void OpenCloseVehicle4Tab()
    {
        if (_vehicle4Tab.activeSelf)
        {
            _vehicle4Tab.SetActive(false);
        }        
        else if (!_vehicle4Tab.activeSelf)
        {
            _vehicle4Tab.SetActive(true);
        }
    }

    public void BuyVehicle1For1()
    {
        if (!_vehicle1.activeSelf)
        {
            _vehicle1.SetActive(true);
            Vehicle vehicle = _vehicle1.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle1Data;
        }
        else
        {
            return;
        }
    }    
    public void BuyVehicle2For1()
    {
        if (!_vehicle1.activeSelf)
        {
            _vehicle1.SetActive(true);
            Vehicle vehicle = _vehicle1.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle2Data;
        }
        else
        {
            Vehicle vehicle = _vehicle1.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle2Data;
        }
    }    
    public void BuyVehicle3For1()
    {
        if (!_vehicle1.activeSelf)
        {
            _vehicle1.SetActive(true);
            Vehicle vehicle = _vehicle1.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle3Data;
        }
        else
        {
            Vehicle vehicle = _vehicle1.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle3Data;
        }
    }    
    public void BuyVehicle4For1()
    {
        if (!_vehicle1.activeSelf)
        {
            _vehicle1.SetActive(true);
            Vehicle vehicle = _vehicle1.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle4Data;
        }
        else
        {
            Vehicle vehicle = _vehicle1.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle4Data;
        }
    }    
    public void BuyVehicle5For1()
    {
        if (!_vehicle1.activeSelf)
        {
            _vehicle1.SetActive(true);
            Vehicle vehicle = _vehicle1.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle5Data;
        }
        else
        {
            Vehicle vehicle = _vehicle1.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle5Data;
        }
    }
    public void BuyVehicle6For1()
    {
        if (!_vehicle1.activeSelf)
        {
            _vehicle1.SetActive(true);
            Vehicle vehicle = _vehicle1.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle6Data;
        }
        else
        {
            Vehicle vehicle = _vehicle1.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle6Data;
        }
    }
    public void BuyVehicle7For1()
    {
        if (!_vehicle1.activeSelf)
        {
            _vehicle1.SetActive(true);
            Vehicle vehicle = _vehicle1.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle7Data;
        }
        else
        {
            Vehicle vehicle = _vehicle1.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle7Data;
        }
    }
    public void BuyVehicle8For1()
    {
        if (!_vehicle1.activeSelf)
        {
            _vehicle1.SetActive(true);
            Vehicle vehicle = _vehicle1.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle8Data;
        }
        else
        {
            Vehicle vehicle = _vehicle1.GetComponent<Vehicle>();
            vehicle._vehicleData = _vehicle8Data;
        }
    }//vehicle slot1


}
