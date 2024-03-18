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
    [Inject] SausageShop1 _sausageShop1;
    [Inject] SausageShop2 _sausageShop2;
    [Inject] SausageShop3 _sausageShop3;
    [Inject] SausageShop4 _sausageShop4;

    private void Awake()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void OnEnable()
    {

        if (!_storeData.sausage2Open)
        {
            _customerData.customersGoingToSausageShop += 1;
            _navMeshAgent.destination = _sausageShop1.location;
        }

        else if (_storeData.sausage2Open && !_storeData.sausage3Open)
        {
            if (_customerData.customersGoingToSausageShop < _storeData.sausageMaxStoreCapacity)
            {
                _customerData.customersGoingToSausageShop += 1;
                _navMeshAgent.destination = _sausageShop1.location;
            }

            else if (_customerData.customersGoingToSausageShop == _storeData.sausageMaxStoreCapacity)
            {
                _customerData.customersGoingToSausage2 += 1;
                _navMeshAgent.destination = _sausageShop2.location;
            }
        }

        else if (_storeData.sausage3Open && !_storeData.sausage4Open)
        {
            
            if (_customerData.customersGoingToSausageShop < _storeData.sausageMaxStoreCapacity)
            {
                _customerData.customersGoingToSausageShop += 1;
                _navMeshAgent.destination = _sausageShop1.location;
            }

            else if (_customerData.customersGoingToSausageShop == _storeData.sausageMaxStoreCapacity && _customerData.customersGoingToSausage2 < _storeData.sausage2MaxStoreCapacity)
            {
                _customerData.customersGoingToSausage2 += 1;
                _navMeshAgent.destination = _sausageShop2.location;
            }

            else if (_customerData.customersGoingToSausage2 == _storeData.sausage2MaxStoreCapacity)
            {
                _customerData.customersGoingToSausage3 += 1;
                _navMeshAgent.destination = _sausageShop3.location;
            }
        }

        else if (_storeData.sausage4Open)
        {
            if (_customerData.customersGoingToSausageShop < _storeData.sausageMaxStoreCapacity)
            {
                _customerData.customersGoingToSausageShop += 1;
                _navMeshAgent.destination = _sausageShop1.location;
            }

            else if (_customerData.customersGoingToSausageShop == _storeData.sausageMaxStoreCapacity && _customerData.customersGoingToSausage2 < _storeData.sausage2MaxStoreCapacity)
            {
                _customerData.customersGoingToSausage2 += 1;
                _navMeshAgent.destination = _sausageShop2.location;
            }

            else if (_customerData.customersGoingToSausageShop == _storeData.sausageMaxStoreCapacity && _customerData.customersGoingToSausage3 < _storeData.sausage3MaxStoreCapacity)
            {
                _customerData.customersGoingToSausage3 += 1;
                _navMeshAgent.destination = _sausageShop3.location;
            }

            else if (_customerData.customersGoingToSausage3 == _storeData.sausage3MaxStoreCapacity)
            {
                _customerData.customersGoingToSausage4 += 1;
                _navMeshAgent.destination = _sausageShop4.location;
            }
        }
    }
}
