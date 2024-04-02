// Copyright (c) Christophe Gondouin (CGO Conseils). All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using XrmFramework.DeployUtils;

namespace Deploy.Plugins
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            RegistrationHelper.RegisterPluginsAndWorkflows<XrmFramework.Plugin>("DimsiNation.CustomApis");
            Console.WriteLine("Assembly deployed successfully");
        }
    }   
}