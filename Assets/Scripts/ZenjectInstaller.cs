using UnityEngine;
using Zenject;

public class ZenjectInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<SausageShop1>().FromComponentInHierarchy().AsSingle();
        Container.Bind<SausageShop2>().FromComponentInHierarchy().AsSingle();
        Container.Bind<SausageShop3>().FromComponentInHierarchy().AsSingle();
        Container.Bind<SausageShop4>().FromComponentInHierarchy().AsSingle();
    }
}