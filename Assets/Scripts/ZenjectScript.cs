using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using Zenject;

public class ZenjectScript : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<SausageShop1>().FromComponentInHierarchy().AsSingle();
        Container.Bind<SausageShop2>().FromComponentInHierarchy().AsSingle();
    }
}
