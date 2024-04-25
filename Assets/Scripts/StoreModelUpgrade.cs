using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreModelUpgrade : MonoBehaviour
{
    [SerializeField] private StoreData _storeData;
    [SerializeField] private GameObject _store11;
    [SerializeField] private GameObject _store12;
    [SerializeField] private GameObject _store13;
    [SerializeField] private GameObject _store14;
    [SerializeField] private GameObject _store15;
    [SerializeField] private GameObject _store21;
    [SerializeField] private GameObject _store22;
    [SerializeField] private GameObject _store23;
    [SerializeField] private GameObject _store24;
    [SerializeField] private GameObject _store25;
    [SerializeField] private GameObject _store31;
    [SerializeField] private GameObject _store32;
    [SerializeField] private GameObject _store33;
    [SerializeField] private GameObject _store34;
    [SerializeField] private GameObject _store35;
    [SerializeField] private GameObject _store41;
    [SerializeField] private GameObject _store42;
    [SerializeField] private GameObject _store43;
    [SerializeField] private GameObject _store44;
    [SerializeField] private GameObject _store45;



    private void Update()
    {
        ChangeModels();
    }

    private void ChangeModels()
    {
        if (_storeData.sausageMaxStoreCapacity > 50 && _storeData.sausageMaxStoreCapacity < 100)
        {
                _store11.SetActive(false);
                _store12.SetActive(true);
        }
        else if (_storeData.sausageMaxStoreCapacity > 100 && _storeData.sausageMaxStoreCapacity < 200)
        {
                _store12.SetActive(false);
                _store13.SetActive(true);
        }
        else if (_storeData.sausageMaxStoreCapacity > 200 && _storeData.sausageMaxStoreCapacity < 500)
        {
                _store13.SetActive(false);
                _store14.SetActive(true);

        }        
        else if (_storeData.sausageMaxStoreCapacity > 500)
        {
                _store14.SetActive(false);
                _store15.SetActive(true);
        }
        //------------------------------------------------------------------------------------------------
        if (_storeData.sausage2MaxStoreCapacity > 50 && _storeData.sausage2MaxStoreCapacity < 100)
        {
            _store21.SetActive(false);
            _store22.SetActive(true);
        }
        else if (_storeData.sausage2MaxStoreCapacity > 100 && _storeData.sausage2MaxStoreCapacity < 200)
        {
            _store22.SetActive(false);
            _store23.SetActive(true);
        }
        else if (_storeData.sausage2MaxStoreCapacity > 200 && _storeData.sausage2MaxStoreCapacity < 500)
        {
            _store23.SetActive(false);
            _store24.SetActive(true);

        }
        else if (_storeData.sausage2MaxStoreCapacity > 500)
        {
            _store24.SetActive(false);
            _store25.SetActive(true);
        }
        //-------------------------------------------------------------------------------------------------
        if (_storeData.sausage3MaxStoreCapacity > 50 && _storeData.sausage3MaxStoreCapacity < 100)
        {
            _store31.SetActive(false);
            _store32.SetActive(true);
        }
        else if (_storeData.sausage3MaxStoreCapacity > 100 && _storeData.sausage3MaxStoreCapacity < 200)
        {
            _store32.SetActive(false);
            _store33.SetActive(true);
        }
        else if (_storeData.sausage3MaxStoreCapacity > 200 && _storeData.sausage3MaxStoreCapacity < 500)
        {
            _store33.SetActive(false);
            _store34.SetActive(true);

        }
        else if (_storeData.sausage3MaxStoreCapacity > 500)
        {
            _store34.SetActive(false);
            _store35.SetActive(true);
        }
        //------------------------------------------------------------------------------------------------------
        if (_storeData.sausage4MaxStoreCapacity > 50 && _storeData.sausage4MaxStoreCapacity < 100)
        {
            _store41.SetActive(false);
            _store42.SetActive(true);
        }
        else if (_storeData.sausage4MaxStoreCapacity > 100 && _storeData.sausage4MaxStoreCapacity < 200)
        {
            _store42.SetActive(false);
            _store43.SetActive(true);
        }
        else if (_storeData.sausage4MaxStoreCapacity > 200 && _storeData.sausage4MaxStoreCapacity < 500)
        {
            _store43.SetActive(false);
            _store44.SetActive(true);

        }
        else if (_storeData.sausage4MaxStoreCapacity > 500)
        {
            _store44.SetActive(false);
            _store45.SetActive(true);
        }
    }
}
