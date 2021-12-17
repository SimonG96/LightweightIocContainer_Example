// Author: Gockner, Simon
// Created: 2019-06-11
// Copyright(c) 2019 SimonG. All Rights Reserved.

using LightweightIocContainer;
using LightweightIocContainer.Interfaces.Installers;
using LightweightIocContainer.Interfaces.Registrations;
using LightweightIocContainer_Example.Factories;
using LightweightIocContainer_Example.Interfaces;

namespace LightweightIocContainer_Example.Installers
{
    public class Installer : IIocInstaller
    {
        public void Install(IRegistrationCollector registration)
        {
            registration.Add<IAsyncClass, AsyncClass>().WithFactory<IAsyncClassFactory>();
            registration.Add<IService, Service>(Lifestyle.Singleton);
        }
    }
}