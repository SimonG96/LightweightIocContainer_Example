﻿// Author: Gockner, Simon
// Created: 2019-06-11
// Copyright(c) 2019 SimonG. All Rights Reserved.

namespace LightweightIocContainer_Example.Interfaces
{
    public interface IFoo
    {
        IBar Bar { get; }
        IAsyncClass ClassAsync { get; }
    }
}