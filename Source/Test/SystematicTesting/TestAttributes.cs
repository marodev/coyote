﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System;

namespace Microsoft.Coyote.SystematicTesting
{
    /// <summary>
    /// Attribute for declaring the entry point to a Coyote test.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class TestAttribute : Attribute
    {
    }

    /// <summary>
    /// Attribute for declaring the initialization method to be called before testing starts.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class TestInitAttribute : Attribute
    {
    }

    /// <summary>
    /// Attribute for declaring a cleanup method to be called when all test iterations terminate.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class TestDisposeAttribute : Attribute
    {
    }

    /// <summary>
    /// Attribute for declaring a cleanup method to be called when each test iteration terminates.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class TestIterationDisposeAttribute : Attribute
    {
    }

    /// <summary>
    /// Attribute for declaring a method to be called for getting the state hash of the program.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class TestStateHashAttribute : Attribute
    {
    }
}
