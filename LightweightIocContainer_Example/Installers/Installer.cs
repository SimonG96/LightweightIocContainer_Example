// Author: Gockner, Simon
// Created: 2019-06-11
// Copyright(c) 2019 SimonG. All Rights Reserved.

using LightweightIocContainer;
using LightweightIocContainer.Interfaces;
using LightweightIocContainer.Interfaces.Installers;
using LightweightIocContainer.Registrations;
using LightweightIocContainer_Example.Factories;
using LightweightIocContainer_Example.Interfaces;

namespace LightweightIocContainer_Example.Installers
{
    public class Installer : IIocInstaller
    {
        public void Install(IIocContainer container)
        {
            container.Register(RegistrationFactory.Register<IAsyncClass, AsyncClass>());
            container.Register(RegistrationFactory.Register<IService, Service>(Lifestyle.Singleton));

            //factories
            container.Register(RegistrationFactory.RegisterFactory<IAsyncClassFactory>(container));
        }
    }
}