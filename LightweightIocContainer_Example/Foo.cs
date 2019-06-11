// Author: Gockner, Simon
// Created: 2019-06-11
// Copyright(c) 2019 SimonG. All Rights Reserved.

using System.Threading.Tasks;
using LightweightIocContainer_Example.Factories;
using LightweightIocContainer_Example.Interfaces;

namespace LightweightIocContainer_Example
{
    public class Foo : IFoo
    {
        public Foo(IBarFactory barFactory, IAsyncClassFactory asyncClassFactory)
        {
            string name = "This is from Foo";
            Bar = barFactory.Create(name);

            Task.Run(async () =>
            {
                ClassAsync = asyncClassFactory.Create(Bar);
                await ClassAsync.InitializeAsync();
            }).Wait();
        }

        public IBar Bar { get; }
        public IAsyncClass ClassAsync { get; private set; }
    }
}