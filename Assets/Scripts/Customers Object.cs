using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomersObject : MonoBehaviour
{
    public List<GameObject> customersList = new List<GameObject>();
    public static CustomersObject SharedInstance;

    public void Awake()
    {
        SharedInstance = this;

        foreach (Transform child in transform)
        {
            customersList.Add(child.gameObject);
        }
    }

    public GameObject GetPooledObject()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            if (!customersList[i].activeInHierarchy)
            {
                return customersList[i];
            }
        }
        return null;
    }

}
