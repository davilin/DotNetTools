// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.Extensions.CommandLineUtils;

namespace Microsoft.Extensions.SecretManager.Tools.Internal
{
    public class ExtendedHelpCommandLineApplication : CommandLineApplication
    {
        public ExtendedHelpCommandLineApplication(bool throwOnUnexpectedArg = true)
            : base(throwOnUnexpectedArg)
        {
        }

        public string AdditionalHelpInfo { get; set; }
        public override string GetHelpText(string commandName = null)
        {
            return base.GetHelpText(commandName) + AdditionalHelpInfo;
        }
    }
}
