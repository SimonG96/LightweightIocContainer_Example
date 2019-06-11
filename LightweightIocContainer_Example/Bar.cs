// Author: Gockner, Simon
// Created: 2019-06-11
// Copyright(c) 2019 SimonG. All Rights Reserved.

using LightweightIocContainer_Example.Interfaces;

namespace LightweightIocContainer_Example
{
    public class Bar : IBar
    {
        public Bar(string name, IService service)
        {
            Name = name;
            Service = service;
        }

        public Bar(IService service)
        {
            Name = "This is Bar";
            Service = service;
        }

        public string Name { get; }
        public IService Service { get; }
    }
}