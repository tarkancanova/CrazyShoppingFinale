using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SausageShop4 : Shop
{
    public Vector3 location { get; private set; }

    private void Awake()
    {
        location = gameObject.transform.position;
    }
}
