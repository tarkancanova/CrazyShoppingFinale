using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreTabFix : MonoBehaviour
{
    [SerializeField] private GameObject _storeTab;
    [SerializeField] private GameObject _upgradeBuilding;

    private void Update()
    {
        ActivateDeactivate();
    }


    private void ActivateDeactivate()
    {
        if (_storeTab.activeSelf)
        {
            _upgradeBuilding.SetActive(false);
        }
        else if (!_storeTab.activeSelf)
        {
            _upgradeBuilding.SetActive(true);
        }
    }
}
