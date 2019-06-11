// Author: Gockner, Simon
// Created: 2019-06-11
// Copyright(c) 2019 SimonG. All Rights Reserved.

using LightweightIocContainer_Example.Interfaces;

namespace LightweightIocContainer_Example.Factories
{
    public interface IAsyncClassFactory
    {
        IAsyncClass Create(IBar bar);
    }
}