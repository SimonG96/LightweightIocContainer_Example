// Author: Gockner, Simon
// Created: 2019-06-11
// Copyright(c) 2019 SimonG. All Rights Reserved.

using System.Threading.Tasks;
using LightweightIocContainer_Example.Interfaces;

namespace LightweightIocContainer_Example
{
    public class AsyncClass : IAsyncClass
    {
        private bool _isInitialized;

        public AsyncClass(IService service, IBar bar)
        {
            Service = service;
            Bar = bar;
        }

        public string Name { get; private set; }
        public IService Service { get; }
        public IBar Bar { get; }


        public async Task InitializeAsync()
        {
            await Task.Run(async () =>
            {
                await Task.Delay(1000);
                Name = "AsyncName";
                _isInitialized = true;
            });
        }
    }
}