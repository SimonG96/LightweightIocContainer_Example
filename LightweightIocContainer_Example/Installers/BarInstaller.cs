// Author: Gockner, Simon
// Created: 2019-06-11
// Copyright(c) 2019 SimonG. All Rights Reserved.

using LightweightIocContainer.Interfaces.Installers;
using LightweightIocContainer.Interfaces.Registrations;
using LightweightIocContainer_Example.Factories;
using LightweightIocContainer_Example.Interfaces;

namespace LightweightIocContainer_Example.Installers
{
    public class BarInstaller : IIocInstaller
    {
        public void Install(IRegistrationCollector registration) => registration.Add<IBar, Bar>().WithFactory<IBarFactory>();
    }
}