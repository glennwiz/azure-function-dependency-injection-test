﻿using System;
using Microsoft.Azure.WebJobs.Description;

namespace ExampleFunction
{
    /// <summary>
    /// Attribute used to inject a dependency into the function completes.
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false)]
    [Binding]
    public sealed class InjectAttribute : Attribute
    {
    }
}
