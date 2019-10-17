// Author: Gockner, Simon
// Created: 2019-06-11
// Copyright(c) 2019 SimonG. All Rights Reserved.

using LightweightIocContainer;
using LightweightIocContainer.Interfaces;
using LightweightIocContainer.Interfaces.Installers;
using LightweightIocContainer_Example.Factories;
using LightweightIocContainer_Example.Interfaces;

namespace LightweightIocContainer_Example.Installers
{
    public class Installer : IIocInstaller
    {
        public void Install(IIocContainer container)
        {
            container.Register<IAsyncClass, AsyncClass>();
            container.Register<IService, Service>(Lifestyle.Singleton);

            //factories
            container.RegisterFactory<IAsyncClassFactory>();
        }
    }
}