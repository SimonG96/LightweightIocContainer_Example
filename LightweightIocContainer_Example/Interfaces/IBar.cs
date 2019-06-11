// Author: Gockner, Simon
// Created: 2019-06-11
// Copyright(c) 2019 SimonG. All Rights Reserved.

namespace LightweightIocContainer_Example.Interfaces
{
    public interface IBar
    {
        string Name { get; }
        IService Service { get; }
    }
}