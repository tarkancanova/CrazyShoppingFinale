using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Zenject;

public class Customer : MonoBehaviour
{
    [SerializeField] private CustomerData _customerData;
    [SerializeField] private PlayerData _playerData;
    [SerializeField] private StoreData _storeData;
    private NavMeshAgent _navMeshAgent;
    private int _shopDecider;
    private float _customerSpeed = 1f;
    [SerializeField] private SausageShop1 _sausageShop1;
    [SerializeField] private SausageShop2 _sausageShop2;
    [SerializeField] private SausageShop3 _sausageShop3;
    [SerializeField] private SausageShop4 _sausageShop4;

    private void Awake()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void OnEnable()
    {
        _navMeshAgent.speed = _customerSpeed * _customerData.movementSpeedMultiplier;
        MoveToRandomShop();
    }

    private void MoveToRandomShop()
    {
        int selectedShop = Random.Range(1, 5); 

        switch (selectedShop)
        {
            case 1:
                if (_storeData.sausageMaxStoreCapacity > _customerData.customersGoingToSausageShop)
                {
                    _customerData.customersGoingToSausageShop += 1;
                   
                    _navMeshAgent.destination = _sausageShop1.transform.position;
                }
                else
                {
                    MoveToRandomShop(); 
                }
                break;
            case 2:
                if (_storeData.sausage2MaxStoreCapacity > _customerData.customersGoingToSausage2)
                {
                    _customerData.customersGoingToSausage2 += 1; 
                 
                    _navMeshAgent.destination = _sausageShop2.transform.position;
                }
                else
                {
                    MoveToRandomShop(); 
                }
                break;
            case 3:
                if (_storeData.sausage3MaxStoreCapacity > _customerData.customersGoingToSausage3)
                {
                    _customerData.customersGoingToSausage3 += 1; 
                 
                    _navMeshAgent.destination = _sausageShop3.transform.position;
                }
                else
                {
                    MoveToRandomShop();
                }
                break;
            case 4:
                if (_storeData.sausage4MaxStoreCapacity > _customerData.customersGoingToSausage4)
                {
                    _customerData.customersGoingToSausage4 += 1;
                    
                    _navMeshAgent.destination = _sausageShop4.transform.position;
                }
                else
                {
                    MoveToRandomShop(); 
                }
                break;
            default:
                Debug.LogError("Invalid shop selection!");
                break;
        }
    }
    //private void OnEnable()
    //{
    //    _navMeshAgent.speed = _customerSpeed * _customerData.movementSpeedMultiplier;

    //    if (!_storeData.sausage2Open)
    //    {
    //        _customerData.customersGoingToSausageShop += 1;
    //        _navMeshAgent.destination = _sausageShop1.location;
    //    }

    //    else if (_storeData.sausage2Open && !_storeData.sausage3Open)
    //    {
    //        if (_customerData.customersGoingToSausageShop < _storeData.sausageMaxStoreCapacity)
    //        {
    //            _customerData.customersGoingToSausageShop += 1;
    //            _navMeshAgent.destination = _sausageShop1.location;
    //        }

    //        else if (_customerData.customersGoingToSausageShop == _storeData.sausageMaxStoreCapacity)
    //        {
    //            _customerData.customersGoingToSausage2 += 1;
    //            _navMeshAgent.destination = _sausageShop2.location;
    //        }
    //    }

    //    else if (_storeData.sausage3Open && !_storeData.sausage4Open)
    //    {

    //        if (_customerData.customersGoingToSausageShop < _storeData.sausageMaxStoreCapacity)
    //        {
    //            _customerData.customersGoingToSausageShop += 1;
    //            _navMeshAgent.destination = _sausageShop1.location;
    //        }

    //        else if (_customerData.customersGoingToSausageShop == _storeData.sausageMaxStoreCapacity && _customerData.customersGoingToSausage2 < _storeData.sausage2MaxStoreCapacity)
    //        {
    //            _customerData.customersGoingToSausage2 += 1;
    //            _navMeshAgent.destination = _sausageShop2.location;
    //        }

    //        else if (_customerData.customersGoingToSausage2 == _storeData.sausage2MaxStoreCapacity)
    //        {
    //            _customerData.customersGoingToSausage3 += 1;
    //            _navMeshAgent.destination = _sausageShop3.location;
    //        }
    //    }

    //    else if (_storeData.sausage4Open)
    //    {
    //        if (_customerData.customersGoingToSausageShop < _storeData.sausageMaxStoreCapacity)
    //        {
    //            _customerData.customersGoingToSausageShop += 1;
    //            _navMeshAgent.destination = _sausageShop1.location;
    //        }

    //        else if (_customerData.customersGoingToSausageShop == _storeData.sausageMaxStoreCapacity && _customerData.customersGoingToSausage2 < _storeData.sausage2MaxStoreCapacity)
    //        {
    //            _customerData.customersGoingToSausage2 += 1;
    //            _navMeshAgent.destination = _sausageShop2.location;
    //        }

    //        else if (_customerData.customersGoingToSausageShop == _storeData.sausageMaxStoreCapacity && _customerData.customersGoingToSausage3 < _storeData.sausage3MaxStoreCapacity)
    //        {
    //            _customerData.customersGoingToSausage3 += 1;
    //            _navMeshAgent.destination = _sausageShop3.location;
    //        }

    //        else if (_customerData.customersGoingToSausage3 == _storeData.sausage3MaxStoreCapacity)
    //        {
    //            _customerData.customersGoingToSausage4 += 1;
    //            _navMeshAgent.destination = _sausageShop4.location;
    //        }
    //    }
    //}
}
