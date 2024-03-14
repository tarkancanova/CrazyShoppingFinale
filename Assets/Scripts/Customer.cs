using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Zenject;

public class Customer : MonoBehaviour
{
    [SerializeField] private CustomerData _customerData;
    [SerializeField] private PlayerData _playerData;
    private NavMeshAgent _navMeshAgent;
    private int _shopDecider;
    [Inject] SausageShop1 sausageShop1;

    private void Awake()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Start()
    {
        
        //_navMeshAgent.destination = sausageShop1.location;
    }

    private void Update()
    {
        Debug.Log(sausageShop1.location);
    }
}
