// Author: Gockner, Simon
// Created: 2021-12-17
// Copyright(c) 2021 SimonG. All Rights Reserved.

using LightweightIocContainer;
using LightweightIocContainer.Validation;
using LightweightIocContainer_Example;
using NUnit.Framework;

namespace Test.LightweightIocContainer_Example;

[TestFixture]
public class IocValidationTest
{
    [Test]
    public void ValidateIocContainerSetup()
    {
        Bootstrapper bootstrapper = new();
        IocContainer container = bootstrapper.InstantiateContainer();

        IocValidator validator = new(container);
        validator.Validate();
    }
}