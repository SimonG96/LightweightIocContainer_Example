// Author: Gockner, Simon
// Created: 2019-06-11
// Copyright(c) 2019 SimonG. All Rights Reserved.

using System;
using LightweightIocContainer;
using LightweightIocContainer_Example.Factories;
using LightweightIocContainer_Example.Interfaces;

namespace LightweightIocContainer_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Bootstrapper bootstrapper = new();
            IocContainer kernel = bootstrapper.InstantiateContainer();

            IFooFactory fooFactory = kernel.Resolve<IFooFactory>();
            IFoo foo = fooFactory.Create();

            Console.WriteLine(foo.Bar.Name);
            Console.WriteLine(foo.Bar.Service.ServiceName);
            Console.WriteLine(foo.ClassAsync.Name);

            Console.ReadLine();
            kernel.Dispose();
        }
    }
}
