using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SausageShop2 : Shop
{
    public Vector3 location { get; private set; }

    private void Awake()
    {
        location = gameObject.transform.position;
    }
}
