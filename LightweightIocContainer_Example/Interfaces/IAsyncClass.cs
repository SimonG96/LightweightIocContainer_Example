// Author: Gockner, Simon
// Created: 2019-06-11
// Copyright(c) 2019 SimonG. All Rights Reserved.

using System.Threading.Tasks;

namespace LightweightIocContainer_Example.Interfaces
{
    public interface IAsyncClass
    {
        string Name { get; }
        IService Service { get; }
        IBar Bar { get; }

        Task InitializeAsync();
    }
}