// Author: Gockner, Simon
// Created: 2019-06-11
// Copyright(c) 2019 SimonG. All Rights Reserved.

using LightweightIocContainer.Interfaces;
using LightweightIocContainer.Registrations;
using LightweightIocContainer_Example.Factories;
using LightweightIocContainer_Example.Interfaces;

namespace LightweightIocContainer_Example.Installers
{
    public class BarInstaller : IIocInstaller
    {
        public void Install(IIocContainer container)
        {
            container.Register(RegistrationFactory.Register<IBar, Bar>());

            //factories
            container.Register(RegistrationFactory.RegisterFactory<IBarFactory>(container));
        }
    }
}