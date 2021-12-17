// Author: Gockner, Simon
// Created: 2019-06-11
// Copyright(c) 2019 SimonG. All Rights Reserved.

using LightweightIocContainer;
using LightweightIocContainer.Interfaces;
using LightweightIocContainer_Example.Installers;

namespace LightweightIocContainer_Example
{
    public class Bootstrapper
    {
        public IocContainer InstantiateContainer()
        {
            IocContainer kernel = new();

            kernel.Install(new Installer(),
                new FooInstaller(),
                new BarInstaller());

            return kernel;
        }
    }
}